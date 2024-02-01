using System;

class Program
{
    static void Main()
    {
        float num1 = GetValidFloat("Write first num:");
        float num2 = GetValidFloat("Write second num:");

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }

    static float GetValidFloat(string prompt)
    {
        bool isValid = false;
        float number = 0;

        while (!isValid)
        {
            Console.WriteLine(prompt);
            isValid = float.TryParse(Console.ReadLine(), out number);

            if (!isValid)
                Console.WriteLine("It's not a number");
        }

        return number;
    }
}

