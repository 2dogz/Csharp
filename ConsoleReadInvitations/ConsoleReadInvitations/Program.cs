using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadInvitations
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFile = new TextFile("Invitations.txt");
            var linesRead = textFile.LinesRead;

            foreach (string line in linesRead) 
            {
                //format salutation as:
                //
                //  Dear Ms. Hillary Clinton:
                //      ~or~
                //  Dear Mr. Ted Cruz:
                string[] lineElements = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string salutation = lineElements[2] == "M" ? "Dear Mr. " : "Dear Ms. ";
                string firstName = lineElements[1];
                string lastName = lineElements[0];
                Console.WriteLine(salutation + firstName + " " + lastName.Substring(0, lastName.Length - 1) + ":");


                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}



