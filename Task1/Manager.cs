using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Manager : ITaskAssigner
    {
        public void AssginTask()
        {
            // create a task
            MyTask t = new MyTask() { Title = "Team lead Task", Description="................." };
            //Code to assign a task. 
            t.AssignTo(new TeamLead());
        }
    }
}
