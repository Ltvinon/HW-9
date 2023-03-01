// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HW_9
{
    using System.Diagnostics;

    internal class Program
    {
        private static void Main(string[] args)
        {
            RecursiveMethod();
        }

        private static void RecursiveMethod()
        {
            var thread = new Thread(RecursiveMethod);
            thread.IsBackground = true;
            thread.Start();
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}, Total Threads: {Process.GetCurrentProcess().Threads.Count}");
            thread.Join();
        }
    }
}