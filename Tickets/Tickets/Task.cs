using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class Task : Ticket
    {
        public string projectName { get; set; }
        public string dueDate { get; set; }

        //empty constructor
        public Task()
        {
            projectName = " ";
            dueDate = " ";
        }

        //full constructor
        public Task(string pn, string dd)
        {
            projectName = pn;
            dueDate = dd;
        }

        public void askForProjectName()
        {
            Console.WriteLine("Enter project name: ");
        }

        public void askForDueDate()
        {
            Console.WriteLine("Enter due date of task: ");
        }
        public new string toString()
        {
            return $"Ticket ID: {ticketID}, Summary: {summary}, Status: {status}, Priority: {priority}, Submitter: {submitter}, Assigned: {assigned}, Watching: {watching}, Project Name: {projectName}, Due Date: {dueDate}";
        }
    }
}
