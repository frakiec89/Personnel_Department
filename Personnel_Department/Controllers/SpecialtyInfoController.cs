using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Personnel_Department.Controllers
{
    class SpecialtyInfoController
    {
        /// <summary>
        /// Лист с SpecialtyInformation
        /// </summary>
        public List<SpecialtyInformation> SpecialtyInformation { get; init; }
        public SpecialtyInfoController()
        {
            using ApplicationContext applicationContext = new();
            SpecialtyInformation = applicationContext.SpecialtyInformation
                .Include(x => x.FormOfEducations).Include(x => x.Specialtys).AsNoTracking().ToList();
        }

        public static string CreateOrUpdateSpecialtyInformation(SpecialtyInformation uSpecialtyInformation)
        {
            using ApplicationContext applicationContext = new();
            
            try
            {
                applicationContext.SpecialtyInformation.Update(uSpecialtyInformation);
                applicationContext.SaveChanges();
                return "Операция прошла успешно";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
