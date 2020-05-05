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
            set
            {
                name = value;
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
            List<int> contestantNumbers = new List<int>();
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                contestantNumbers.Add(contestant.Key);
            }
            Random r = new Random();
            int winnerIndex = r.Next(0, contestantNumbers.Count-1);
            int winnerKey = contestantNumbers[winnerIndex];
            return contestants[winnerKey];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.regNumber}: {contestant.fname} {contestant.lname}, {contestant.email}");
        }
    }
}
