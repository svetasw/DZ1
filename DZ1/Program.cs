int max = 0;
int min = 0;

Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);

