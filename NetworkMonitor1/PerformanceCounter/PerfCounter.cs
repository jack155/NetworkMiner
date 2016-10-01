using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceCounter
{
    public class PerfCounter
    {
        protected System.Diagnostics.PerformanceCounter cpuCounter; 
        protected System.Diagnostics.PerformanceCounter ramCounter;

        public PerfCounter()
        {
            cpuCounter = new System.Diagnostics.PerformanceCounter();

            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            ramCounter = new System.Diagnostics.PerformanceCounter("Memory", "Available MBytes"); 
        }

        public string getCurrentCpuUsage(){ 
            return cpuCounter.NextValue()+"%"; 
        } 
 
        public string getAvailableRAM(){
            return ramCounter.NextValue() + "Mb"; 
        }
    }
}
