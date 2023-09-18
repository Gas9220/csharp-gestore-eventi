using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class EventsProgram
    {
        public string title;
        public List<Event> events;

        public EventsProgram(string title)
        {
            this.title = title;
            events = new List<Event>();
        }

        public void AddEvent(string title, DateTime date, int maxSeats)
        {
            Event newEvent = new Event(title, date, maxSeats);
            events.Add(newEvent);
            Console.WriteLine($"Congratulation you have added a new event {newEvent.ToString()}");
        }
    }
}
