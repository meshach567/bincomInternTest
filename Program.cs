// Task 1:
// Declare and initialize the following variables:
using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(isAdmin);
    }
}



// Task 2:
// Write a program that takes an integer input from the user and prints out whether the number is even or odd.

using System;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an interger: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        int num = 2;

        if (userInput  % num == 0)
        {
            Console.WriteLine("Even");
        } else
        {
            Console.WriteLine("Odd");
        }
    }
}

// Task 3:
// Write a program that prints out the numbers 1 to 10 using a for loop.

using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            total += i;
        }

        Console.WriteLine($"Sum of all values: {total}");
    }
}

// Task 4: 
// Declare and initialize an integer array with the values 2, 4, 6, 8, 10.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] evenNumbers = { 2, 4, 6, 8, 10 };
        
        int sum = 0;
        Console.WriteLine("Array of values:");
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
            sum += num;
        }
        
        Console.WriteLine($"Sum of all values: {sum}");
    }
}

using System;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int[] intArrayNumber = { 2, 4, 6, 8, 10 };

        foreach (int i in intArrayNumber)
        {
            Console.WriteLine(i);
        }
    }
}


// Task 5:
// Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.

using System;

class Program
{
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
    static void Main(string[] args)
    {
        Greet("Alice");
    }

}

