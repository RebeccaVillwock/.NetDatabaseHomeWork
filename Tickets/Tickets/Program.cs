using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable for assigning array size
            int numTickets = 0;
            TicketFile tf = new TicketFile();
           

            string typeTicket;
            string userInput;
            string userSearch;


            //find out if they want to enter a ticket, read the file, search the file

            Console.WriteLine("1)Enter ticket(s)");
            Console.WriteLine("2)Read ticket file");
            Console.WriteLine("3)Search ticket file");

            userInput = Console.ReadLine();

            
            while(userInput == "1" || userInput == "2" || userInput == "3")
            {
                //if user wants to enter ticket(s)
                if(userInput == "1") { 
                //get the type of ticket
                Console.WriteLine("1)Trouble Ticket");
                Console.WriteLine("2)Enhancement Ticket");
                Console.WriteLine("3)Task Ticket");

                typeTicket = Console.ReadLine();

                //get value to place in numTickets
                Console.WriteLine("How many tickets of that type do you want to enter: ");
                //save then turn convert to integer
                string resp = Console.ReadLine();
                numTickets = Int32.Parse(resp);

                //create arrays of proper size to hold ticket types
                Task[] taskT = new Task[numTickets];
                TroubleTicket[] troubleT = new TroubleTicket[numTickets];
                Enhancements[] enhanceT = new Enhancements[numTickets];

                //if they want to enter a trouble ticket
                if (typeTicket == "1")
                {
                    TroubleTicket trouble = new TroubleTicket();
                    //get and save all information for trouble tickets they want to enter
                    for (int i = 0; i < numTickets; i++)
                    {
                        trouble.askForTicketID();
                        trouble.ticketID = Int32.Parse(Console.ReadLine());

                        trouble.askForStatus();
                        trouble.status = Console.ReadLine();

                        trouble.askForSummary();
                        trouble.summary = Console.ReadLine();

                        trouble.askForPriority();
                        trouble.priority = Console.ReadLine();

                        trouble.askForSubmitter();
                        trouble.submitter = Console.ReadLine();

                        trouble.askForAssigned();
                        trouble.assigned = Console.ReadLine();

                        trouble.askForWatching();
                        trouble.watching = Console.ReadLine();

                        trouble.askForSeverity();
                        trouble.severity = Console.ReadLine();

                        //add new ticket into array
                        troubleT[i] = trouble;
                    }
                }
                //get and save all enhancement tickets
                else if (typeTicket == "2")
                {
                    Enhancements enhance = new Enhancements();
                    for (int i = 0; i < numTickets; i++)
                    {
                        enhance.askForTicketID();
                        enhance.ticketID = Int32.Parse(Console.ReadLine());

                        enhance.askForSummary();
                        enhance.summary = Console.ReadLine();

                        enhance.askForStatus();
                        enhance.status = Console.ReadLine();

                        enhance.askForPriority();
                        enhance.priority = Console.ReadLine();

                        enhance.askForSubmitter();
                        enhance.submitter = Console.ReadLine();

                        enhance.askForAssigned();
                        enhance.assigned = Console.ReadLine();

                        enhance.askForWatching();
                        enhance.watching = Console.ReadLine();

                        enhance.askForSoftware();
                        enhance.software = Console.ReadLine();

                        enhance.askForCost();
                        enhance.cost = Double.Parse(Console.ReadLine());

                        enhance.askForReason();
                        enhance.reason = Console.ReadLine();

                        enhance.askForEstimate();
                        enhance.estimate = Console.ReadLine();

                        //add new ticket to array
                        enhanceT[i] = enhance;
                    }
                }
                //get info if user wants to add a task ticket
                else
                {
                    Task task = new Task();

                    for (int i = 0; i < numTickets; i++)
                    {
                        task.askForTicketID();
                        task.ticketID = Int32.Parse(Console.ReadLine());

                        task.askForSummary();
                        task.summary = Console.ReadLine();

                        task.askForStatus();
                        task.status = Console.ReadLine();
                            
                        task.askForPriority();
                        task.priority = Console.ReadLine();

                        task.askForSubmitter();
                        task.submitter = Console.ReadLine();

                        task.askForAssigned();
                        task.assigned = Console.ReadLine();

                        task.askForWatching();
                        task.watching = Console.ReadLine();

                        task.askForProjectName();
                        task.projectName = Console.ReadLine();

                        task.askForDueDate();
                        task.dueDate = Console.ReadLine();

                        //add new ticket to array
                        taskT[i] = task;
                    }

                }
                //after the for loop clear the display
                Console.Clear();

                    //write info to file only if something new
                    if (numTickets > 0)
                    {

                        if (typeTicket == "1")
                        {
                            //troubleT
                            for (int i = 0; i < troubleT.Length; i++)
                            {
                                tf.writeToTroubleTicketFile(troubleT[i]);
                            }
                        }
                        else if (typeTicket == "2")
                        {
                            //enhanceT
                            for (int i = 0; i < enhanceT.Length; i++)
                            {
                                tf.writeToEnhancementsFile(enhanceT[i]);
                            }
                        }
                        else if (typeTicket == "3")
                        {
                            //taskT
                            for (int i = 0; i < taskT.Length; i++)
                            {
                                tf.writeToTaskFile(taskT[i]);
                            }
                        }
                    }

                }
                //is user wants to read from the file
                else if(userInput == "2")
                {
                    List<Ticket> ticketList = tf.readFromTicketFile();
                    for (int i = 0; i < ticketList.Count; i++)
                    {
                        Console.WriteLine(ticketList[i].toString());
                    }
                }
                //if user wants to search the file
                else if(userInput == "3")
                {
                    //search cant be on status priority or submitter
                    Console.WriteLine("1)Search status");
                    Console.WriteLine("2)Search submitter");
                    Console.WriteLine("3)Search priority");

                    userInput = Console.ReadLine();

                    //status search
                    if(userInput == "1")
                    {
                        Console.WriteLine("Enter desired status");
                        userSearch = Console.ReadLine();
                        List<Ticket> ticket = tf.ticketList.Where(t => t.status.Contains(userSearch)).ToList();
                        //print tickets located
                        for(int i = 0; i < ticket.Count(); i++)
                        {
                            Console.WriteLine(ticket[i].toString());
                        }
                    }
                    //submitter search
                    else if(userInput == "2")
                    {
                        Console.WriteLine("Enter desired submitter");
                        userSearch = Console.ReadLine();
                        List<Ticket> ticket = tf.ticketList.Where(t => t.submitter.Contains(userSearch)).ToList();
                    }
                    //priority search
                    else if(userInput == "3")
                    {
                        Console.WriteLine("Enter desired priority");
                        userSearch = Console.ReadLine();
                        List<Ticket> ticket = tf.ticketList.Where(t => t.priority.Contains(userSearch)).ToList();
                    }
                }






                Console.WriteLine("1)Enter ticket(s)");
                Console.WriteLine("2)Read ticket file");
                Console.WriteLine("3)Search ticket file");
                Console.WriteLine("4)Exit program");

                userInput = Console.ReadLine();











            }
        }



    }
}
