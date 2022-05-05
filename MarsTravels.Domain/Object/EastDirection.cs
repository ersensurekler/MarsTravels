using MarsTravels.Core.Interface;

namespace MarsTravels.Core.Object
{
    public class EastDirection : DirectionBase, IDirection
    {
        public IDirection Left()
        {
            return new NorthDirection();
        }
        public IDirection Right()
        {
            return new SouthDirection();
        }
        public IPeople Move(IPeople people, ISurface surface)
        {
            people.X++;
            base.SurfaceLimitControl(people, surface);

            return people;
        }
    }
}
