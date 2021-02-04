﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// класс для переназначения  зав Отделением 
    /// </summary>
    public   class DepartmentInformationUser
    {
        public int DepartmentInformationUserId { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; }

        public DateTime DateOfOrder { get; set; }

        public int UserId { get; set; }
        /// <summary>
        /// Зав отделением 
        /// </summary>
        public virtual User Users { get; set; }


        /// комментарии  по  поводу назначения
        public string Coment { get; set; }

    }

    
}
