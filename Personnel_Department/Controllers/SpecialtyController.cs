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
        public SpecialtyController()
        {
            using ApplicationContext applicationContext = new();
            Specialties = applicationContext.Specialties.AsNoTracking().ToList();
        }
    }
}
