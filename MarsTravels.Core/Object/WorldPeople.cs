using MarsTravels.Core.Interface;

namespace MarsTravels.Core.Object
{
    public class WorldPeople : IPeople
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public IDirection Direction { get; set; }
    }
}
