//Made by Mohammad Hossein Hatami
int x = 0;
string yn;
do
{
    Console.WriteLine("Please enter your score:");

    locknumkeyboard();

    Console.WriteLine();
    Console.WriteLine("-----------------------------------");

    ranking();

    Console.WriteLine("-----------------------------------");

    rating();

    Console.WriteLine();
    Console.WriteLine("Do you want to continiue? Press Y or N: ");

    lockYNkeybord();

    Console.WriteLine();
} while (yn.ToLower() == "y");




//Methods:
void locknumkeyboard()
{
    string input = "";
    while (true)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        if (char.IsDigit(keyInfo.KeyChar))
        {
            Console.Write(keyInfo.KeyChar);
            input += keyInfo.KeyChar;
        }
        else if (keyInfo.Key == ConsoleKey.Enter)
        {
            x = int.Parse(input);
            break;
        }
    }
}

void ranking()
{
    if (x > 20 || x < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("* Please enter the right score! *");
        Console.ResetColor();
    }
    else if (x > 17)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("> Your Rank is: (A)");
        Console.ResetColor();
    }
    else if (x > 15)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("> Your Rank is: (B)");
        Console.ResetColor();
    }
    else if (x > 10)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("> Your Rank is: (C)");
        Console.ResetColor();
    }
    else if (x >= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("> Sorry! You are failed :(");
        Console.ResetColor();
    }
}

void rating()
{
    int d = x * 5;
    if (d < 0 || d > 100)
    { }
    else if (d > 0)
    {
        Console.WriteLine("> And your success rate is: " + d + "%");
        Console.WriteLine("-----------------------------------");
    }
}

void lockYNkeybord()
{
    do
    {
        yn = Console.ReadKey(true).KeyChar.ToString();

    } while (yn.ToLower() != "y" && yn.ToLower() != "n");
}