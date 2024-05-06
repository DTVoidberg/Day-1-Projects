using System.ComponentModel.Design;
using System.Numerics;
public class Calculators
{


    public static void Main(string[] args)
    {
        var firstNumber = GetNumberInput("Give me a first number: ");
        Console.WriteLine($"First Number you have chosen is {firstNumber}");
        var secondNumber = GetNumberInput("Give me the second number: ");
        Console.WriteLine($"Second Number you have chosen is {secondNumber}");


        Console.WriteLine("Which method would you like to use? (+, -, *, / )");
        string? userOperator = Console.ReadLine();

        var result = userOperator switch
        {
            "+" => firstNumber + secondNumber,
            "-" => firstNumber - secondNumber,
            "*" => firstNumber * secondNumber,
            "/" => firstNumber / secondNumber,
            _ => 0
        };
        Console.WriteLine($"The answer is {result}");


    }
    public static int GetNumberInput(string prompt)
    {
        int number;

        Console.WriteLine(prompt);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("That is not a number, Try again: ");
        }

        return number;
    }
}
