using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Interval
{
    public static void Main(string[] args)
    {
        var res = 0;
        int numberOfIntervals = int.Parse(Console.ReadLine()!);
        List<(int,int)> intervals = new();
        for (int interval = 0; interval < numberOfIntervals; interval++)
        {
            var line = Console.ReadLine()!;
            var split = line.Split(" ");
            var start = int.Parse(split[0]);
            var end = int.Parse(split[1]);
            intervals.Add((start,end)); 
        }
        intervals = intervals.OrderBy(interval => interval.Item2).ToList();
        var endTime = 0;
        for (int i = 0; i < intervals.Count; i++)
        {
         if (intervals[i].Item1 >= endTime )
            {
                res++;
                endTime = intervals[i].Item2;
            }   
        }
        Console.WriteLine(res);
    }
}