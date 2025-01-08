using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Winter_Exam
{
    internal class Event : IComparable
    {
        //I was unable to get the enum variable to work and had to use a string for it instead
        //public enum EventType TypeOfEvent {"Music", "Comedy", "Theatre"};
        public string TypeOfEvent { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Event()
        {
        }

        //constructor
        public Event(string name, DateTime eventDate, List<Ticket> ticket, string typeOfEvent)
        {
            Name = name;
            EventDate = eventDate;
            Tickets = ticket;
            TypeOfEvent = typeOfEvent;
        }

        //For the dates of the events
        public DateTime CompareTo(object? eventDate)
        {
            EventDate.Date.AddYears(1);
            return EventDate;
        }
        //Display
        public override string ToString()
        { 
            return $"{Name}{EventDate.ToString("yyyyMMdd")}{TypeOfEvent}";
        }

        //Adding details for the event listbox
        public string Details()
        {
            string Person1 = Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20).ToString(), TypeOfEvent = "Music";
            string Person2 = Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20).ToString(), TypeOfEvent = "Music";
            return Person1;
        }
    }
}
