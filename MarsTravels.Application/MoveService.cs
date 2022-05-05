using MarsTravels.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsTravels.Application
{
    public class MoveService
    {
        public IPeople Movement(IPeople people, ISurface surface, string commandStrings)
        {
            Command command = new Command();

            char[] characters = commandStrings.ToCharArray();
            if (characters.Length == 0)
            {
                throw new ApplicationException("Invalid command input.");
            }

            for (int i = 0; i < characters.Length; i++)
            {
                var chr = characters[i];
                if (Helper.StringEq(chr.ToString(), "R"))
                {
                    people = command.Right(people);
                }
                else if (Helper.StringEq(chr.ToString(), "L"))
                {
                    people = command.Left(people);
                }
                else if (Helper.StringEq(chr.ToString(), "M"))
                {
                    people = command.Move(people, surface);
                }
                else
                {
                    throw new ApplicationException("Invalid command input.");
                }
            }

            return people;
        }
    }
}
