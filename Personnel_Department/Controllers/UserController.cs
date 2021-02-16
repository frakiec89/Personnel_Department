using Microsoft.EntityFrameworkCore;

using Personnel_Department.BL.ModelDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Update;

namespace Personnel_Department.Controllers
{
    public class UserController
    {
        /// <summary>
        /// Список пользователь 
        /// </summary>
        public List<User> Users { get; set; }

        public List<User> Refresh()
        {
            using ApplicationContext dbConnect = new ApplicationContext();
            return Users = dbConnect.Users.AsNoTracking().ToList();
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

        public static string CreateUser(User newUser)
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
        //public static string EditUser(User newUser)
        //{
        //    try
        //    {
        //        using (ApplicationContext dbConnect = new ApplicationContext())
        //        {
        //            dbConnect.Users.Update(newUser);
        //            dbConnect.SaveChanges();
        //        }
        //        return "Сохранение прошло успешно";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}

    }
}