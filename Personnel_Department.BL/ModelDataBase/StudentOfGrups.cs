using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// перемещение студентов 
    /// </summary>
    public class StudentOfGrups
    {
        public int StudentOfGrupsId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get;set;}

        public int GrupId { get; set; }
        public virtual Grup Grups { get; set; }


        /// <summary>
        /// Дата  зачисления 
        /// </summary>
        public  DateTime DateRegistration { get; set; }

        /// <summary>
        /// дата  отчисления 
        /// </summary>
        public DateTime DateOffRegistration { get; set; }


        /// <summary>
        /// Приказ  зачисления 
        /// </summary>
        public string OrederOn { get; set; }

        /// <summary>
        /// приказ  отчисления
        /// </summary>
        public string OrederOff { get; set; }

        public  string Coment { get; set; }

    }
}
