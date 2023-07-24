using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;

            }

        }
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] arr = { 5,6,8,9,10,11,45,76,89,56 };
            Console.WriteLine("array without bubble sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr);
            stopwatch.Stop();
            Console.WriteLine("array with bubble sort");
            Print(arr);

            Console.WriteLine("array without Insertion sort");
            Print(arr);
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            InsertionSort(arr);
            stopwatch.Stop();
            Console.WriteLine("array with Insertion sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time Take for bubble sort {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.WriteLine($"ArraySize {arr.Length} Time Take for Insertion sort {stopwatch1.Elapsed.TotalMilliseconds} milliseconds");


            Console.ReadLine();
        }
    }
}
