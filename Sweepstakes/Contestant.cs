using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    public class Contestant : ISubscriber
    {
        // Vars
        public string fname;
        string ISubscriber.fname { get => fname; set => fname = value; }
        public string lname;
        string ISubscriber.lname { get => lname; set => lname = value; }
        public string email;
        string ISubscriber.email { get => email; set => email = value; }
        public int regNumber;
        static private int regNumbers = 0; // Set to static so that the numbers continuously increment regardless of how many times Cotnestant is instantiated.
        // I wasn't able to figure out how to test this; any feedback on how to best go about testing would be much appreciated!
        int ISubscriber.regNumber { get => regNumber; set => regNumber = value; }
        int ISubscriber.regNumbers { get => regNumbers; }

        // Ctor
        public Contestant(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            regNumber = AssignRegNumber(); // The idea with this method is to keep a continuous, automated tracking of registration numbers to ensure each Contestant has a unique ID for when they are later added to the Dictionary in Sweepstakes
        }

        // Methods
        public int AssignRegNumber()
        {
            regNumbers++;
            return regNumbers;
        }

        // Invoked from Sweepstakes.PickWinner()
        public void Notify(ISubscriber loser, ISubscriber winner)
        {
            if (loser != winner)
            {
                Console.WriteLine("Sorry, you did not win.");
            }
            else
            {
                SendEmail(winner);
            }
        }

        // Using MailKit package to send email to winning subscriber; documentation available here: https://github.com/jstedfast/MailKit
        public static void SendEmail(ISubscriber winner)
        {
            string winnerFullName = winner.fname + winner.lname;
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Alex Fowle", "alexanderfowle@gmail.com"));
            email.To.Add(new MailboxAddress(winnerFullName, winner.email));
            email.Subject = "Congratulations!";
            email.Body = new TextPart("plain")
            {
                Text = "You won the thing!"
            };
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("aspmx.l.google.com", 25, false);
                client.Send(email);
                client.Disconnect(true);
            }
        }
    }
}
