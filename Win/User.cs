using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Win
{
    public class User
    {
        public static string UserName;
        public static string UserId;

        public static string GetFullName()
        {
            var fullName = new UnitOfWork().UsersRepo.Fetch(m => m.Id == UserId).FirstOrDefault()?.FullName;
            return fullName;
        }
    }
}
