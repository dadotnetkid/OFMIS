using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Repository;

namespace Helpers
{
    public class ScannerHelper
    {
        public static void SaveImage(string folderName, string offcAcr, int refId, string tableName, Image image)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var root = $@"\\plgunv_nas\is_docs\{folderName}\{offcAcr}";

                if (!Directory.Exists(root))
                    Directory.CreateDirectory(root);
                var fileName = Guid.NewGuid().ToString();

                var path = Path.Combine(root, fileName + ".png");
                image.Save(path, ImageFormat.Png);
                unitOfWork.FilesRepo.Insert(new Models.Files()
                {
                    RefId = refId,
                    TableName = tableName,
                    RootFolder = root,
                    Path = fileName,

                });
                unitOfWork.Save();

            }
        }

        public static void SaveImage(string folderName, string offcAcr, int refId, string tableName, string originalFileName, string createdBy, Image image)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var root = $@"\\plgunv_nas\is_docs\{folderName}\{offcAcr}";

                if (!Directory.Exists(root))
                    Directory.CreateDirectory(root);
                var fileName = Guid.NewGuid().ToString();

                var path = Path.Combine(root, fileName + ".png");
                image.Save(path, ImageFormat.Png);
                var counter = unitOfWork.FilesRepo.Fetch(x => x.RefId == refId && x.OriginalFileName.Contains(originalFileName)).Count();
                var origFile = originalFileName + $"({counter + 1}).png";
                unitOfWork.FilesRepo.Insert(new Models.Files()
                {
                    RefId = refId,
                    TableName = tableName,
                    RootFolder = root,
                    Path = fileName + ".png",
                    OriginalFileName = counter == 0 ? originalFileName : origFile,
                    CreatedBy = createdBy
                });
                unitOfWork.Save();

            }
        }
        public static void SaveFiles(string folderName, string offcAcr, int refId, string tableName, string createdBy, Action<WebClient> web)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var root = $@"\\plgunv_nas\is_docs\{folderName}\{offcAcr}";
                if (!Directory.Exists(root))
                    Directory.CreateDirectory(root);
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                // root = Path.Combine(root, Guid.NewGuid().ToString(), Path.GetExtension(ofd.FileName));
                var id = Guid.NewGuid().ToString();
                //    File.Copy(ofd.FileName, Path.Combine(root, id + Path.GetExtension(ofd.FileName)));
                WebClient webClient = new WebClient();
                webClient.UploadFileAsync(new Uri(Path.Combine(root, id + Path.GetExtension(ofd.FileName))), ofd.FileName);
                web(webClient);

                unitOfWork.FilesRepo.Insert(new Models.Files()
                {
                    RefId = refId,
                    TableName = tableName,
                    RootFolder = root,
                    Path = id + Path.GetExtension(ofd.FileName),
                    OriginalFileName = Path.GetFileName(ofd.FileName),
                    CreatedBy = createdBy
                });

                unitOfWork.Save();
            }
        }

        public static void DownloadFile(string tableName, int refId, Action<WebClient> progressChanged)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var file = unitOfWork.FilesRepo.Find(x => x.Id == refId);
                if (file == null)
                    return;
                var path = Path.Combine(file?.RootFolder, file?.Path);
                var res = Path.Combine(sfd.FileName + Path.GetExtension(path));
                //File.Copy(path, res);
                var webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri(path), res);
                progressChanged(webClient);
                webClient.DownloadFileCompleted += (s, e) =>
                {
                    if (MessageBox.Show("Do you want to open file?", "File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    Process.Start(res);
                };
                //if (MessageBox.Show("Do you want to open file?", "File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                //    return;
                //Process.Start(res);
            }
        }

        public static void DeleteFile(int fileId)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var file = unitOfWork.FilesRepo.Find(x => x.Id == fileId);
                var path = Path.Combine(file.RootFolder, file.Path);
                File.Delete(path);
                unitOfWork.FilesRepo.Delete(x => x.Id == fileId);
                unitOfWork.Save();
            }
        }

        public static void DeleteFile(string tableName, int refId)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var file = unitOfWork.FilesRepo.Find(x => x.RefId == refId && x.TableName == tableName);
                var path = Path.Combine(file.RootFolder, file.Path);
                File.Delete(path);
                unitOfWork.FilesRepo.Delete(x => x.RefId == refId && x.TableName == tableName);
                unitOfWork.Save();
            }
        }
        public static Image LoadImage(int refId, string tableName)
        {
            using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
            {


                UnitOfWork unitOfWork = new UnitOfWork();
                var file = unitOfWork.FilesRepo.Find(x => x.RefId == refId && x.TableName == tableName);
                if (file == null)
                    return null;
                var path = Path.Combine(file?.RootFolder, file?.Path + ".png");
                var image = Image.FromFile(path);
                return image;
            }
        }

        public static byte[] ToImageByte(int refId, string tableName)
        {
            var image = LoadImage(refId, tableName);
            MemoryStream ms = new MemoryStream();
            if (image == null)
                return null;
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
