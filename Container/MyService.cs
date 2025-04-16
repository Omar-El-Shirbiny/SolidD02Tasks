using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_B;
using Task2;

namespace Container
{
    public class MyService : IMyService
    {
        private SqlFileManager sqlFileManager;
        public MyService(SqlFileManager sqlFileManager) 
        {
            this.sqlFileManager = sqlFileManager;
            //this.sqlFileManager = sqlFileManager ?? new SqlFileManager();
        }
        public void Run()
        {
            Console.WriteLine("My Service is Running");
            // Create an instance of SqlFileManager
            // Create a list of myFile objects
            List<myFile> sqlFiles = new List<myFile>
            {
                new ReadOnlySqlFiles { FilePath = "file1.sql" },
                new ReadOnlySqlFiles { FilePath = "file2.sql" }
            };
            // Assign the list to the SqlFileManager
            sqlFileManager.lstSqlFiles = sqlFiles;
            // Get text from files
            string fileContent = sqlFileManager.GetTextFromFiles();
            Console.WriteLine(fileContent);
            // Save text into files
            sqlFileManager.SaveTextIntoFiles();
        }

    }
}
