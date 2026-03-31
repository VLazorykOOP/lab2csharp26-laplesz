using System;
using System.Linq;
using static System.Console;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                WriteLine("Select the task number (1-4) or 0 to exit:");
                Write("Your choice: ");
                string input = ReadLine();

                switch (input)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "0":
                        keepRunning = false;
                        WriteLine("Exiting the program...");
                        break;
                    default:
                        WriteLine("Error: Invalid input. Please enter a number between 0 and 6..");
                        break;
                }

                if (keepRunning)
                {
                    WriteLine("\nPress Enter to return to the menu...");
                    ReadLine();
                }
            }
        }

        static void Task1()
        {
            WriteLine("\n--- Task 1 is being performed ---");

            Write("Enter the dimension of the 1D array: ");
            int n = int.Parse(ReadLine());
            int[] arr1D = new int[n];

            WriteLine("Enter the elements of a one-dimensional array:");
            for (int i = 0; i < n; i++)
            {
                Write($"Element [{i}]: ");
                arr1D[i] = int.Parse(ReadLine());
            }

            Write("\nEnter the lower limit of the interval (A): ");
            int minVal = int.Parse(ReadLine());
            Write("Enter the upper limit of the interval (B): ");
            int maxVal = int.Parse(ReadLine());

            WriteLine("\n1D array after replacement:");
            for (int i = 0; i < n; i++)
            {
                if (arr1D[i] >= minVal && arr1D[i] <= maxVal)
                {
                    arr1D[i] = 0;
                }
                Write(arr1D[i] + "\t");
            }
            WriteLine("\n");

            Write("Enter the number of rows in the 2D array: ");
            int rows = int.Parse(ReadLine());
            Write("Enter the number of columns in the 2D array: ");
            int cols = int.Parse(ReadLine());
            int[,] arr2D = new int[rows, cols];

            WriteLine("Enter the elements of a two-dimensional array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Write($"Element [{i},{j}]: ");
                    arr2D[i, j] = int.Parse(ReadLine());
                }
            }

            WriteLine($"\n2D array after replacement (range from {minVal} to {maxVal}):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr2D[i, j] >= minVal && arr2D[i, j] <= maxVal)
                    {
                        arr2D[i, j] = 0;
                    }
                    Write(arr2D[i, j] + "\t");
                }
                WriteLine();
            }
        }

        static void Task2()
        {
            WriteLine("\n--- Task 2 is being performed ---");

            Write("Enter the array dimension: ");
            int n = int.Parse(ReadLine());
            int[] arr = new int[n];

            WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                Write($"Element [{i}]: ");
                arr[i] = int.Parse(ReadLine());
            }

            int maxElement = arr.Max();
            WriteLine($"\nMaximum element in an array: {maxElement}");

            WriteLine("Array after replacement:");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == maxElement)
                {
                    arr[i] = 0;
                }
                Write(arr[i] + "\t");
            }
            WriteLine();
        }

        static void Task3()
        {
            WriteLine("\n--- Task 3 is being performed ---");

            Write("Enter the dimension of the square matrix (n): ");
            int n = int.Parse(ReadLine());

            int[,] matrix = new int[n, n];

            WriteLine("\nEnter the elements of the matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(ReadLine());
                }
            }

            WriteLine("\nYour matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Write(matrix[i, j] + "\t");
                }
                WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, (n - 1) - i];
            }

            WriteLine($"\nSum of elements on the secondary diagonal: {sum}");
        }

        static void Task4()
        {
            WriteLine("\n--- Task 4 is being performed ---");

            Write("Enter the number of rows in the stepped array (n): ");
            int n = int.Parse(ReadLine());
            int[][] jaggedArray = new int[n][];
            int[] positiveCounts = new int[n];
            WriteLine();

            for (int i = 0; i < n; i++)
            {
                Write($"Enter the number of elements in the row {i} (m): ");
                int m = int.Parse(ReadLine());
                jaggedArray[i] = new int[m];
                int count = 0;
                for (int j = 0; j < m; j++)
                {
                    Write($"Element [{i}][{j}]: ");
                    jaggedArray[i][j] = int.Parse(ReadLine());

                    if (jaggedArray[i][j] > 0)
                    {
                        count++;
                    }
                }
                positiveCounts[i] = count;
                WriteLine();
            }

            WriteLine("Your stepped array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Write(jaggedArray[i][j] + "\t");
                }
                WriteLine();
            }

            WriteLine("\nA new array with the number of positive elements for each row:");
            for (int i = 0; i < n; i++)
            {
                WriteLine($"Row {i}: {positiveCounts[i]} positive elements");
            }
        }
    }
}