int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    if (number2 > number3)
    {
        Console.WriteLine($"{number1},{number2},{number3}");
    }
    else
    {
        Console.WriteLine($"{number1},{number3},{number2}");
    }
}
else if (number2 > number1 && number2 > number3)
{
    if (number1 > number3)
    {
        Console.WriteLine($"{number2},{number1},{number3}");
    }
    else

    {
        Console.WriteLine($"{number2},{number3},{number1}");
    }
}
else
{
    if (number1 > number2)
    {
        Console.WriteLine($"{number3},{number1},{number2}");
    }
    else
    {
        Console.WriteLine($"{number3},{number2},{number1}");
    }
}
