using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    static class UI
    {
        // Vars

        // Ctor

        // Methods
        public static Contestant Registration()
        {
            Console.Write("First name: ");
            string fname = Console.ReadLine();
            Console.Write("Last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Email address: ");
            string email = Console.ReadLine();
            Console.Write("Select a registration number: ");
            int regNum = int.Parse(Console.ReadLine());

            Contestant registrant = new Contestant(fname, lname, email, regNum);
            return registrant;
        }
    }
}
