using Personnel_Department.BL.ModelDataBase;

using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Personnel_Department.Controllers
{
    class FormOfEducationController
    {
        public List<FormOfEducation> FormOfEducations { get; init; }
        public FormOfEducationController()
        {
            using ApplicationContext applicationContext = new();
            FormOfEducations = applicationContext.FormOfEducations.AsNoTracking().ToList();
        }
    }
}
