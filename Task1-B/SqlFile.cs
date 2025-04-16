using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_B;

namespace Task2
{
    // v1
    //public class SqlFile : ISaveText,ILoadText
    public class SqlFile : myFile, ISaveText
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
        public string SaveText()
        {
            /* Code to save text into sql file */
            return "Sucessfully saved to sql file";
        }
    }
}
