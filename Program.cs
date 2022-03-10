// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

double result = Convert.ToDouble(firstNum) / secondNum;
Console.WriteLine("The result of division: " + result);