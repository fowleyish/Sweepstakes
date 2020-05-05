using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        // Vars
        private Queue<Sweepstakes> queue; // Create new queue using FIFO
        // Ctor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>(); // inst new Queue object populated with Sweepstakes()
        }

        // Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes); // Enqueue to add new sweepstakes to queue
        }

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue(); // Dequeue to return sweepstakes from beginning of queue
        }
    }
}
