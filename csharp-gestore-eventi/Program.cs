// Test
using csharp_gestore_eventi;

Console.WriteLine("Create new event-");

Console.WriteLine("Event title: ");
string eventTitle = Console.ReadLine();

Console.WriteLine("Event date: ");
string stringEventDate = Console.ReadLine();
DateTime eventDate = DateTime.Parse(stringEventDate);

Console.WriteLine("Event max seats: ");
string stringEventMaxSeats = Console.ReadLine();
int eventMaxSeats = int.Parse(stringEventMaxSeats);

Event newEvent = new Event(eventTitle, eventDate, eventMaxSeats);

newEvent.BookSeats(50);
newEvent.CancelSeats(20);
Console.WriteLine(newEvent.ToString());

