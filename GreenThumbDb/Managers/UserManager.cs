using GreenThumbDb.DataBase;
using System.Linq;

namespace GreenThumbDb.Managers
{
    public static class UserManager
    {



        public static bool SignInUser(string userName, string password)
        {

            using (AppDbContext context = new())
            {

                var userPassword = context.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);

                if (userPassword != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


        }
    }
}
