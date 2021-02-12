using Microsoft.EntityFrameworkCore;
using Personnel_Department.BL.ModelDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Personnel_Department.Controllers
{
    class UserController
    {
        readonly ApplicationContext dbConnect = new ApplicationContext();
        public List<User> users;

        public List<User> Refresh () => users = dbConnect.Users.ToList();


        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public  UserController(bool visableDelete)
        {
            try
            {
                users = dbConnect.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error  connect BD " + ex.Message);
            }
        }

        /// <summary>
        /// Все пользователи (и удаленные тоже)
        /// </summary>
        public UserController()
        {
            try
            {
                users = dbConnect.Users.ToList();
            }
            catch
            {
                throw new Exception("Error  connect BD");
            }
        }

        public static string EditOrCreateUser(User newUser)
        {
            try
            {
                using (ApplicationContext dbConnect = new ApplicationContext())
                {
                    dbConnect.Users.Add(newUser);
                    dbConnect.SaveChanges();
                }
                return "Сохранение прошло успешно";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}