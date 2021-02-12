using Personnel_Department.BL.ModelDataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    class UserController
    {
        /// <summary>
        /// Список пользователь 
        /// </summary>
        public List<User> Users { get; set; }

        public List<User> Refresh()
        {
            using ApplicationContext dbConnect = new ApplicationContext();
            return Users = dbConnect.Users.ToList();
        }


        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public  UserController(bool visableDelete)
        {
            try
            {
                using ApplicationContext dbConnect = new ApplicationContext();
                Users = dbConnect.Users.ToList();
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
                using ApplicationContext dbConnect = new ApplicationContext();
                Users = dbConnect.Users.ToList();
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