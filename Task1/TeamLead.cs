using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TeamLead : ITaskAssigner,ITaskWorker,ISubTaskCreator
    {
        public void AssginTask()
        {
            // create a task
            MyTask t = new MyTask() { Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop" };

            //Code to assign a task. 
            t.AssignTo(new Developer() { Name = "Developer1" });
        }
        public void CreateSubTask()
        {
            //Code to create a sub task  
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.  
        }
    }
}
