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
        public System.DateTime Date { get; set; }
        public string Coment { get; set; }
    }
}
