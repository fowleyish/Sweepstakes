﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    static class UI
    {

        // Methods - only one, used to gather user input for Contestant properties
        public static Contestant Registration()
        {
            Console.Write("First name: ");
            string fname = Console.ReadLine();
            Console.Write("Last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Email address: ");
            string email = Console.ReadLine();

            Contestant registrant = new Contestant(fname, lname, email);
            return registrant;
        }
    }
}
