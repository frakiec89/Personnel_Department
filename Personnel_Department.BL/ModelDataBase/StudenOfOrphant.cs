using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Студенты сироты
    /// </summary>
    public class StudenOfOrphant
    {

        public int StudenOfOrphantId { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public DateTime Date { get; set; }
        public string Coment { get; set; }
    }
}
