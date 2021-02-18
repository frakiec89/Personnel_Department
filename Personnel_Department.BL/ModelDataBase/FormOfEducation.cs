namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Форма обучения, например  заочная
    /// </summary>
    public class FormOfEducation
    {
        public int FormOfEducationId { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;

    }
}