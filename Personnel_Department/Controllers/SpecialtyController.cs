using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Personnel_Department.Controllers
{
    public class SpecialtyController
    {
        public List<Specialty> Specialties { get; init; }
        public Specialty NewSpecialty { get; }

        public SpecialtyController()
        {
            using ApplicationContext applicationContext = new();

            Specialties = applicationContext.Specialties.Include(x => x.Directions).ToList();
        }

        public SpecialtyController(Specialty specialty)
        {
            NewSpecialty = specialty;
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


        public void Add ()
        {
            if (NewSpecialty==null)
            {
                throw new Exception("Пустой объект");
            }
            if (string.IsNullOrWhiteSpace( NewSpecialty.Name))
            {
                throw new ArgumentNullException("Название не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(NewSpecialty.CodeSpecialty))
            {
                throw new ArgumentNullException("Код специальности не может быть пустым");
            }

            try
            {
                using ApplicationContext applicationContext = new();

                if(applicationContext.Specialties.Any(x=>x.Name==NewSpecialty.Name && x.CodeSpecialty==NewSpecialty.CodeSpecialty))
                {
                    throw new Exception("Такая специальность уже есть");
                }
                applicationContext.Specialties.Add(NewSpecialty);
                applicationContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("ошибка БД " + ex.Message);
            }
        }

        public void Update()
        {
            if (NewSpecialty == null)
            {
                throw new Exception("Пустой объект");
            }
            if (string.IsNullOrWhiteSpace(NewSpecialty.Name))
            {
                throw new ArgumentNullException("Название не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(NewSpecialty.CodeSpecialty))
            {
                throw new ArgumentNullException("Код специальности не может быть пустым");
            }

            try
            {
                using ApplicationContext applicationContext = new();
                applicationContext.Specialties.Update(NewSpecialty);
                applicationContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ошибка БД " + ex.Message);
            }
        }

        public void Dell()
        {
            try
            {
                using ApplicationContext applicationContext = new();
                applicationContext.Specialties.Remove(NewSpecialty);
                applicationContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ошибка БД " + ex.Message);
            }
        }
    }
}
