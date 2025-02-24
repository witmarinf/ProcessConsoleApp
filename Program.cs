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
            List<Procesy> procList = new List<Procesy>();

            foreach (Process process in processes)
            {
                try
                {
                    //Console.WriteLine($"ID: {process.Id} | Nazwa: {process.ProcessName} | Pamięć: {process.PrivateMemorySize64 / 1024} KB");

                    procList.Add(new Procesy(process.Id, process.ProcessName, (int)process.PrivateMemorySize64));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Nie można uzyskać informacji o procesie: {ex.Message}");
                }
            }

            foreach (Procesy item in procList) 
            {
                Console.WriteLine($"{item.Id} | {item.ProcessName} | {item.PrivateMemorySize64/1024} KB");
            }

            List<Procesy> dataProc = procList;

            var listOrderById = dataProc.OrderBy(x => x.Id);

            foreach (Procesy item in listOrderById)
            {
                Console.WriteLine($"{item.Id} | {item.ProcessName} | {item.PrivateMemorySize64 / 1024} KB");
            }

        }
    }
}
