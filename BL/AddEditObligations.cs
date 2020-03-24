using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.Repository;

namespace BL
{
    public class AddEditObligations : Form, IAddEdit<Obligations>
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private MethodType MethodType;
        public void Add(Obligations entity)
        {
            try
            {
                unitOfWork.ObligationsRepo.Insert(entity);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(Obligations entity)
        {
            try
            {
                unitOfWork.ObligationsRepo.Update(entity);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Obligations Details(int id)
        {
            return unitOfWork.ObligationsRepo.Find(m => m.Id == id);
        }

        public void Details(Form form)
        {
            
        }

        public object Init()
        {
            try
            {
                var id = (unitOfWork.ObligationsRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
                var controlNo = DateTime.Now.ToString("yyyy-MM-") + id.ToString("0000");
                unitOfWork.ObligationsRepo.Insert(new Obligations()
                {
                    Id = id,
                    ControlNo = controlNo
                });
                unitOfWork.Save();
                return controlNo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DateTime.Now.ToString("yyyy-MM-") + "0001";

        }

        public object Id { get; set; }
    }
}
