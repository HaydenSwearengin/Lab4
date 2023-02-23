Console.WriteLine("Which audio book package did you buy(a,b,c)");
string bookType = Console.ReadLine();

Console.WriteLine("How many books did you read?");
string readBooksString = Console.ReadLine();
int readBooks = Convert.ToInt32(readBooksString);


double basicA = 10.00;
double basicB = 20;
if(bookType == "a")
    {
        if(readBooks > 10)
            {
                basicA = readBooks - basicA;
                double totalA = basicA * 2.00 + 9.95;
                Console.WriteLine($"Your total is ${totalA} per month, with {readBooks} books read");
            }
        else
            {
                Console.WriteLine($"Your total is $9.95 per month, with {readBooks} books read");
            }
    }
else if(bookType == "b")
    {
        if(readBooks > 20)
            {
                basicB = readBooks - basicB;
                double totalB = basicB * 2.00 + 9.95;
                Console.WriteLine($"Your total is ${totalB} per month");
            }
        else
            {
                Console.WriteLine($"Your total is $9.95 per month, with {readBooks} books read");
            }
    }
else
    {
        Console.WriteLine("Your total for the unlimited plan is 19.95");
    }
