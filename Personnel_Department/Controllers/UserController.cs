using Personnel_Department.BL.ModelDataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    class UserController
    {
        readonly ApplicationContext dbConnect = new ApplicationContext();
        public List<User> users = new List<User>();

        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public UserController(bool visableDelete)
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

    }
}