using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class TroubleTicket : Ticket
    {
        public string severity { get; set; }

        //empty constructor
        public TroubleTicket()
        {

        }

        //completed constructor
        public TroubleTicket(string s)
        {
            severity = s;
        }
        
        public void askForSeverity()
        {
            Console.WriteLine("Enter ticket Severity: ");
        }
        public new string toString()
        {
            return $"Ticket ID: {ticketID}, Summary: {summary}, Status: {status}, Priority: {priority}, Submitter: {submitter}, Assigned: {assigned}, Watching: {watching}, Severity: {severity}";
        }
    }
}
