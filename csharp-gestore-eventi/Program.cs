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

string programTitle = checkValidString("What's the name of your events program? ", "Program must have a name");

int eventsNumber = checkValidInt("How many events would you like to add? ", "You should insert a number");

EventsProgram myEventsProgram = new EventsProgram(programTitle);

for (int i = 0; i < eventsNumber; i++)
{
    Console.WriteLine($"Create {i + 1}° event");

    string eventTitle = checkValidString("Event title: ", "Title can't be empty");

    DateTime eventDate = checkValidDate("Event date (dd/MM/yyyy): ", "Insert the date in a valid format");

    int eventMaxSeats = checkValidInt("Event max seats: ", "This field can't be a string or 0");

    myEventsProgram.AddEvent(eventTitle, eventDate, eventMaxSeats);
}

Console.WriteLine($"Events count: {myEventsProgram.GetEventsCount()}");
Console.WriteLine(myEventsProgram.GetProgramInfo());

DateTime dateToSearch = checkValidDate("Search for an event: ", "Insert the date in a valid format");

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
DateTime checkValidDate(string prompt, string message)
{
    bool isDate = false;
    DateTime output;
    do
    {
        Console.Write(prompt);
        isDate = DateTime.TryParse(Console.ReadLine(), out output);

        if (!isDate)
        {
            Console.WriteLine(message);
        }
    } while (!isDate);

    return output;
}

string checkValidString(string prompt, string message)
{
    string output = "";
    do
    {
        Console.Write(prompt);
        output = Console.ReadLine();

        if (isNullEmptyWhiteSpace(output))
        {
            Console.WriteLine(message);
        }
    } while (isNullEmptyWhiteSpace(output));

    return output;
}

int checkValidInt(string prompt, string message)
{
    bool isNumber = false;
    int output = 0;

    do
    {
        Console.Write(prompt);
        isNumber = Int32.TryParse(Console.ReadLine(), out output);

        if (!isNumber)
        {
            Console.WriteLine(message);
        }
    } while (!isNumber || output == 0);

    return output;
}


