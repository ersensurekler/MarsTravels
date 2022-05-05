using MarsTravels.Core.Interface;
using MarsTravels.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsTravels.Application
{
    public class DirectionFactory
    {
        public IDirection CreateDirectionClass(string directionString)
        {
            if (Helper.StringEq(directionString, "N"))
            {
                return new NorthDirection();
            }
            else if (Helper.StringEq(directionString, "E"))
            {
                return new EastDirection();
            }
            else if (Helper.StringEq(directionString, "W"))
            {
                return new WestDirection();
            }
            else if (Helper.StringEq(directionString, "S"))
            {
                return new SouthDirection();
            }
            else
            {
                throw new ApplicationException("Invalid direction input.");
            }
        }
        public string GetDirectionString(IDirection direction)
        {
            if (direction is NorthDirection)
            {
                return "N";
            }
            else if (direction is EastDirection)
            {
                return "E";
            }
            else if (direction is WestDirection)
            {
                return "W";
            }
            else if (direction is SouthDirection)
            {
                return "S";
            }
            else
            {
                throw new ApplicationException("Invalid direction.");
            }
        }
    }
}
