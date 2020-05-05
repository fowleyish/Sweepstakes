using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        // Vars
        private Queue<Sweepstakes> queue;
        // Ctor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        // Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
