using System;

namespace First_Lesson_1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("first num:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("second num:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("choose the type of operation (+ or -):");
        char operation = Convert.ToChar(Console.ReadLine());

        int result;

        if (operation == '+')
        {
            result = num1 + num2;
            Console.WriteLine($"result: {num1} + {num2} = {result}");
        }
        else if (operation == '-')
        {
            result = num1 - num2;
            Console.WriteLine($"result: {num1} - {num2} = {result}");
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
        
    }
}