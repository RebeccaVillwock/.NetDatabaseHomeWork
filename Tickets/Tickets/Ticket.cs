using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class Ticket
    {
        public int ticketID { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string submitter { get; set; }
        public string assigned { get; set; }
        public string watching { get; set; }

        //basic constructor
        public Ticket()
        {
            ticketID = 0;
            summary = " ";
            status = " ";
            priority = " ";
            submitter = " ";
            assigned = " ";
            watching = " ";
        }

        //completed constructor
        public Ticket(int tID, string sum, string stat, string prior, string sub, string assign, string watch)
        {
            ticketID = tID;
            summary = sum;
            status = stat;
            priority = prior;
            submitter = sub;
            assigned = assign;
            watching = watch;
        }
        public void askForTicketID()
        {
            Console.WriteLine("Enter Ticket ID: ");
        }
        public void askForSummary()
        {
            Console.WriteLine("Summarize Ticket: ");
        }

        public void askForPriority()
        {
            Console.WriteLine("Enter Ticket Priority: ");
        }

        public void askForSubmitter()
        {
            Console.WriteLine("Enter those who submitted the ticket: ");

        }
        public void askForAssigned()
        {
            Console.WriteLine("Enter those the ticket is assigned to: ");
        }
        public void askForWatching()
        {
            Console.WriteLine("Enter those watching: ");
        }
        public string toString()
        {
            return $"Ticket ID: {ticketID}, Summary: {summary}, Status: {status}, Priority: {priority}, Submitter: {submitter}, Assigned: {assigned}, Watching: {watching}";
        }
      }
    }
