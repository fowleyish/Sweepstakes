using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        // Vars
        Dictionary<int, ISubscriber> contestants; // Collection of contestents; int Key is their registration number
        private string name; // field name of sweepstake
        public string Name // R/W property for name
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
            this.name = name; // Name is specified through the constructor; this could be an example of Constructor DI (maybe?)
            contestants = new Dictionary<int, ISubscriber>(); // Inst new Dictionary of ISubscribers
        }

        // Methods

        // Leverages UI.Registration to create a new Contestant() to add to dict
        public void RegisterContestant()
        {
            Contestant newContestant = UI.Registration();
            try // Exception handling incase my automated Key assignment method in Contestant class doesn't work for some reason
            {
                contestants.Add(newContestant.regNumber, newContestant);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{newContestant.regNumber}: this registration number is already in use. Please try again.");
            }
        }

        // Uses a local List and Random() to select an entry in the dict
        public ISubscriber PickWinner()
        {
            List<int> contestantNumbers = new List<int>(); // Inst new list...
            foreach(KeyValuePair<int, ISubscriber> contestant in contestants) // ...loop through dict...
            {
                contestantNumbers.Add(contestant.Key); // ...add each key to local list...
            }
            Random r = new Random(); // ...inst Random object...
            int winnerIndex = r.Next(0, contestantNumbers.Count-1); // ...get random number between 0 and the length of the local list...
            int winnerKey = contestantNumbers[winnerIndex]; // ...get the dict key associated to the index position acquired via r...
            NotifySubscribers(contestants[winnerKey]); // ...NotifySubscribers() method as part of extra credit...
            return contestants[winnerKey]; // ...and return the winner Contestant object as ISubscriber object
        }

        // Accepts a single contestant and prints their registration info
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.regNumber}: {contestant.fname} {contestant.lname}, {contestant.email}");
        }

        // Extra credit attempt; loops through each contestant and uses logic in the Contestant class to notify losers/the winner appropriately
        // following the Observer design pattern. (Again, please let me know how I could have more cleanly implemented this :) )
        public void NotifySubscribers(ISubscriber winner)
        {
            foreach(KeyValuePair<int, ISubscriber> loser in contestants)
            {
                loser.Value.Notify(loser.Value, winner);
            }
        }
    }
}
