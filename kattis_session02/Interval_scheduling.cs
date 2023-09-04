using System;
using System.Collections.Generic;
internal class Interval
{
    private static void Intervals(string[] args)
    {
        int numberOfIntervals = int.Parse(Console.ReadLine()!);
        List<(int,int)> intervals = new();
        List<(int,int)> A = new();
        for (int interval = 0; interval < numberOfIntervals; interval++)
        {
            var line = Console.ReadLine()!;
            var split = line.Split(" ");
            var start = int.Parse(split[0]);
            var end = int.Parse(split[1]);
            intervals.Add((start,end));
        }
        while(intervals.Count > 0){
            // Find interval with shortest finish time
            (int,int) interval = (0,0);
            int shortestFinish = int.MaxValue;
            foreach (var r in intervals)
            {
                if(r.Item2 < shortestFinish){
                    interval = r;
                    shortestFinish = r.Item2;
                }

            }
            // Add interval to A
            A.Add(interval);
            // Remove Interval from R
            intervals.Remove(interval);
            // Remove incompatible intervals from R
            var toBeRemoved = new List<(int,int)>();
            foreach (var r in intervals)
            {
                if(r.Item1 < interval.Item2) toBeRemoved.Add(r);
            }
            foreach (var i in toBeRemoved)
            {
                intervals.Remove(i);
            }
        }
        Console.WriteLine(A.Count);
    }
}