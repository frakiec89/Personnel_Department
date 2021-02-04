using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Студенты иностранные 
    /// </summary>
    public class StudentOfExternal
    {
        public int StudentOfExternalId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Students { get; set; }

        public  DateTime Date { get; set; }

        /// <summary>
        /// Если человек  получил  гражданство РФ
        /// </summary>
        public DateTime DateOf { get; set; }


        public string Country { get; set;  }

        public string Docyment { get; set; }

        public  string Coment { get; set; }

    }
}
