using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    class DepartmentController
    {
        public List<DepartmentInfo> Departments = new List<DepartmentInfo>();

        public string ComentName { get; private set; }
        public DateTime DataName { get; private set; }
        public string ComentUser { get; private set; }

        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public DepartmentController()
        {
            using ApplicationContext dbConnect = new ApplicationContext();
            Departments = GetDepartment();
        }

        /// <summary>
        /// Получает  список  последних изменений  имени отделения
        /// </summary>
        /// <returns></returns>
        private List<DepartmentInformationName> GetLastName()
        {
            using ApplicationContext dbConnect = new ApplicationContext();
            var lastDepartmentName = from dep in dbConnect.Departments
                                     join d in dbConnect.DepartmentInformationNames
                                     on dep.DepartmentId equals d.DepartmentId
                                     group d by d.DepartmentId into grg
                                     select new
                                     {
                                         DateTime = grg.Max(max => max.DateOfOrder)
                                     } into g
                                     let m = g.DateTime
                                     from d in dbConnect.DepartmentInformationNames
                                     where d.DateOfOrder == m
                                     select new DepartmentInformationName()
                                     {
                                         DepartmentId = d.DepartmentId,
                                         Coment = d.Coment,
                                         Name = d.Name,
                                         DepartmentInformationNameId = d.DepartmentInformationNameId,
                                         DateOfOrder = d.DateOfOrder,
                                         Departments = d.Departments
                                     };

            return lastDepartmentName.ToList();
        }

        /// <summary>
        /// получат список  последний зав отделений
        /// </summary>
        /// <returns></returns>
        private List<DepartmentInformationUsers> GetLastUser()
        {
            using ApplicationContext dbConnect = new ApplicationContext();
            try
            {
                var LastDepartmentName = from dep in dbConnect.Departments
                                         join d in dbConnect.DepartmentInformationUsers
                                         on dep.DepartmentId equals d.DepartmentId
                                         group d by d.DepartmentId into grg
                                         select new
                                         {
                                             DateTime = grg.Max(max => max.DateOfOrder)
                                         } into g
                                         let m = g.DateTime
                                         from d in dbConnect.DepartmentInformationUsers
                                         where d.DateOfOrder == m
                                         select new DepartmentInformationUsers()
                                         {
                                             Departments = d.Departments,
                                             DepartmentId = d.DepartmentId,
                                             Coment = d.Coment,
                                             UserId = d.UserId,
                                             DepartmentInformationUserId = d.DepartmentInformationUserId,
                                             DateOfOrder = d.DateOfOrder,
                                             Users = d.Users
                                         };
                return LastDepartmentName.ToList();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        private List<DepartmentInfo> GetDepartment()
        {
            var deparmentInfo = from tableU in GetLastUser()
                                join d in GetLastName()
                                on tableU.DepartmentId equals d.DepartmentId
                                select new DepartmentInfo(
                                    d,
                                    tableU
                                );
            return deparmentInfo.ToList();
        }
    }

    internal class DepartmentInfo
    {
        public DepartmentInformationName DepartmentInformationName { get; }
        public DepartmentInformationUsers DepartmentInformationUsers { get; }

        public DepartmentInfo(DepartmentInformationName departmentInformationName, DepartmentInformationUsers departmentInformationUsers)
        {
            DepartmentInformationName = departmentInformationName;
            DepartmentInformationUsers = departmentInformationUsers;
        }

        public override bool Equals(object obj)
        {
            return obj is DepartmentInfo other &&
                   EqualityComparer<DepartmentInformationName>.Default.Equals(DepartmentInformationName, other.DepartmentInformationName) &&
                   EqualityComparer<DepartmentInformationUsers>.Default.Equals(DepartmentInformationUsers, other.DepartmentInformationUsers);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DepartmentInformationName, DepartmentInformationUsers);
        }
    }
}