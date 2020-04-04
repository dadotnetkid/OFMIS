using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using Models;
using Models.Repository;

namespace Win
{
    public static class User
    {
        public static string UserName;
        public static string UserId;

        public static string GetFullName()
        {
            var fullName = new UnitOfWork().UsersRepo.Fetch(m => m.Id == UserId).FirstOrDefault()?.FullName;
            return fullName;
        }

        public static string GetUserLevel()
        {
            return new UnitOfWork().UsersRepo.Fetch(m => m.Id == UserId).FirstOrDefault()?.UserRole;
        }
        public static bool UserInAction(string action)
        {
            var unitOfWork = new UnitOfWork();
            var x = unitOfWork.UsersRepo.Find(m => m.Id == UserId);
            if (!unitOfWork.FunctionsRepo.Fetch(m => m.Action == action).Any())
            {
                unitOfWork.FunctionsRepo.Insert(new Functions() { Action = action });
                unitOfWork.Save();
            }


            var userRoles = unitOfWork.UserRolesRepo.Find(m => m.Name == "Administratror", "Functions");
            if (userRoles != null)
            {

                if (userRoles.Functions.All(m => m.Action != action))
                {
                    var function = unitOfWork.FunctionsRepo.Find(m => m.Action == action, false);
                    userRoles.Functions.Add(function);
                    unitOfWork.Save();
 
                }
            }


            if (x.UserRoles.Any(c => c.Functions.Any(n => n.Action == action)))
                return true;

            MessageBox.Show(
                @"You dont have any permission to access this method 
 Please Contact System Administrator", @"Access Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
