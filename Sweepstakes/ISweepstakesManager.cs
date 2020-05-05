using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    interface ISweepstakesManager // Inherited by 2 classes that handle Sweepstakes methods using different data structs
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}
