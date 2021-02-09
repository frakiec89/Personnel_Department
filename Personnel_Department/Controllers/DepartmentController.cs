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
                var d = dbConnect.
                     DepartmentInformationNames.Join
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
                    );
            }
            catch
            {
                throw new Exception("Error  connect BD");
            }
        }
    }
}