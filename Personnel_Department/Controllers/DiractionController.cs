using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Personnel_Department.Controllers
{
    public class DiractionController
    {
        public List<Direction> Directions { get; set; }
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
    }
}
