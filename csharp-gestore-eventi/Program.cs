using csharp_gestore_eventi;

// PRE MILESTONE 4

/* Console.WriteLine("Create new event");

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
*/


// FROM MILESTONE 4 TO BONUS
string programTitle = Helpers.checkValidString("What's the name of your events program? ", "Program must have a name");

int eventsNumber = Helpers.checkValidInt("How many events would you like to add? ", "You should insert a number");

EventsProgram myEventsProgram = new EventsProgram(programTitle);

for (int i = 0; i < eventsNumber; i++)
{
    Console.WriteLine($"Create {i + 1}° event");

    string eventTitle = Helpers.checkValidString("Event title: ", "Title can't be empty");

    DateTime eventDate = Helpers.checkValidDate("Event date (dd/MM/yyyy): ", "Insert the date in a valid format");

    int eventMaxSeats = Helpers.checkValidInt("Event max seats: ", "This field can't be a string or 0");

    myEventsProgram.AddEvent(eventTitle, eventDate, eventMaxSeats);
}

Console.WriteLine($"Events count: {myEventsProgram.GetEventsCount()}");
Console.WriteLine(myEventsProgram.GetProgramInfo());

DateTime dateToSearch = Helpers.checkValidDate("Search for an event by date (dd/MM/yyyy): ", "Insert the date in a valid format");

myEventsProgram.GetEventsOnDate(dateToSearch);

//myEventsProgram.ClearProgram();
//Console.WriteLine("All events have been cancelled");

Console.WriteLine("BONUS");

int conferencesNumber = Helpers.checkValidInt("How many conferences would you like to add? ", "You should insert a number");

for (int i = 0; i < conferencesNumber; i++)
{
    Console.WriteLine($"Create {i + 1}° conference");

    string conferenceTitle = Helpers.checkValidString("Conference title: ", "Title can't be empty");

    DateTime conferenceDate = Helpers.checkValidDate("Conference date (dd/MM/yyyy): ", "Insert the date in a valid format");

    int conferenceMaxSeats = Helpers.checkValidInt("Conference max seats: ", "This field can't be a string or 0");

    string conferenceSpeaker = Helpers.checkValidString("Who is the speaker: ", "This field can't be empty");

    int conferencePrice = Helpers.checkValidInt("Conference price: ", "This field can't be a string or 0");

    myEventsProgram.AddConference(conferenceTitle, conferenceDate, conferenceMaxSeats, conferenceSpeaker, conferencePrice);
}

Console.WriteLine($"Events count: {myEventsProgram.GetEventsCount()}");
Console.WriteLine(myEventsProgram.GetProgramInfo());