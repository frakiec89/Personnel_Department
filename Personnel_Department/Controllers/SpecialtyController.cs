using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Personnel_Department.Controllers
{
    public class SpecialtyController
    {
        public List<Specialty> Specialties { get; set; }
        public Specialty newSpecialty { get; }

        public SpecialtyController()
        {
            using ApplicationContext applicationContext = new();

            Specialties = applicationContext.Specialties.Include(x => x.Directions).ToList();
        }

        public SpecialtyController(Specialty specialty)
        {
            newSpecialty = specialty;
        }

        public static List<string> GetNameSpecialty()
        {
            List<string> Names = new();
            try
            {
                using ApplicationContext applicationContext = new();
                foreach (var item in applicationContext.Specialties)
                    Names.Add(item.Name);
            }
            catch
            {
                throw new Exception().InnerException;
            }
            return Names;
        }


        public void AddOrUpdate ()
        {
            if (newSpecialty==null)
            {
                throw new Exception("Пустой объект");
            }
            if (string.IsNullOrWhiteSpace( newSpecialty.Name))
            {
                throw new ArgumentNullException("Название не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(newSpecialty.CodeSpecialty))
            {
                throw new ArgumentNullException("Код специальности не может быть пустым");
            }

            try
            {
                using ApplicationContext applicationContext = new();

                // todo добавить  проверку  на  повторение 
                applicationContext.Specialties.Update(newSpecialty);
                applicationContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("ошибка БД " + ex.Message);
            }

        }
    }
}
