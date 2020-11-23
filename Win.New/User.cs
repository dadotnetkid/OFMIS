using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;

namespace Win
{
    public static class User
    {
        public static string UserName => GetUserName();
        public static string UserId;
        public static LoginViewModel Token { get; set; }
        public static string GetUserName()
        {
            return Token.UserName;
        }

        public static int? OfficeId() => Token.OfficeId.ToInt();
        public static string GetFullName()
        {
            return Token.FullName;
        }
        public static string GetFullName(string userId)
        {
            var fullName = new UnitOfWork().UsersRepo.Fetch(m => m.Id == userId).FirstOrDefault()?.FullName;
            return fullName;
        }
        public static string GetUserLevel()
        {
            return Token.UserRoles;
        }
        public static bool UsersInRole(params string[] userRole)
        {
            //var unitOfWork = new UnitOfWork();
            //var userRoles = unitOfWork.UserRolesRepo.Fetch(m => userRole.Contains(m.Name));
            var userRoles = Token.UserRoles.Split(',').Select(x => new { userRole = x });
            return
                userRoles.Any(x =>
                    userRole.Contains(x.userRole)); //userRoles.Any(x => x.Users.Any(m => m.Id == UserId));
        }
        public static bool UserInAction(string action)
        {
            /*
            var unitOfWork = new UnitOfWork();
            var x = unitOfWork.UsersRepo.Find(m => m.Id == UserId, "UserRoles");
            if (!unitOfWork.FunctionsRepo.Fetch(m => m.Action == action).Any())
            {
                unitOfWork.FunctionsRepo.Insert(new Functions() { Action = action });
                unitOfWork.Save();
            }


            var userRoles = unitOfWork.UserRolesRepo.Find(m => m.Name == "Administrator", "Functions");
            if (userRoles != null)
            {

                if (userRoles.Functions.All(m => m.Action != action))
                {
                    var function = unitOfWork.FunctionsRepo.Find(m => m.Action == action, false);
                    userRoles.Functions.Add(function);
                    unitOfWork.Save();

                }
            }
            */
            var functions = Token.Functions.Split(',').Select(x => new { Function = x });


            if (functions.Any(x=>x.Function== action))
                return true;

            MessageBox.Show(
                @"You dont have any permission to access this method 
 Please Contact System Administrator", @"Access Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public static bool CheckOwner(string createdBy)
        {
            if (UsersInRole("Administrator"))
            {
                return true;
                if ((createdBy != null && createdBy != UserId))
                {
                    MessageBox.Show(@"You cannot edit this item. Please contact the user created this item.", @"Item is not editable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }
    }
}
