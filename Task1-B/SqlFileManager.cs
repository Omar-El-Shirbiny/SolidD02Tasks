using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_B;

namespace Task2
{
    public class SqlFileManager
    {
        //v1
        //public List<SqlFile> lstSqlFiles { get; set; }

        public List<myFile> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in lstSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                if (objFile is ISaveText obj)
                {
                    obj.SaveText();
                }
                #region v1
                //objFile.SaveText();
                # endregion
            }
        }
    }
}
