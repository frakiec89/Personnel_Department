using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Personnel_Department.Controllers
{
    class SpecialtyInfoController
    {
        public List<SpecialtyInformation> SpecialtyInformation { get; set; }
        public SpecialtyInfoController()
        {
            ApplicationContext applicationContext = new();
            SpecialtyInformation = applicationContext.SpecialtyInformation
                .Include(x => x.FormOfEducations).
                 Include(x => x.Specialtys).AsNoTracking().
                ToList();

        }
        public static string CreateSpecialtyInfo(SpecialtyInformation newSpecialtyInformation)
        {
            //if(newSpecialtyInformation is null)
            //    throw new ArgumentException("Пустой");
            try
            {
                using ApplicationContext applicationContext = new();
                if (applicationContext.SpecialtyInformation.Where(x => x.NameProfile.ToLower() == newSpecialtyInformation.NameProfile.ToLower().TrimStart().TrimEnd()).Any())
                    throw new ArgumentException("Такой объект уже есть");

                applicationContext.SpecialtyInformation.Add(newSpecialtyInformation);
                applicationContext.SaveChanges();
                return "Сохранение прошло успешно";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public static string UpdateSpecialtyInfo(SpecialtyInformation uSpecialtyInformation)
        {
            try
            {
                using ApplicationContext applicationContext = new();
                applicationContext.SpecialtyInformation.Update(uSpecialtyInformation);
                applicationContext.SaveChanges();
                return "Редактирование прошло успешно";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
