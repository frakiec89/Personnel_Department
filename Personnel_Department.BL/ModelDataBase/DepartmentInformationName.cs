using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// информация  отделения - На случай  переименования 
    /// </summary>
    public  class DepartmentInformationName
    {
       public int DepartmentInformationNameId { get; set; }
       
       public int DepartmentId { get; set; }
       public virtual Department Departments { get; set; }

       
       public DateTime DateOfOrder { get; set; }
       public  string Name { get; set; }

       /// <summary>
        ///  ///комментарии  по  поводу  переименования
        /// </summary>
       public string Coment { get; set; }

    }
}
