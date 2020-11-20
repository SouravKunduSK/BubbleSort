using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, temp = 0, n;
            
            //define array_size;
            Console.WriteLine("Enter the size of array:");
            n = int.Parse(Console.ReadLine());

            //declaring array;
            int[] arr = new int[n];

            //inserting array elements;
            Console.WriteLine("Enter the" + $" {n} " + "elements:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //sorting the array;
            for(j = 0; j < arr.Length-2; j++)
            {
                for(i = 0; i <= arr.Length-2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting the array is:");
             for(i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
