using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLoopsQuestionsIntermediate
{
    class LoopsQuestionsIntermediate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== C# LOOPS - MEDIUM LEVEL QUESTIONS ==========\n");
            
            bool continueProgram = true;
            while (continueProgram)
            {
                DisplayMenu();
                Console.Write("\nEnter your choice (1-12): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Question1_ReverseNumber();
                        break;
                    case "2":
                        Question2_SumOfDigits();
                        break;
                    case "3":
                        Question3_ArmstrongNumber();
                        break;
                    case "4":
                        Question4_CountVowels();
                        break;
                    case "5":
                        Question5_PalindromeChecker();
                        break;
                    case "6":
                        Question6_SumOfEvenPositions();
                        break;
                    case "7":
                        Question7_FindSecondLargest();
                        break;
                    case "8":
                        Question8_CountFrequency();
                        break;
                    case "9":
                        Question9_PyramidPattern();
                        break;
                    case "10":
                        Question10_DiamondPattern();
                        break;
                    case "11":
                        Question11_MatrixRotation();
                        break;
                    case "12":
                        Console.WriteLine("\nExiting program. Goodbye!");
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }

                if (continueProgram && choice != "12")
                {
                    Console.WriteLine("\n--- Press any key to continue ---");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n========== MEDIUM LEVEL LOOP QUESTIONS ==========");
            Console.WriteLine("1.  Reverse a Number");
            Console.WriteLine("2.  Sum of All Digits");
            Console.WriteLine("3.  Armstrong Number Checker");
            Console.WriteLine("4.  Count Vowels in String");
            Console.WriteLine("5.  Palindrome Checker");
            Console.WriteLine("6.  Sum of Even Positioned Elements");
            Console.WriteLine("7.  Find Second Largest Element");
            Console.WriteLine("8.  Character Frequency Counter");
            Console.WriteLine("9.  Pyramid Pattern Generator");
            Console.WriteLine("10. Diamond Pattern Generator");
            Console.WriteLine("11. Matrix 90° Clockwise Rotation");
            Console.WriteLine("12. Exit");
            Console.WriteLine("===================================================");
        }

        // QUESTION 1: Reverse a Number
        static void Question1_ReverseNumber()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 1: REVERSE A NUMBER ==========\n");
            Console.WriteLine("Problem: Reverse a given number using loops.");
            Console.WriteLine("Example: Input = 12345, Output = 54321\n");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int reversed = 0;

            Console.WriteLine("\n--- Solution Using While Loop ---");
            int temp = Math.Abs(number);
            while (temp > 0)
            {
                int digit = temp % 10;
                reversed = reversed * 10 + digit;
                Console.WriteLine($"Digit: {digit}, Reversed so far: {reversed}");
                temp /= 10;
            }

            if (number < 0)
                reversed = -reversed;

            Console.WriteLine($"\nOriginal Number: {number}");
            Console.WriteLine($"Reversed Number: {reversed}");

            // Alternative using for loop
            Console.WriteLine("\n--- Alternative Solution Using For Loop ---");
            string numStr = Math.Abs(number).ToString();
            string reversedStr = "";
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                reversedStr += numStr[i];
            }
            if (number < 0)
                reversedStr = "-" + reversedStr;
            
            Console.WriteLine($"Reversed (using string): {reversedStr}");
        }

        // QUESTION 2: Sum of All Digits
        static void Question2_SumOfDigits()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 2: SUM OF ALL DIGITS ==========\n");
            Console.WriteLine("Problem: Find the sum of all digits in a number.");
            Console.WriteLine("Example: Input = 12345, Output = 1+2+3+4+5 = 15\n");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = Math.Abs(number);

            Console.WriteLine("\n--- Solution ---");
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                Console.WriteLine($"Digit: {digit}, Sum so far: {sum}");
                temp /= 10;
            }

            Console.WriteLine($"\nTotal sum of digits in {number}: {sum}");

            // Using for loop alternative
            Console.WriteLine("\n--- Alternative using For Loop ---");
            string numStr = Math.Abs(number).ToString();
            int sumAlt = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                int digit = int.Parse(numStr[i].ToString());
                sumAlt += digit;
            }
            Console.WriteLine($"Sum (alternative method): {sumAlt}");
        }

        // QUESTION 3: Armstrong Number Checker
        static void Question3_ArmstrongNumber()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 3: ARMSTRONG NUMBER CHECKER ==========\n");
            Console.WriteLine("Problem: Check if a number is an Armstrong number.");
            Console.WriteLine("An Armstrong number is equal to sum of its digits raised to power of digits count.");
            Console.WriteLine("Example: 153 = 1³+5³+3³ = 153 (Armstrong number)\n");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Solution ---");
            string numStr = number.ToString();
            int digitCount = numStr.Length;
            int sum = 0;
            int temp = number;

            Console.WriteLine($"Number of digits: {digitCount}");
            Console.WriteLine("Calculation:");

            while (temp > 0)
            {
                int digit = temp % 10;
                int power = (int)Math.Pow(digit, digitCount);
                sum += power;
                Console.WriteLine($"{digit}^{digitCount} = {power}");
                temp /= 10;
            }

            Console.WriteLine($"\nSum: {sum}");
            if (sum == number)
                Console.WriteLine($"✓ {number} IS an Armstrong number!");
            else
                Console.WriteLine($"✗ {number} is NOT an Armstrong number.");
        }

        // QUESTION 4: Count Vowels in String
        static void Question4_CountVowels()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 4: COUNT VOWELS IN STRING ==========\n");
            Console.WriteLine("Problem: Count the number of vowels in a string.\n");

            Console.Write("Enter a string: ");
            string text = Console.ReadLine().ToLower();
            int vowelCount = 0;

            Console.WriteLine("\n--- Solution ---");
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || 
                    text[i] == 'o' || text[i] == 'u')
                {
                    Console.WriteLine($"Position {i}: '{text[i]}' is a vowel");
                    vowelCount++;
                }
            }

            Console.WriteLine($"\nTotal vowels: {vowelCount}");

            // Using foreach alternative
            Console.WriteLine("\n--- Alternative using Foreach ---");
            int vowelCountAlt = 0;
            foreach (char c in text)
            {
                if ("aeiou".Contains(c))
                    vowelCountAlt++;
            }
            Console.WriteLine($"Total vowels (foreach method): {vowelCountAlt}");
        }

        // QUESTION 5: Palindrome Checker
        static void Question5_PalindromeChecker()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 5: PALINDROME CHECKER ==========\n");
            Console.WriteLine("Problem: Check if a string is a palindrome.");
            Console.WriteLine("Example: 'racecar' is a palindrome, 'hello' is not\n");

            Console.Write("Enter a string: ");
            string text = Console.ReadLine().ToLower().Replace(" ", "");
            bool isPalindrome = true;

            Console.WriteLine("\n--- Solution ---");
            for (int i = 0; i < text.Length / 2; i++)
            {
                Console.WriteLine($"Comparing '{text[i]}' with '{text[text.Length - 1 - i]}'");
                if (text[i] != text[text.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine($"\n✓ '{text}' IS a palindrome!");
            else
                Console.WriteLine($"\n✗ '{text}' is NOT a palindrome.");

            // Show reversed string
            Console.WriteLine("\n--- Reversed String ---");
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Reversed: {reversed}");
        }

        // QUESTION 6: Sum of Even Positioned Elements
        static void Question6_SumOfEvenPositions()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 6: SUM OF EVEN POSITIONED ELEMENTS ==========\n");
            Console.WriteLine("Problem: Sum array elements at even positions (0-indexed).");
            Console.WriteLine("Example: Array [10, 20, 30, 40, 50]");
            Console.WriteLine("Positions: 0=10(even), 1=20(odd), 2=30(even), 3=40(odd), 4=50(even)");
            Console.WriteLine("Sum of even positions: 10+30+50 = 90\n");

            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("\nEnter array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n--- Solution ---");
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.WriteLine($"Position {i}: {arr[i]}");
                sum += arr[i];
            }

            Console.WriteLine($"\nArray: [{string.Join(", ", arr)}]");
            Console.WriteLine($"Sum of even positioned elements: {sum}");
        }

        // QUESTION 7: Find Second Largest Element
        static void Question7_FindSecondLargest()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 7: FIND SECOND LARGEST ELEMENT ==========\n");
            Console.WriteLine("Problem: Find the second largest element in an array.\n");

            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("\nEnter array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n--- Solution ---");
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }

            Console.WriteLine($"Array: [{string.Join(", ", arr)}]");
            Console.WriteLine($"Largest element: {largest}");
            Console.WriteLine($"Second largest element: {secondLargest}");

            // Alternative using sorting
            Console.WriteLine("\n--- Alternative using Sorting ---");
            Array.Sort(arr, (a, b) => b.CompareTo(a)); // Sort descending
            Console.WriteLine($"Sorted array: [{string.Join(", ", arr)}]");
            Console.WriteLine($"Second largest: {arr[1]}");
        }

        // QUESTION 8: Character Frequency Counter
        static void Question8_CountFrequency()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 8: CHARACTER FREQUENCY COUNTER ==========\n");
            Console.WriteLine("Problem: Count frequency of each character in a string.\n");

            Console.Write("Enter a string: ");
            string text = Console.ReadLine().ToLower().Replace(" ", "");

            Console.WriteLine("\n--- Solution ---");
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (frequency.ContainsKey(text[i]))
                    frequency[text[i]]++;
                else
                    frequency[text[i]] = 1;
            }

            Console.WriteLine("\nCharacter Frequency:");
            foreach (var pair in frequency.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"'{pair.Key}' appears {pair.Value} time(s)");
            }

            // Alternative using nested loops
            Console.WriteLine("\n--- Alternative using Nested Loops ---");
            bool[] counted = new bool[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if (!counted[i])
                {
                    int count = 0;
                    for (int j = i; j < text.Length; j++)
                    {
                        if (text[i] == text[j])
                        {
                            count++;
                            counted[j] = true;
                        }
                    }
                    Console.WriteLine($"'{text[i]}' appears {count} time(s)");
                }
            }
        }

        // QUESTION 9: Pyramid Pattern Generator
        static void Question9_PyramidPattern()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 9: PYRAMID PATTERN GENERATOR ==========\n");
            Console.WriteLine("Problem: Generate a pyramid pattern using nested loops.\n");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Pattern 1: Number Pyramid ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Pattern 2: Star Pyramid ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Pattern 3: Inverted Pyramid ---");
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Pattern 4: Right-Aligned Pyramid ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        // QUESTION 10: Diamond Pattern Generator
        static void Question10_DiamondPattern()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 10: DIAMOND PATTERN GENERATOR ==========\n");
            Console.WriteLine("Problem: Generate a diamond pattern using nested loops.\n");

            Console.Write("Enter diamond size (odd number): ");
            int size = int.Parse(Console.ReadLine());
            int mid = size / 2;

            Console.WriteLine("\n--- Diamond Pattern ---");
            
            // Upper half including middle
            for (int i = 0; i <= mid; i++)
            {
                for (int j = 0; j < mid - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower half
            for (int i = mid - 1; i >= 0; i--)
            {
                for (int j = 0; j < mid - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Hollow Diamond ---");
            // Upper half
            for (int i = 0; i <= mid; i++)
            {
                for (int j = 0; j < mid - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (j == 0 || j == 2 * i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            // Lower half
            for (int i = mid - 1; i >= 0; i--)
            {
                for (int j = 0; j < mid - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (j == 0 || j == 2 * i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        // QUESTION 11: Matrix 90° Clockwise Rotation
        static void Question11_MatrixRotation()
        {
            Console.Clear();
            Console.WriteLine("========== QUESTION 11: MATRIX 90° CLOCKWISE ROTATION ==========\n");
            Console.WriteLine("Problem: Rotate a matrix 90 degrees clockwise using loops.\n");

            Console.Write("Enter matrix size (NxN): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            Console.WriteLine("\nEnter matrix elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n--- Original Matrix ---");
            PrintMatrix(matrix);

            // Rotate 90 degrees clockwise
            int[,] rotated = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotated[j, n - 1 - i] = matrix[i, j];
                }
            }

            Console.WriteLine("\n--- Rotated Matrix (90° Clockwise) ---");
            PrintMatrix(rotated);

            // Rotate 90 degrees counter-clockwise
            int[,] rotatedCCW = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotatedCCW[n - 1 - j, i] = matrix[i, j];
                }
            }

            Console.WriteLine("\n--- Rotated Matrix (90° Counter-Clockwise) ---");
            PrintMatrix(rotatedCCW);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
