using Personnel_Department.BL.ModelDataBase;
using Microsoft.EntityFrameworkCore.SqlServer.Update;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    public class DiractionController
    {
        /// <summary>
        /// Список направлений
        /// </summary>
        public List<Direction> Directions { get; set; }
        /// <summary>
        /// Новое направление 
        /// </summary>
        private Direction NewDirection { get; set; }
       
        public DiractionController()
        {
            try
            {
                using ApplicationContext dbConnect = new ApplicationContext();
                Directions = dbConnect.Directions.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// отредактировать объект
        /// </summary>
        /// <param name="direction"></param>
        public  DiractionController (Direction direction)
        {
            if( String.IsNullOrWhiteSpace( direction.Name))
            {
                throw new ArgumentNullException("Название направления не может  быть пустым");
            }
            NewDirection = direction;
        }

        /// <summary>
        /// Создать новое  направление 
        /// </summary>
        /// <param name="name"></param>
        public DiractionController(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название направления не может  быть пустым");
            }
            NewDirection = new Direction { Name = name.TrimStart().TrimEnd() };
        }

        /// <summary>
    /// добавить  новое  направление 
    /// </summary>
        public void AddDiraction()
         {
            if (NewDirection!=null )
            {
              using ApplicationContext dbConnect = new ApplicationContext();
                  if (dbConnect.Directions.
                        Where(x => x.Name.ToUpper() == NewDirection.Name.ToUpper().TrimStart().TrimEnd()).Any())
                  {
                        throw new ArgumentException("Такой объект уже есть");
                  }
                dbConnect.Directions.Add(NewDirection);
                dbConnect.SaveChanges();
            }
        }

        public void UpdateDiraction()
        {
            if (NewDirection != null)
            {
                using ApplicationContext dbConnect = new ApplicationContext();
                dbConnect.Directions.Update(NewDirection);
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Удаление направления
        /// </summary>
        /// <param name="id">код направления</param>
        public static void DellDiraction ( int  id)
        {
            try
            {
                using ApplicationContext dbConnect = new ApplicationContext();
                dbConnect.Directions.Remove(dbConnect.Directions.Find(id));
                dbConnect.SaveChanges();
            }
            catch ( Exception ex)
            {
                throw new Exception("Ошибка удаления " + ex.Message);
            }
        }
    }
}
