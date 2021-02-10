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
                var content = from d in dbConnect.Departments
                              from dn in dbConnect.DepartmentInformationNames
                              from du in dbConnect.DepartmentInformationUsers
                              select new
                              {
                                  d.Address, d.DepartmentId, dn.Name, du.DepartmentInformationUserId,
                                  DateOfOrderDn =   dn.DateOfOrder ,
                                  DateOfOrderDu = du.DateOfOrder
                              };



            }
            catch
            {
                throw new Exception("Error  connect BD");
            }
        }
    }
}


/*      var d = dbConnect.
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
                    );*/