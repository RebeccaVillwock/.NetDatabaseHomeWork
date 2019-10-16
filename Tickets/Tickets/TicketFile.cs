using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tickets
{
    class TicketFile
    {

        
        
        private static string file = "ticketInfo.txt";
        
        //write file
        
        public void writeToTroubleTicketFile(TroubleTicket t)
        {
            StreamWriter sw = File.AppendText(file);
            sw.WriteLine($"{t.ticketID}|{t.summary}|{t.status}|{t.priority}|{t.submitter}|{t.assigned}|{t.watching}|{t.severity}");
            sw.Close();
        }

        public void writeToEnhancementsFile(Enhancements t)
        {
            StreamWriter sw = File.AppendText(file);
            sw.WriteLine($"{t.ticketID}|{t.summary}|{t.status}|{t.priority}|{t.submitter}|{t.assigned}|{t.watching}|{t.software}|{t.cost}|{t.reason}|{t.estimate}");
            sw.Close();
        }
        public void writeToTaskFile(Task t)
        {
            StreamWriter sw = File.AppendText(file);
            sw.WriteLine($"{t.ticketID}|{t.summary}|{t.status}|{t.priority}|{t.submitter}|{t.assigned}|{t.watching}|{t.projectName}|{t.dueDate}");
            sw.Close();
        }
        

        //read file
        
        public List<Ticket> ticketList = new List<Ticket>();
        public List<Ticket> readFromTicketFile()
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] ticketArr = line.Split("|");

                //trouble ticket
                if(ticketArr.Length == 8)
                {
                    TroubleTicket troubleT = new TroubleTicket();
                    troubleT.ticketID = Int32.Parse(ticketArr[0]);
                    troubleT.summary = ticketArr[1];
                    troubleT.status = ticketArr[2];
                    troubleT.priority = ticketArr[3];
                    troubleT.submitter = ticketArr[4];
                    troubleT.assigned = ticketArr[5];
                    troubleT.watching = ticketArr[6];
                    troubleT.severity = ticketArr[7];

                    ticketList.Add(troubleT);
                }else if(ticketArr.Length == 11)
                {
                    Enhancements enhanceT = new Enhancements();
                    enhanceT.ticketID = Int32.Parse(ticketArr[0]);
                    enhanceT.summary = ticketArr[1];
                    enhanceT.status = ticketArr[2];
                    enhanceT.priority = ticketArr[3];
                    enhanceT.submitter = ticketArr[4];
                    enhanceT.assigned = ticketArr[5];
                    enhanceT.watching = ticketArr[6];
                    enhanceT.software = ticketArr[7];
                    enhanceT.cost = Double.Parse(ticketArr[8]);
                    enhanceT.reason = ticketArr[9];
                    enhanceT.estimate = ticketArr[10];

                    ticketList.Add(enhanceT);
                }
                else
                {
                    Task taskT = new Task();
                    taskT.ticketID = Int32.Parse(ticketArr[0]);
                    taskT.summary = ticketArr[1];
                    taskT.status = ticketArr[2];
                    taskT.priority = ticketArr[3];
                    taskT.submitter = ticketArr[4];
                    taskT.assigned = ticketArr[5];
                    taskT.watching = ticketArr[6];
                    taskT.projectName = ticketArr[7];
                    taskT.dueDate = ticketArr[8];

                    ticketList.Add(taskT);
                }
            }

            return ticketList;
        }

    }
}
