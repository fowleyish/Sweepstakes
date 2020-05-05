using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    interface ISubscriber
    {
        int regNumber { get; set; }
        int regNumbers { get; }
        void Notify(ISubscriber loser, ISubscriber winner);
    }
}
