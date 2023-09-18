using csharp_gestore_eventi;

Console.WriteLine("Create new event");

Console.Write("Event title: ");
string eventTitle = Console.ReadLine();

Console.Write("Event date: ");
string stringEventDate = Console.ReadLine();
DateTime eventDate = DateTime.Parse(stringEventDate);

Console.Write("Event max seats: ");
string stringEventMaxSeats = Console.ReadLine();
int eventMaxSeats = int.Parse(stringEventMaxSeats);

Event newEvent = new Event(eventTitle, eventDate, eventMaxSeats);

Console.WriteLine(newEvent.ToString());

Console.WriteLine("Would you like to book seats?(y/n)");
string userAnswer = Console.ReadLine();

while (userAnswer == "y")
{
    Console.Write("How many seats do you want to book? ");
    int seatsToBook = int.Parse(Console.ReadLine());
    newEvent.BookSeats(seatsToBook);

    newEvent.GetEventSeatsRecap();

    Console.WriteLine("Would you like to book other seats?(y/n)");
    userAnswer = Console.ReadLine();
}

Console.WriteLine("Would you like to cancel seats?(y/n)");
userAnswer = Console.ReadLine();

while (userAnswer == "y")
{
    Console.Write("How many seats do you want to cancel? ");
    int seatsToCancel = int.Parse(Console.ReadLine());
    newEvent.CancelSeats(seatsToCancel);

    newEvent.GetEventSeatsRecap();

    Console.WriteLine("Would you like to cancel other seats?(y/n)");
    userAnswer = Console.ReadLine();
}

EventsProgram eventsProgram = new EventsProgram("Events program");
eventsProgram.events.Add(newEvent);

Console.Write("Search an event: ");
DateTime dateToSearch = DateTime.Parse(Console.ReadLine());
eventsProgram.GetEventsOnDate(dateToSearch);

Console.WriteLine(eventsProgram.GetProgramInfo());



