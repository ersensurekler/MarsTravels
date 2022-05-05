using MarsTravels.Core.Interface;

namespace MarsTravels.Core.Object
{
    public class SouthDirection : DirectionBase, IDirection
    {
        public IDirection Left()
        {
            return new EastDirection();
        }
        public IDirection Right()
        {
            return new WestDirection();
        }
        public IPeople Move(IPeople people, ISurface surface)
        {
            people.Y--;
            base.SurfaceLimitControl(people, surface);

            return people;
        }
    }
}
