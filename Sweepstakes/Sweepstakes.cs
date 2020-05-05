using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        // Vars
        Dictionary<int, ISubscriber> contestants;
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
            contestants = new Dictionary<int, ISubscriber>();
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
                Console.WriteLine($"{newContestant.regNumber}: this registration number is already in use. Please try again.");
            }
        }

        public ISubscriber PickWinner()
        {
            List<int> contestantNumbers = new List<int>();
            foreach(KeyValuePair<int, ISubscriber> contestant in contestants)
            {
                contestantNumbers.Add(contestant.Key);
            }
            Random r = new Random();
            int winnerIndex = r.Next(0, contestantNumbers.Count-1);
            int winnerKey = contestantNumbers[winnerIndex];
            NotifySubscribers(contestants[winnerKey]);
            return contestants[winnerKey];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.regNumber}: {contestant.fname} {contestant.lname}, {contestant.email}");
        }

        public void NotifySubscribers(ISubscriber winner)
        {
            foreach(KeyValuePair<int, ISubscriber> loser in contestants)
            {
                loser.Value.Notify(loser.Value, winner);
            }
        }
    }
}
