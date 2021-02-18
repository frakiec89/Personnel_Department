namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Отделения  колледжа - как  правило   распределяется по  корпусам -
    /// например  1 корпус - 
    /// </summary>
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Address { get; set; }
    }
}