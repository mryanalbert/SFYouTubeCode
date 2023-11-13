int number;
string input;

do
{
    Console.Write("Enter a positive integer: ");
    input = Console.ReadLine();

    if(int.TryParse(input, out number))
    {
        if(number > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("That was not a positive integer.");
        }
    }
    else
    {
        Console.WriteLine("That was not a positive integer.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
} while (true);

Console.WriteLine($"You entered {number}.");