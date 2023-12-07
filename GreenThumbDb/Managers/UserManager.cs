using GreenThumbDb.DataBase;
using GreenThumbDb.Models;
using GreenThumbDb.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GreenThumbDb.Managers
{
    public static class UserManager
    {


        public static User? SignedInUser;
        public static bool SignInUser(string userName, string password)
        {
            using (AppDbContext context = new())
            {
                //Hämtar user med samma lösenord och password. Inkluderar Garden för att SignedInUser ska ha detta inkluderat
                User? user = context.Users.Include(u => u.Garden).FirstOrDefault(u => u.UserName == userName && u.Password == password);
                if (user != null)
                {
                    SignedInUser = user;
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
            using (AppDbContext context = new())
            {
                UnitOfWorkRepository uow = new(context);
                User user = new User()
                {
                    UserName = userName,
                    Password = password,

                };
                uow.UserRepository.Add(user);
                uow.Complete();
                //Skapar en Garden på varje ny user. Sparar Garden efter usern eftersom Garden har userns id

                Garden garden = new Garden()
                {
                    UserId = user.Id,

                };
                uow.GardenRepository.Add(garden);
                uow.Complete();
            }

        }
    }
}
