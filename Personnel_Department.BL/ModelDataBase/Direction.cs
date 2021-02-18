namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// направления, например  гуманитарное   и  тд
    /// </summary>
    public class Direction
    {
        public int DirectionId { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}