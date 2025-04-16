using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Developer : ITaskWorker
    {
        public string Name { get; set; }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.  
            Console.WriteLine($"{Name} is working on the task.");
        }
    }
}
