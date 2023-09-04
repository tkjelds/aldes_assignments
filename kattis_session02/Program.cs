using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
internal class Program
{
    private static void Main(string[] args)
    {
        var res = 0;
        int numberOfItems = int.Parse(Console.ReadLine()!);
        List<int> items = new List<int>();
        var line = Console.ReadLine();
        var Itemstring = line.Split(" ");
        for (int i = 0; i < numberOfItems; i++)
        {
            items.Add(int.Parse(Itemstring[i]));
        }
        items.Sort();
        var amountOfDiscounts = Math.Abs(numberOfItems/3);
        var discountIndex = numberOfItems-3;
        while(amountOfDiscounts > 0){
            res += items[discountIndex];
            discountIndex -= 3;
            amountOfDiscounts --;
        }
        Console.WriteLine(res);
    }
}