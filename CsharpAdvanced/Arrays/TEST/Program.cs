using System;

class FindMostFriquetNumber
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxCount = int.MinValue;
        int currentCount = 1;
        int number = 0;
        for (int index = 0; index < n; index++)
        {

            arr[index] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}