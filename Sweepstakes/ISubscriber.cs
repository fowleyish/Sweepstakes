using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Sweepstakes
{
    public interface ISubscriber
    {
        string fname { get; set; }
        string lname { get; set; }
        string email { get; set; }
        int regNumber { get; set; }
        int regNumbers { get; }
        void Notify(ISubscriber loser, ISubscriber winner);
    }
}
