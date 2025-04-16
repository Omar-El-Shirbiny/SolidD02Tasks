using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task1_B
{
    public abstract class myFile : ILoadText
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public abstract string LoadText();


    }
}
