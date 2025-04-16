using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class MyTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public void AssignTo(ITaskWorker worker)
        {
            //Code to assign task to a worker
            Console.WriteLine($"Task '{Title}' assigned to {worker.GetType().Name}");
        }
        public void MarkAsCompleted()
        {
            IsCompleted = true;
            Console.WriteLine($"Task '{Title}' marked as completed.");
        }
    }
}
