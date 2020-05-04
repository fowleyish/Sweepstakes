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

        // Ctor
        public Contestant(string fname, string lname, string email, int regNum)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            regNumber = regNum;
        }

        // Methods
    }
}
