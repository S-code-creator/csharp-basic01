using System;

public class operatorsProgram
{
    public static void assignment4()
    {
        // calculation 
        int number1, number2, number3, sum;
        double Average;

        Console.WriteLine("Enter Number1:");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number2:");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number3:");
        number3 = Convert.ToInt32(Console.ReadLine());

        sum = number1 + number2 + number3;
        Console.WriteLine("sum is:" + sum);

        Average = (double)sum / 3;
        Console.WriteLine("Average Valu: " + Average.ToString("F2"));
        
    }
}