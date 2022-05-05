using System;
using System.Collections.Generic;
using System.Text;

namespace MarsTravels.Entity.Interface
{
    public interface IPeople
    {
        int X { get; set; }
        int Y { get; set; }
        string Name { get; set; }
        string Direction { get; set; }
    }
}
