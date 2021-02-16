using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Personnel_Department.Controllers
{
    class FormOfEducationController
    {
        public List<FormOfEducation> FormOfEducations { get; set; }
        public FormOfEducationController()
        {
            using ApplicationContext applicationContext = new();
            FormOfEducations = applicationContext.FormOfEducations.AsNoTracking().ToList();
        }
    }
}
