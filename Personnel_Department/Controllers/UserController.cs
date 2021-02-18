using Microsoft.EntityFrameworkCore;

using Personnel_Department.BL.ModelDataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    public class UserController
    {
        /// <summary>
        /// Список пользователь 
        /// </summary>
        public List<User> Users { get; init; }

        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public  UserController(bool visableDelete)
        {
            try
            {
                using ApplicationContext dbConnect = new ApplicationContext();
                Users = dbConnect.Users.AsNoTracking().ToList();
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
                Users = dbConnect.Users.AsNoTracking().ToList();
            }
            catch
            {
                throw new Exception("Error  connect BD");
            }
        }

        public static string CreateOrEditUser(User uUser)
        {
            try
            {
                using (ApplicationContext dbConnect = new ApplicationContext())
                {
                    dbConnect.Users.Update(uUser);
                    dbConnect.SaveChanges();
                }
                return "Операция прошла успешно";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}