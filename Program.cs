using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista aktualnie uruchomionych procesów:");

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    Console.WriteLine($"ID: {process.Id} | Nazwa: {process.ProcessName} | Pamięć: {process.PrivateMemorySize64 / 1024} KB");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Nie można uzyskać informacji o procesie: {ex.Message}");
                }
            }

        }
    }
}
