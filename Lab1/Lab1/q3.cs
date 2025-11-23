using System;

namespace q3{ 
class ReverseArray
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nOriginal array:");
        PrintArray(numbers);

        // Reverse the array
        Reverse(numbers);

        Console.WriteLine("\nReversed array:");
        PrintArray(numbers);
    }

    static void Reverse(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            start++;
            end--;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        
    }
}
}
