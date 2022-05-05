namespace MarsTravels.Core.Interface
{
    public interface IPeople
    {
        int X { get; set; }
        int Y { get; set; }
        string Name { get; set; }
        IDirection Direction { get; set; }
    }
}
