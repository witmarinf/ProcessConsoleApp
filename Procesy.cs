using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessConsoleApp
{
    class Procesy
    {
        public int Id { get; set; }

        public string ProcessName { get; set; }

        public int PrivateMemorySize64 { get; set; }
    
        public Procesy(int id, string processName, int privateMemorySize64)
        {
            Id = id;
            ProcessName = processName;
            PrivateMemorySize64 = privateMemorySize64;
        }
    }




}
