using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        // Vars
        private Stack<Sweepstakes> stack;

        // Ctor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        // Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
