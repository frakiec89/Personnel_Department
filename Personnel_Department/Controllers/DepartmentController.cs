using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    class DepartmentController
    {
        readonly ApplicationContext dbConnect = new ApplicationContext();
        public List<Department> departments = new List<Department>();

        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public DepartmentController()
        {
            try
            {
                departments = dbConnect.Departments.ToList();
            }
            catch
            {
                throw new Exception("Error  connect BD");
            }
        }
    }
}