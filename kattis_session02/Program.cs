using System;
using System.Collections;
using System.Collections.Generic;
internal class Program
{
    private static void Mains(string[] args)
    {
        int size =int.Parse(Console.ReadLine());
        long[] items = new long[size];
        string[] line = Console.ReadLine().Split(" ");
        for (int i = 0; i < size-1; i++)
        {
            items[i] = int.Parse(line[i]);
        } 
        Array.Sort(items);
        Array.Reverse(items);
        //items.OrderBy(item => item).Reverse();
        long res = 0;
        for (int x = 0; x < size; x++)
            if (x % 3 == 2)
                res += items[x];
        Console.WriteLine(res);
    }
}