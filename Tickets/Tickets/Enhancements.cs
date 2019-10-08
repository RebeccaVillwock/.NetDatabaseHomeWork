using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class Enhancements : Ticket
    {
        public string software { get; set; }
        public double cost { get; set; }
        public string reason { get; set; }
        public string estimate { get; set; }

        //empty constructor
        public Enhancements()
        {
            software = " ";
            cost = 0.00;
            reason = " ";
            estimate = " ";
        }
        //full constructor
        public Enhancements(string s, double c, string r, string e)
        {
            software = s;
            cost = c;
            reason = r;
            estimate = e;
        }
        public void askForSoftware()
        {
            Console.WriteLine("Enter the software for enhancement: ");
        }
        public void askForCost()
        {
            Console.WriteLine("Enter Cost: ");
        }
        public void askForReason()
        {
            Console.WriteLine("Enter reason for enhancements: ");
        }
        public void askForEstimate()
        {
            Console.WriteLine("Enter estimate of enhancements: ");
        }
        public new string toString()
        {
            return $"Ticket ID: {ticketID}, Summary: {summary}, Status: {status}, Priority: {priority}, Submitter: {submitter}, Assigned: {assigned}, Watching: {watching}, Software: {software}, Cost: {cost}, Reason: {reason}, Estimate: {estimate}";
        }
    }
}
