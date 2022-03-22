using System;
using System.Diagnostics;
using System.Threading;

namespace JetEngine
{
    class Program
    {
        static PerformanceCounter cpu = new PerformanceCounter(
            "Processor", "% Processor Time", "_Total");
        static PerformanceCounter memory = new PerformanceCounter(
            "Memory", "% Committed Bytes in Use");

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("CPU: {0:n2}%,Memory: {1:n2}%", cpu.NextValue(), memory.NextValue());
                Thread.Sleep(1000);
            }
        }
    }
}
