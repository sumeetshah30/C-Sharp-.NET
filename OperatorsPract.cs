using System;

namespace CSharpOperatorsDemo
{
    class OperatorsExample
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;

            // Arithmetic Operators
            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));

            // Relational Operators
            Console.WriteLine("\nRelational Operators");
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            // Logical Operators
            bool isLoggedIn = true;
            bool isAdmin = false;

            Console.WriteLine("\nLogical Operators");
            Console.WriteLine(isLoggedIn && isAdmin);
            Console.WriteLine(isLoggedIn || isAdmin);
            Console.WriteLine(!isAdmin);

            // Assignment Operators
            int number = 5;

            Console.WriteLine("\nAssignment Operators");
            number += 3;
            Console.WriteLine(number);

            number -= 2;
            Console.WriteLine(number);

            // Increment / Decrement
            int count = 1;

            Console.WriteLine("\nIncrement Decrement");
            count++;
            Console.WriteLine(count);

            count--;
            Console.WriteLine(count);

            // Ternary Operator
            int age = 22;

            string result = (age >= 18) ? "Eligible to vote" : "Not eligible";

            Console.WriteLine("\nTernary Operator");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}