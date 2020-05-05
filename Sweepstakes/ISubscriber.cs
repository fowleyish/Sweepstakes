using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Sweepstakes
{
    public interface ISubscriber
    {
        // This is the only way I could figure out how to get each of these properties available on the Contestant class without referring
        // to the Contestant class directly. I wanted to keep it generalized to the ISubscriber interface in the logic of my program to 
        // adhere to SOLID principles; however, building an interface of this complexity could also negate my efforts. Please let me know
        // if you have any advice on how I could more cleanly handle this next time :)
        string fname { get; set; }
        string lname { get; set; }
        string email { get; set; }
        int regNumber { get; set; }
        int regNumbers { get; }
        void Notify(ISubscriber loser, ISubscriber winner);
    }
}
