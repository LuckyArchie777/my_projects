using System;

    using System.Timers;
using MyTimer = System.Timers.Timer;
var timer = new MyTimer();
{
timer.Elapsed += (object? _, ElapsedEventArgs e) =>
Console.WriteLine($"{e.SignalTime}");
    Console.Clear();
timer.Interval = 1000;
timer.Enabled = true;
Console.ReadLine();
    }