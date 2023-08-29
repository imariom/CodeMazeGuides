﻿using System.Diagnostics;

namespace StopWatchCSharp;
public class StopWatchMethods
{     
    public Stopwatch CreateRandomArray(int size)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        var array = new int[size];

        for (int i = 0; i < size; i++)
            array[i] = Random.Shared.Next();

        stopWatch.Stop();

        return stopWatch;
    }
}