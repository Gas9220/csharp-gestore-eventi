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

        public void AddConference(string title, DateTime date, int maxSeats, string speaker, int price)
        {
            Conference newConference = new Conference(title, date, maxSeats, speaker, price);
            events.Add(newConference);
            Console.WriteLine($"Congratulation you have added a new conference {newConference.ToString()}");
        }

        public Event[] GetEventsOnDate(DateTime date)
        {
            List<Event> onDateEvents = new List<Event>();

            foreach (var ev in events)
            {
                if (ev.Date.Date == date.Date)
                {
                    onDateEvents.Add(ev);
                }
            }

            if (onDateEvents.Count > 0)
            {
                GetAllEvents(onDateEvents);
            }

            return onDateEvents.ToArray();
        }

        static void GetAllEvents(List<Event> events)
        {
            Console.WriteLine("Here is the events list:");
            foreach (var ev in events)
            {
                Console.WriteLine(ev.ToString());
            }
        }

        public int GetEventsCount()
        {
            return events.Count;
        }

        public void ClearProgram()
        {
            events.Clear();
        }

        public string GetProgramInfo()
        {
            string output = $@"
{title}
";

            foreach (Event ev in events)
            {
                output += $"\n{ev.ToString()}";
            }

            return output;
        }
    }
}
