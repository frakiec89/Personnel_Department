using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace Personnel_Department.Controllers
{
    class DepartmentController
    {
        ApplicationContext dbConnect;
        public List<DepartmentInfo> Departments = new List<DepartmentInfo>();
        public List<DepartmentInformationName> LastDepartments = new List<DepartmentInformationName>();
        public List<DepartmentInformationUser> LastDepartmentInformationUsers = new List<DepartmentInformationUser>();

        public string ComentName { get; private set; }
        public DateTime DataName { get; private set; }
        public string ComentUser { get; private set; }

        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public DepartmentController()
        {
            dbConnect = new ApplicationContext();
            //LastDepartments = GetLastName();
            //LastDepartmentInformationUsers = GetLastUser();
            Departments = GetDepartment();
        }

        /// <summary>
        /// Получает  список  последних изменений  имени отделения
        /// </summary>
        /// <returns></returns>
        private List<DepartmentInformationName> GetLastName()
        {
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
                                         Name= d.Name,
                                         DepartmentInformationNameId = d.DepartmentInformationNameId,
                                         DateOfOrder = d.DateOfOrder
                                     };

            return lastDepartmentName.ToList();
        }

        /// <summary>
        /// получат список  последний зав отделений
        /// </summary>
        /// <returns></returns>
        private List<DepartmentInformationUser> GetLastUser()
        {
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
                                         select new DepartmentInformationUser()
                                         {
                                             DepartmentId = d.DepartmentId,
                                             Coment = d.Coment,
                                             UserId = d.UserId,
                                             DepartmentInformationUserId = d.DepartmentInformationUserId,
                                             DateOfOrder = d.DateOfOrder
                                         };
                return LastDepartmentName.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error DB " + ex.Message);
            }
        }

        private List<DepartmentInfo> GetDepartment()
        {
            var deparmentInfo = from tableU in GetLastUser()
                                join d in GetLastName()
                                on tableU.DepartmentId equals d.DepartmentId
                                select new DepartmentInfo(
                                    tableU,
                                    d
                                );
            return deparmentInfo.ToList();
        }
    }

    internal class DepartmentInfo
    {
        public DepartmentInformationUser TableU { get; }
        public DepartmentInformationName D { get; }

        public DepartmentInfo(DepartmentInformationUser tableU, DepartmentInformationName d)
        {
            TableU = tableU;
            D = d;
        }
    }
}

                            