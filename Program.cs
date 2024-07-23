using System;

class Program
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                // Swap elements
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] numbers = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        SelectionSort(numbers);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }
}