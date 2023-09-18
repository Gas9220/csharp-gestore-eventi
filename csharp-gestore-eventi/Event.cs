using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Event
    {
        public string Title
        {
            get
            {
                return Title;
            }
            set
            {
                if (value.Length > 0)
                {
                    Title = value;
                } else
                {
                    throw new ArgumentException("Title can't be empty");
                }
            }
        }
        public DateTime Date { get; set; }
        public int MaxSeats
        {
            get
            {
                return MaxSeats;
            }
            set
            {
                if (value > 0)
                {
                    MaxSeats = value;
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
