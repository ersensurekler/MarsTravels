using MarsTravels.Core.Interface;

namespace MarsTravels.Application
{
    internal class Command
    {
        internal IPeople Right(IPeople people)
        {
            people.Direction = people.Direction.Right();
            return people;
        }

        internal IPeople Left(IPeople people)
        {
            people.Direction = people.Direction.Left();
            return people;
        }

        internal IPeople Move(IPeople people, ISurface surface)
        {
            people = people.Direction.Move(people, surface);
            return people;
        }
    }
}
