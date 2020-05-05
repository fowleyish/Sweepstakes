using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Contestant
    {
        // Vars
        public string fname;
        public string lname;
        public string email;
        public int regNumber;
        private int regNumbers = 0;

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
    }
}
