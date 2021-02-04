using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// студенты в академическом отпуске 
    /// </summary>
    public class StudentOfAcademic
    {
        public int StudentOfAcademicId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        /// <summary>
        /// Группа из которой ушел  в академ 
        /// </summary>
        public int GrupId { get; set; }
        public virtual Grup Grups { get; set; }
       

        /// <summary>
        /// Дата   выхода  в  академ отпуст
        /// </summary>
        public DateTime DateOnAccademic { get; set; }

        /// <summary>
        /// дата  выхода  из академ отпуска 
        /// </summary>
        public DateTime DateOffAccademic { get; set; }


        /// <summary>
        /// Приказ  на академ отпуск 
        /// /// </summary>
        public string OrederOn { get; set; }

        /// <summary>
        /// приказ  Выхода из  академ отпуска 
        /// </summary>
        public string OrederOff { get; set; }

        public string Coment { get; set; }
    }
}
