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
        static private int regNumbers = 0; // needs to be static? test
        int ISubscriber.regNumber { get => regNumber; set => regNumber = value; }
        int ISubscriber.regNumbers { get => regNumbers; }

        // Ctor
        public Contestant(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            regNumber = AssignRegNumber();
        }

        // Methods
        public int AssignRegNumber()
        {
            regNumbers++;
            return regNumbers;
        }

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
