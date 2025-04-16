using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task1_B
{
    // v1
    //public class ReadOnlySqlFiles : ILoadText
    public class ReadOnlySqlFiles : myFile

    {
        #region v1
        //public string FilePath { get; set; }
        //public string FileText { get; set; } 
        #endregion
        public override string LoadText()
        {
            /* Code to read text from sql file */
            return $"Content of file {FilePath}";
        }
    }
}
