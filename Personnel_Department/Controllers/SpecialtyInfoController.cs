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
        /// <summary>
        /// Удаление по всему объекту
        /// </summary>
        /// <param name="specialtyInformation">наш объект</param>
        /// <returns></returns>
        public static string Delete(SpecialtyInformation specialtyInformation)
        {
            if (specialtyInformation is null)
                return "Ошибка, пустота";
            try
            {
                using ApplicationContext context = new();
                context.SpecialtyInformation.Remove(specialtyInformation);
                context.SaveChanges();
                return "Удаление прошло успешно";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Удаление по Id
        /// </summary>
        /// <param name="idSpecialtyInformation">Id объекта</param>
        /// <returns></returns>
        public static string Delete(int idSpecialtyInformation)
        {
            try
            {
                using ApplicationContext context = new();
                context.SpecialtyInformation.Remove(context.SpecialtyInformation.Single(x => x.SpecialtyinformationId == idSpecialtyInformation));
                context.SaveChanges();
                return "Удаление прошло успешно";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
