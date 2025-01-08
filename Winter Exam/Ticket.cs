using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Winter_Exam
{
    internal class Ticket
    {
        //Declare variables
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvaliableTickets { get; set; }

        public Ticket() { }

        //Constructor
        public Ticket(string name, decimal price, int avaliableTickets)
        {
            Name = name;
            Price = price;
            AvaliableTickets = avaliableTickets;
        }

        public override string ToString() 
        { 
            return $"{Name} {Price} {AvaliableTickets}";
        }

        //Input data for Ticket listbox
        public string Details()
        {
            string Person1 = Name = "EarlyBird", Price = 100m.ToString(), AvaliableTickets = "100";
            string Person2 = Name = "Platnium", Price = 150m.ToString(), AvaliableTickets = "100";
            return Person1;
        }
        //Extended ticket class for VIPTickets
        internal class VIPTickets
        {
            //Declare variables
            public string AdditionalExtras { get; set; }
            public decimal AdditionalCost { get; set; }

            public VIPTickets() { }

            //constructor
            public VIPTickets(string additionalExtras, decimal additionalCost)
            {
                AdditionalExtras = additionalExtras;
                AdditionalCost = additionalCost;
            }
            //Input data for users
            public string VIPDetails()
            {
                string Person1 = Name = "Ticket and Hotel Package", Price = 105m.ToString(), AvaliableTickets = "100", additionalExtras = "4* hotel";
                string Person2 = Name = "Weekend Ticket", Price = 200m.ToString(), AvaliableTickets = "100", additionalExtras = "with camping";
                return Person1;
            }
        }
    }

    //I origionally had the extended class here. I was unsure to have it in the Ticket class or outside the ticket class

    //internal class VIPTickets
    //{
        //public string AdditionalExtras { get; set; }
        //public decimal AdditionalCost { get; set; }

        //public VIPTickets() { }

        //public VIPTickets(string additionalExtras, decimal additionalCost)
        //{
            //AdditionalExtras = additionalExtras;
            //AdditionalCost = additionalCost;
        //}

        //public string Details()
        //{
            //string Person1 = Name = "EarlyBird", Price = 100m.ToString(), AvaliableTickets = "100";
            //string Person2 = Name = "Platnium", Price = 150m.ToString(), AvaliableTickets = "100";
            //return Person1;
        //}
    //}
}
