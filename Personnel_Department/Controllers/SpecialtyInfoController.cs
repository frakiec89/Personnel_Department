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
            SpecialtyInformation = applicationContext.SpecialtyInformation.AsNoTracking().ToList();
        }
        public static string EditOrCreateUser(SpecialtyInformation newSpecialtyInformation)
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
    }
}
