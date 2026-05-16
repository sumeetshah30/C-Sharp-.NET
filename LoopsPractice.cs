using System;
using System.Collections.Generic;

namespace CSharpLoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== C# LOOPS PRACTICE PROGRAM ==========\n");
            
            // Menu-driven program
            bool continueProgram = true;
            while (continueProgram)
            {
                DisplayMenu();
                Console.Write("\nEnter your choice (1-8): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BasicForLoop();
                        break;
                    case "2":
                        WhileLoopExample();
                        break;
                    case "3":
                        DoWhileLoopExample();
                        break;
                    case "4":
                        ForeachLoopExample();
                        break;
                    case "5":
                        NestedLoops();
                        break;
                    case "6":
                        LoopControlStatements();
                        break;
                    case "7":
                        PracticeExercises();
                        break;
                    case "8":
                        Console.WriteLine("\nExiting program. Goodbye!");
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }

                if (continueProgram && choice != "7")
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n========== SELECT A TOPIC ==========");
            Console.WriteLine("1. Basic For Loop");
            Console.WriteLine("2. While Loop");
            Console.WriteLine("3. Do-While Loop");
            Console.WriteLine("4. Foreach Loop");
            Console.WriteLine("5. Nested Loops");
            Console.WriteLine("6. Loop Control Statements (break, continue)");
            Console.WriteLine("7. Practice Exercises");
            Console.WriteLine("8. Exit");
            Console.WriteLine("====================================");
        }

        // 1. BASIC FOR LOOP
        static void BasicForLoop()
        {
            Console.Clear();
            Console.WriteLine("========== BASIC FOR LOOP ==========\n");

            Console.WriteLine("Example 1: Print numbers from 1 to 5");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
            }

            Console.WriteLine("\nExample 2: Print even numbers from 1 to 10");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Even: {i}");
            }

            Console.WriteLine("\nExample 3: Print numbers in reverse (5 to 1)");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Number: {i}");
            }

            Console.WriteLine("\nExample 4: Calculate sum of numbers 1 to 10");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of 1 to 10 = {sum}");

            Console.WriteLine("\nExample 5: Multiplication table of 5");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 × {i} = {5 * i}");
            }
        }

        // 2. WHILE LOOP
        static void WhileLoopExample()
        {
            Console.Clear();
            Console.WriteLine("========== WHILE LOOP ==========\n");

            Console.WriteLine("Example 1: Count from 1 to 5 using while loop");
            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;
            }

            Console.WriteLine("\nExample 2: Sum numbers until input is -1");
            int total = 0;
            int number;
            Console.WriteLine("Enter numbers (enter -1 to stop):");
            while (true)
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                
                if (number == -1)
                    break;
                    
                total += number;
            }
            Console.WriteLine($"Total sum: {total}");

            Console.WriteLine("\nExample 3: Check if number is power of 2");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            while (temp > 1 && temp % 2 == 0)
            {
                temp /= 2;
            }
            if (temp == 1)
                Console.WriteLine($"{num} is a power of 2");
            else
                Console.WriteLine($"{num} is NOT a power of 2");
        }

        // 3. DO-WHILE LOOP
        static void DoWhileLoopExample()
        {
            Console.Clear();
            Console.WriteLine("========== DO-WHILE LOOP ==========\n");

            Console.WriteLine("Example 1: Simple do-while (executes at least once)");
            int x = 1;
            do
            {
                Console.WriteLine($"Value: {x}");
                x++;
            } while (x <= 5);

            Console.WriteLine("\nExample 2: Menu system with do-while");
            int choice = 0;
            do
            {
                Console.WriteLine("\n--- Mini Menu ---");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Say Goodbye");
                Console.WriteLine("3. Exit");
                Console.Write("Choose (1-3): ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        break;
                    case 3:
                        Console.WriteLine("Exiting menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 3);

            Console.WriteLine("\nExample 3: Validate user input with do-while");
            int age;
            do
            {
                Console.Write("Enter your age (1-120): ");
                age = int.Parse(Console.ReadLine());
                if (age < 1 || age > 120)
                    Console.WriteLine("Invalid age! Please enter between 1-120.");
            } while (age < 1 || age > 120);
            Console.WriteLine($"You are {age} years old.");
        }

        // 4. FOREACH LOOP
        static void ForeachLoopExample()
        {
            Console.Clear();
            Console.WriteLine("========== FOREACH LOOP ==========\n");

            Console.WriteLine("Example 1: Loop through array");
            int[] numbers = { 10, 20, 30, 40, 50 };
            foreach (int num in numbers)
            {
                Console.WriteLine($"Number: {num}");
            }

            Console.WriteLine("\nExample 2: Loop through string array");
            string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }

            Console.WriteLine("\nExample 3: Loop through list");
            List<string> countries = new List<string> { "USA", "Canada", "Mexico", "Brazil" };
            foreach (string country in countries)
            {
                Console.WriteLine($"Country: {country}");
            }

            Console.WriteLine("\nExample 4: Loop through 2D array");
            int[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            foreach (int element in matrix)
            {
                Console.WriteLine($"Element: {element}");
            }

            Console.WriteLine("\nExample 5: Enumerate with index using List");
            List<string> cities = new List<string> { "New York", "London", "Tokyo", "Paris" };
            int index = 0;
            foreach (string city in cities)
            {
                Console.WriteLine($"{index + 1}. {city}");
                index++;
            }
        }

        // 5. NESTED LOOPS
        static void NestedLoops()
        {
            Console.Clear();
            Console.WriteLine("========== NESTED LOOPS ==========\n");

            Console.WriteLine("Example 1: Multiplication table (5×5)");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nExample 2: Print pyramid pattern");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nExample 3: Find pairs that sum to 10");
            int[] arr = { 2, 3, 5, 7, 8, 9 };
            Console.WriteLine("Pairs that sum to 10:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == 10)
                    {
                        Console.WriteLine($"({arr[i]}, {arr[j]})");
                    }
                }
            }

            Console.WriteLine("\nExample 4: 3×3 matrix display");
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        // 6. LOOP CONTROL STATEMENTS
        static void LoopControlStatements()
        {
            Console.Clear();
            Console.WriteLine("========== LOOP CONTROL STATEMENTS ==========\n");

            Console.WriteLine("Example 1: Using BREAK (exit loop early)");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                {
                    Console.WriteLine("Breaking at i = 6");
                    break;
                }
                Console.WriteLine($"i = {i}");
            }

            Console.WriteLine("\nExample 2: Using CONTINUE (skip iteration)");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue; // Skip even numbers
                Console.WriteLine($"Odd number: {i}");
            }

            Console.WriteLine("\nExample 3: Break in nested loop");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (j == 2)
                    {
                        Console.WriteLine($"Breaking inner loop at i={i}, j={j}");
                        break;
                    }
                    Console.WriteLine($"i={i}, j={j}");
                }
            }

            Console.WriteLine("\nExample 4: Continue in nested loop");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (j == 2)
                        continue;
                    Console.WriteLine($"i={i}, j={j}");
                }
            }
        }

        // 7. PRACTICE EXERCISES
        static void PracticeExercises()
        {
            Console.Clear();
            Console.WriteLine("========== PRACTICE EXERCISES ==========\n");

            bool exerciseMenu = true;
            while (exerciseMenu)
            {
                Console.WriteLine("\nSelect an exercise:");
                Console.WriteLine("1. Factorial Calculator");
                Console.WriteLine("2. Prime Number Checker");
                Console.WriteLine("3. Fibonacci Series");
                Console.WriteLine("4. Number Guessing Game");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Enter choice (1-5): ");
                
                string exChoice = Console.ReadLine();

                switch (exChoice)
                {
                    case "1":
                        FactorialCalculator();
                        break;
                    case "2":
                        PrimeNumberChecker();
                        break;
                    case "3":
                        FibonacciSeries();
                        break;
                    case "4":
                        NumberGuessingGame();
                        break;
                    case "5":
                        exerciseMenu = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        // Exercise 1: Factorial Calculator
        static void FactorialCalculator()
        {
            Console.Clear();
            Console.WriteLine("========== FACTORIAL CALCULATOR ==========\n");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            
            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            
            Console.WriteLine($"Factorial of {num} = {factorial}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        // Exercise 2: Prime Number Checker
        static void PrimeNumberChecker()
        {
            Console.Clear();
            Console.WriteLine("========== PRIME NUMBER CHECKER ==========\n");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            
            bool isPrime = true;
            if (num < 2)
                isPrime = false;
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            
            if (isPrime)
                Console.WriteLine($"{num} is a PRIME number");
            else
                Console.WriteLine($"{num} is NOT a prime number");
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        // Exercise 3: Fibonacci Series
        static void FibonacciSeries()
        {
            Console.Clear();
            Console.WriteLine("========== FIBONACCI SERIES ==========\n");
            Console.Write("How many terms? ");
            int terms = int.Parse(Console.ReadLine());
            
            long a = 0, b = 1;
            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write($"{a} ");
                long temp = a + b;
                a = b;
                b = temp;
            }
            
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        // Exercise 4: Number Guessing Game
        static void NumberGuessingGame()
        {
            Console.Clear();
            Console.WriteLine("========== NUMBER GUESSING GAME ==========\n");
            
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;
            
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Try to guess it!\n");
            
            while (guess != secretNumber)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;
                
                if (guess < secretNumber)
                    Console.WriteLine("Too low! Try again.");
                else if (guess > secretNumber)
                    Console.WriteLine("Too high! Try again.");
                else
                    Console.WriteLine($"Correct! You guessed it in {attempts} attempts!");
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
