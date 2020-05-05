using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Contestant : ISubscriber
    {
        // Vars
        public string fname;
        public string lname;
        public string email;
        public int regNumber;
        static private int regNumbers = 0; // needs to be static? test
        int ISubscriber.regNumber { get => regNumber; set => regNumber = value; }
        int ISubscriber.regNumbers { get => regNumbers; }

        // Ctor
        public Contestant(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            regNumber = AssignRegNumber();
        }

        // Methods
        public int AssignRegNumber()
        {
            regNumbers++;
            return regNumbers;
        }

        public void Notify(ISubscriber loser, ISubscriber winner)
        {
            if (loser != winner)
            {
                Console.WriteLine("Sorry, you did not win.");
            }
            else
            {
                Console.WriteLine("Congratulations! You won!");
            }
        }
    }
}
