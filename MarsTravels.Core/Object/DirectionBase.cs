using MarsTravels.Core.Interface;
using System;

namespace MarsTravels.Core.Object
{
    public abstract class DirectionBase
    {
        public virtual void SurfaceLimitControl(IPeople people, ISurface surface)
        {
            if (people.Y < 0 || people.Y > surface.Y || people.X < 0 || people.X > surface.X)
            {
                throw new Exception("Belirlenen yüzeyin dışına çıkıldı.");
            }
        }
    }
}
