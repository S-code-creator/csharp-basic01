using System;

public class formating
{
    public static void outputFormating()
    {
        int number1 = 10;
        int number2 = 20;
        int result;

        result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");

        result = number1 - number2;
        Console.WriteLine($"{number1} - {number2} = {result}");

        result = number1 * number2;
        Console.WriteLine($"{number1} * {number2} = {result}");

        result = number1 % number2;
        Console.WriteLine($"{number1} * {number2} = {result}"); 
    }
}