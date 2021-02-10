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
        public List<DepartmentInformationName> LastDepartments = new List<DepartmentInformationName>();
        public List<DepartmentInformationUser> LastDepartmentInformationUsers = new List<DepartmentInformationUser>();

        /// <summary>
        /// показывать  удаленных / да нет 
        /// </summary>
        /// <param name="visableDelete"></param>
        public DepartmentController()
        {
            dbConnect = new ApplicationContext();
            LastDepartments = GetLastName();
            LastDepartmentInformationUsers = GetLastUser();
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
            catch
            {
                throw new Exception("Error DB");
            }
        }


       

    }

    internal class DepatmentInfo
    {
        public int DepartmentId { get; }
        public int DepartmentInformationNameId { get; }
        public string Name { get; }
        public string Coment { get; }
        public DateTime DateOfOrder { get; }
        public string Coment1 { get; }
        public DateTime DateOfOrder1 { get; }
        public int UserId { get; }

        public DepatmentInfo(int departmentId, int departmentInformationNameId, string name, string coment, DateTime dateOfOrder, string coment1, DateTime dateOfOrder1, int userId)
        {
            DepartmentId = departmentId;
            DepartmentInformationNameId = departmentInformationNameId;
            Name = name;
            Coment = coment;
            DateOfOrder = dateOfOrder;
            Coment1 = coment1;
            DateOfOrder1 = dateOfOrder1;
            UserId = userId;
        }

        public override bool Equals(object obj)
        {
            return obj is DepatmentInfo other &&
                   DepartmentId == other.DepartmentId &&
                   DepartmentInformationNameId == other.DepartmentInformationNameId &&
                   Name == other.Name &&
                   Coment == other.Coment &&
                   DateOfOrder == other.DateOfOrder &&
                   Coment1 == other.Coment1 &&
                   DateOfOrder1 == other.DateOfOrder1 &&
                   UserId == other.UserId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DepartmentId, DepartmentInformationNameId, Name, Coment, DateOfOrder, Coment1, DateOfOrder1, UserId);
        }
    }
}

                            