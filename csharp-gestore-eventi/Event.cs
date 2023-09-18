using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Event
    {
        private string title;
        private DateTime date;
        private int maxSeats;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length > 0)
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Title can't be empty");
                }
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if (DateTime.Now.Date < value.Date)
                {
                    date = value;
                }
                else
                {
                    throw new ArgumentException("Date can't be in the past");
                }
            }
        }
        public int MaxSeats
        {
            get
            {
                return maxSeats;
            }
            private set
            {
                if (value > 0)
                {
                    maxSeats = value;
                }
                else
                {
                    throw new ArgumentException("MaxSeats can't be negative");
                }
            }
        }
        public int BookedSeats { get; private set; }

        public Event(string title, DateTime date, int maxSeats)
        {
            Title = title;
            Date = date;
            MaxSeats = maxSeats;
            BookedSeats = 0;
        }
    }
}
