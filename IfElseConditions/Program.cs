// See https://aka.ms/new-console-template for more information
Random rand = new Random();
int number1 = rand.Next(1, 31);
int number2 = rand.Next(1, 31);

if (CheckIfEqual(number1, number2))
{
    Console.WriteLine($"{number1} and {number2} is equal");
}
else
{
    Console.WriteLine($"{number1} and {number2} is not equal");
}

AddOrMultiply(number1, number2);
Console.WriteLine($"Either {number1} or {number2} is 30, or {number1} and {number2} adds up to 30: {AddUpTo30(number1, number2)}");
static bool CheckIfEqual(int number1, int number2)
{
    if (number1 == number2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void AddOrMultiply(int number1, int number2)
{
    if (number1 == number2)
    {
        int numbersMultiplied = number1 * number2;
        Console.WriteLine($"{number1} * {number2} = {numbersMultiplied}");

    }
    else
    {
        int numbersSum = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {numbersSum}");
    }
}

static bool AddUpTo30(int number1, int number2)
{
    if (number1 + number2 == 30 || number1 == 30 || number2 == 30)
    {
        return true;
    }
    else { return false; }
}