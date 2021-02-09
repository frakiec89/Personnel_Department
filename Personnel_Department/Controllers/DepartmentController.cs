using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    class DepartmentController
    {
        ApplicationContext dbConnect;
        public object department;
        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public DepartmentController()
        {
            dbConnect = new ApplicationContext();
            try
            {
                department = dbConnect.DepartmentInformationNames.Join
                    (
                     dbConnect.Departments,
                     u => u.DepartmentId,
                     c => c.DepartmentId,
                     (u, c) => new
                     {
                         u.Name,
                         c.DepartmentId,
                         c.Address,
                         u.DateOfOrder
                     }
                    ).Join(dbConnect.DepartmentInformationUsers,
                     u => u.DepartmentId,
                     c => c.DepartmentId,
                     (u, c) => new
                     {
                         u.Address,
                         u.DepartmentId,
                         u.Name,
                         c.DepartmentInformationUserId,
                         DateOfOrderName = u.DateOfOrder,
                         DateOfOrderUser = c.DateOfOrder
                     }
                    ).ToList();
            }
            catch
            {
                throw new Exception("Error  connect BD");
            }
        }
    }
}