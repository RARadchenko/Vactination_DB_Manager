using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vactination_DB_Manager
{
    internal class DBFileManager
    {
        private string FileName = "";
        private string[] fileLines = { };

        DBFileManager(string FileName) 
        {
            this.FileName = FileName;
        }
        DBFileManager(){}

        public void setFileName(string FileName) { this.FileName = FileName;}

        public string getFileName() { return this.FileName;}

        public string readDBFileLikeString()
        {
            try
            {
                string content = File.ReadAllText(FileName);
                return content;
            }
            catch (Exception e)
            {
                return "Error reading file";
            }
        }

        public string[] readDBFileLikeArrayOfLines()
        {
            try
            {
                string[] fileLines = File.ReadAllLines(FileName);
                return fileLines;
            }
            catch (Exception e)
            {
                return fileLines;
            }
        }

        public string getOneLine(int index)
        {
            if (index < fileLines.Length) return fileLines[index];
            else return "Error file haven`t than line";
        }

        public string[] splitLine(string oneline) 
        {
            string[] parts = oneline.Split(';');
            return parts;
        }

    }
}
