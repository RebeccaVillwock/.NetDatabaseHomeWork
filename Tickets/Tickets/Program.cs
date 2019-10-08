using System;
using System.Collections.Generic;
using System.IO;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable for assigning array size
            int numTickets = 0;
            TicketFile tf = new TicketFile();
            Task[] taskT = new Task[numTickets];
            Enhancements[] enhanceT = new Enhancements[numTickets];
            TroubleTicket[] troubleT = new TroubleTicket[numTickets];

            string typeTicket;
            string file = "ticketInfo.txt";

            

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

            //if they want to enter a trouble ticket
            if (typeTicket == "1")
            {
                
                //get and save all information for trouble tickets they want to enter
                for(int i = 0; i < numTickets; i++)
                {
                    troubleT[i].askForTicketID();
                    troubleT[i].ticketID = Int32.Parse(Console.ReadLine());

                    troubleT[i].askForSummary();
                    troubleT[i].summary = Console.ReadLine();

                    troubleT[i].askForPriority();
                    troubleT[i].priority = Console.ReadLine();

                    troubleT[i].askForSubmitter();
                    troubleT[i].submitter = Console.ReadLine();

                    troubleT[i].askForAssigned();
                    troubleT[i].assigned = Console.ReadLine();

                    troubleT[i].askForWatching();
                    troubleT[i].watching = Console.ReadLine();

                    troubleT[i].askForSeverity();
                    troubleT[i].severity = Console.ReadLine();
                }
            }
            //get and save all enhancement tickets
            else if(typeTicket == "2")
            {
                
                for(int i = 0; i < numTickets; i++)
                {
                    enhanceT[i].askForTicketID();
                    enhanceT[i].ticketID = Int32.Parse(Console.ReadLine());

                    enhanceT[i].askForSummary();
                    enhanceT[i].summary = Console.ReadLine();

                    enhanceT[i].askForPriority();
                    enhanceT[i].priority = Console.ReadLine();

                    enhanceT[i].askForSubmitter();
                    enhanceT[i].submitter = Console.ReadLine();

                    enhanceT[i].askForAssigned();
                    enhanceT[i].assigned = Console.ReadLine();

                    enhanceT[i].askForWatching();
                    enhanceT[i].watching = Console.ReadLine();

                    enhanceT[i].askForSoftware();
                    enhanceT[i].software = Console.ReadLine();

                    enhanceT[i].askForCost();
                    enhanceT[i].cost = Double.Parse(Console.ReadLine());

                    enhanceT[i].askForReason();
                    enhanceT[i].reason = Console.ReadLine();

                    enhanceT[i].askForEstimate();
                    enhanceT[i].estimate = Console.ReadLine();
                }
            }
            //get info if user wants to add a task ticket
            else
            {
                
                for(int i = 0; i < numTickets; i++)
                {
                    taskT[i].askForTicketID();
                    taskT[i].ticketID = Int32.Parse(Console.ReadLine());

                    taskT[i].askForSummary();
                    taskT[i].summary = Console.ReadLine();

                    taskT[i].askForPriority();
                    taskT[i].priority = Console.ReadLine();

                    taskT[i].askForSubmitter();
                    taskT[i].submitter = Console.ReadLine();

                    taskT[i].askForAssigned();
                    taskT[i].assigned = Console.ReadLine();

                    taskT[i].askForWatching();
                    taskT[i].watching = Console.ReadLine();

                    taskT[i].askForProjectName();
                    taskT[i].projectName = Console.ReadLine();

                    taskT[i].askForDueDate();
                    taskT[i].dueDate = Console.ReadLine();
                }

            }

            //after the for loop clear the display
            Console.Clear();

            //write info to file only if something new
            if(numTickets > 0)
            {
                //create file from data
                StreamWriter sw = File.AppendText(file);

                if (typeTicket == "1")
                {
                    //troubleT
                    for(int i = 0; i < troubleT.Length; i++)
                    {
                        tf.writeToTroubleTicketFile(troubleT[i]);
                    }
                }
                else if (typeTicket == "2")
                {
                    //enhanceT
                    for(int i = 0; i < enhanceT.Length; i++)
                    {
                        tf.writeToEnhancementsFile(enhanceT[i]);
                    }
                }else if(typeTicket == "3")
                {
                    //taskT
                    for(int i = 0; i < taskT.Length; i++)
                    {
                        tf.writeToTaskFile(taskT[i]);
                    }
                }
                tf.closeFile();
                
            }

            //read info from file if desired
            string toRead;
            Console.WriteLine("Would you like to read the file(yes/no)? ");
            toRead = Console.ReadLine().ToLower();

            //if loop to read file
            if(toRead == "yes")
            {
                List<Ticket> ticketList = tf.readFromTicketFile();
                for(int i = 0; i < ticketList.Count; i++)
                {
                    ticketList[i].toString();
                }

            }

        }
    }
    
 
    
}
