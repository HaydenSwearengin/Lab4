//This program will ask the users how many checks they wrote Hayden Swearengin

System.Console.WriteLine("How many checks ave you wrote this month?");
string checkNumString = System.Console.ReadLine();
double checkNum = System.Convert.ToInt32(checkNumString);

double total;
if(checkNum < 20)
    {
        total = checkNum * .10 + 10;
        System.Console.WriteLine($"Your service fees for the month are ${total}");
    }
else if(checkNum < 40)
    {
        total = checkNum *.08 + 10;
        System.Console.WriteLine($"Your service fees for the month are ${total}");
    }
else if(checkNum < 60)
    {
        total = checkNum *.06 + 10;
        System.Console.WriteLine($"Your service fees for the month are ${total}");
    }
else
    {
        total = checkNum * .04 + 10;
        System.Console.WriteLine($"Your service fees for the month are ${total}");
    }
