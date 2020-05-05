using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        // Vars
        private Stack<Sweepstakes> stack; // Stack built using LIFO

        // Ctor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>(); // inst new Stack object
        }

        // Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes); // Push to "push" a SS to the end of the stack
        }
        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop(); // Pop to "pop" the last SS off the end of the stack and return it
        }
    }
}
