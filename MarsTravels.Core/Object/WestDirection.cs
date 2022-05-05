using MarsTravels.Core.Interface;

namespace MarsTravels.Core.Object
{
    public class WestDirection : DirectionBase, IDirection
    {
        public IDirection Left()
        {
            return new SouthDirection();
        }
        public IDirection Right()
        {
            return new NorthDirection();
        }
        public IPeople Move(IPeople people, ISurface surface)
        {
            people.X--;
            base.SurfaceLimitControl(people, surface);

            return people;
        }
    }
}
