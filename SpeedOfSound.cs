// THis program will ask the user to use air, water, or steel.Then, tell you the time it takes to travel.

Console.WriteLine("Would you like to use air, water, or steel");
string userInput = Console.ReadLine();

int elementType;
if(userInput ==  "air" )
    {
        elementType = 1100;
    }
else if(userInput == "water")
    {
        elementType = 4900;
    }
else
    {
        elementType = 16400;
    }

Console.WriteLine("What is the distance that it will go? ");
string distanceString;
int distance;

distanceString = Console.ReadLine();
distance = Convert.ToInt32(distanceString);

float finalNum = distance / elementType;
Console.WriteLine($"Your total time is {finalNum} seconds");