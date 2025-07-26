using System;

public class Input
{
    public static void anyInput()
    {
        string? studentName;
        int studentAge;
        double GPA;
        bool isRegistered;

        Console.WriteLine("Enter your name:");
        studentName = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your GPA:");
        GPA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Have you already Registered:");
        isRegistered = Convert.ToBoolean(Console.ReadLine());


        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Student Age" + studentAge + "Years old");
        Console.WriteLine("Student GPA" + GPA);
        Console.WriteLine("Student Registeard" + isRegistered);

    }
}