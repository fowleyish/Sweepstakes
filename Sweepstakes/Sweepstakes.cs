using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        // Vars
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        // Ctor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        // Methods

        public void RegisterContestant()
        {
            Contestant newContestant = UI.Registration();
            try
            {
                contestants.Add(newContestant.regNumber, newContestant);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{newContestant.regNumber} already exists. Please try again.");
            }
        }

        public Contestant PickWinner()
        {
            // Loop through dictionary?
            // Select someone?
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            // Assuming I need to go through the dictionary?
        }
    }
}
