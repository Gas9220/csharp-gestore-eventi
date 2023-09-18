using csharp_gestore_eventi;

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

string message = "";

string programTitle = "";
do
{
    Console.Write("What's the name of your events program? ");
    programTitle = Console.ReadLine();

    if (isNullEmptyWhiteSpace(programTitle))
    {
        message = "Title can't be empty";
        Console.WriteLine(message);
    }
} while (isNullEmptyWhiteSpace(programTitle));

int eventsNumber;
bool isNumber = false;

do
{
    Console.Write("How many events would you like to add? ");
    isNumber = Int32.TryParse(Console.ReadLine(), out eventsNumber);

    if (!isNumber)
    {
        message = "You should insert a number";
        Console.WriteLine(message);
    }
} while (!isNumber);

isNumber = false;

EventsProgram myEventsProgram = new EventsProgram(programTitle);

for (int i = 0; i < eventsNumber; i++)
{
    Console.WriteLine($"Create {i + 1}° event");

    string eventTitle = "";

    do
    {
        Console.Write("Event title: ");
        eventTitle = Console.ReadLine();

        if (isNullEmptyWhiteSpace(eventTitle))
        {
            message = "Title can't be empty";
            Console.WriteLine(message);
        }
    } while (isNullEmptyWhiteSpace(eventTitle));

    bool isDate = false;
    DateTime eventDate;

    do
    {
        Console.Write("Event date (dd/MM/yyyy): ");
        isDate = DateTime.TryParse(Console.ReadLine(), out eventDate);

        if (!isDate)
        {
            message = "Insert the date in a valid format";
            Console.WriteLine(message);
        }

    } while (!isDate);

    int eventMaxSeats = 0;

    do
    {
        Console.Write("Event max seats: ");
        isNumber = Int32.TryParse(Console.ReadLine(), out eventMaxSeats);

        if (!isNumber)
        {
            message = "This field can't be a string or 0";
            Console.WriteLine(message);
        }
    } while (!isNumber || eventMaxSeats == 0);

    myEventsProgram.AddEvent(eventTitle, eventDate, eventMaxSeats);
}

Console.WriteLine($"Events count: {myEventsProgram.GetEventsCount()}");
Console.WriteLine(myEventsProgram.GetProgramInfo());

bool isDate2 = false;
DateTime dateToSearch;

do
{
    Console.Write("Search for an event: ");
    isDate2 = DateTime.TryParse(Console.ReadLine(), out dateToSearch);

    if (!isDate2)
    {
        message = "Insert the date in a valid format";
        Console.WriteLine(message);
    }

} while (!isDate2);

myEventsProgram.GetEventsOnDate(dateToSearch);

myEventsProgram.ClearProgram();
Console.WriteLine("All events have been cancelled");











// Helper functions - to move in another file
bool isNullEmptyWhiteSpace(string? text)
{
    if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
    {
        return true;
    }

    return false;
}



