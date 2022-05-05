using MarsTravels.Application;
using MarsTravels.Core.Object;
using System;

namespace MarsTravels
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsSurface marsSurface = new MarsSurface();
            WorldPeople people = new WorldPeople();
            MoveService moveService = new MoveService();
            DirectionFactory directionFactory = new DirectionFactory();

            Console.WriteLine("Welcome to Mars!");

            Console.WriteLine("Please enter the surface information (x y) => example = 5 5");
            string inputSurface = Console.ReadLine();
            string[] splitSurface = inputSurface.Split(' ');
            marsSurface.X = int.Parse(splitSurface[0]);
            marsSurface.Y = int.Parse(splitSurface[1]);

        again:

            Console.WriteLine("Please enter the people information (name x y direction(N, E, W, S)) => example = Ersen 1 3 E");
            string inputPeople = Console.ReadLine();
            string[] splitPeople = inputPeople.Split(' ');
            people.Name = splitPeople[0];
            people.X = int.Parse(splitPeople[1]);
            people.Y = int.Parse(splitPeople[2]);
            people.Direction = directionFactory.CreateDirectionClass(splitPeople[3]);

            Console.WriteLine("Please enter the command strings => example = MMRMMLMRM");
            string inputCommand = Console.ReadLine();
            people = (WorldPeople)moveService.Movement(people, marsSurface, inputCommand);
            
            Console.WriteLine($"\x1b[1m{people.Name} location => {people.X} {people.Y} {directionFactory.GetDirectionString(people.Direction)}\x1b[0m");

            Console.WriteLine("Do you want to continue? (Y/N)");
            string answerYesNo = Console.ReadLine();
            if (Helper.StringEq(answerYesNo, "Y"))
                goto again;

        }
    }
}
