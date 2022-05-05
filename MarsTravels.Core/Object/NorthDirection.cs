using MarsTravels.Core.Interface;

namespace MarsTravels.Core.Object
{
    public class NorthDirection : DirectionBase, IDirection
    {
        public IDirection Left()
        {
            return new WestDirection();
        }
        public IDirection Right()
        {
            return new EastDirection();
        }
        public IPeople Move(IPeople people, ISurface surface)
        {
            people.Y++;
            base.SurfaceLimitControl(people, surface);

            return people;
        }
    }
}
