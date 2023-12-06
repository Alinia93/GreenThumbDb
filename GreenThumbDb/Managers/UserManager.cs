using GreenThumbDb.DataBase;
using GreenThumbDb.Models;
using GreenThumbDb.Repository;
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

        public static bool CheckUserName(string userName)
        {
            using (AppDbContext context = new())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == userName);
                if (user == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void AddUser(string userName, string password)
        {
            User user = new User()
            {
                UserName = userName,
                Password = password
            };

            using (AppDbContext context = new())
            {

                UnitOfWorkRepository uow = new(context);
                uow.UserRepository.Add(user);
                uow.UserRepository.Complete();
            }

        }
    }
}
