namespace Personnel_Department.BL.ModelDataBase
{
    [System.ComponentModel.DataAnnotations.Schema.Table("StudenOfOrphant")]
    /// <summary>
    /// Студенты сироты
    /// </summary>
    public class StudenOfOrphant: Student
    {
        public int StudenOfOrphantId { get; set; }
        public System.DateTime Date { get; set; }
        public string Coment { get; set; }
    }
}
