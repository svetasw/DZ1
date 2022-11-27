int max = 0;

Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);

