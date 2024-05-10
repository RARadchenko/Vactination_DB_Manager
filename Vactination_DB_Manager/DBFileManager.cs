using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Vactination_DB_Manager
{
    class DBFileManager
    {
        private string FileName = "";
        private string[] fileLines = { };
        public int LinesCount { get; set; }

        public DBFileManager(string FileName) 
        {
            this.FileName = FileName;
        }
        public DBFileManager(){}

        public void setFileName(string FileName) { this.FileName = FileName;}

        public string getFileName() { return this.FileName;}

        /// <summary>
        /// зчитування файлу як рядка
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// прочитати весь файл як масив
        /// </summary>
        /// <returns></returns>
        public string[] readDBFileLikeArrayOfLines()
        {
            try
            {
                fileLines = File.ReadAllLines(FileName);
                LinesCount = fileLines.Length;
                return fileLines;
            }
            catch (Exception e)
            {
                return fileLines;
            }
        }

        /// <summary>
        /// метод що повертає рядок з файлу
        /// </summary>
        /// <param name="index">номер рядку</param>
        /// <returns></returns>
        public string getOneLine(int index)
        {
            if (index < fileLines.Length) return fileLines[index];
            else return "Error file haven`t than line";
        }

        /// <summary>
        /// парсер рядків
        /// </summary>
        /// <param name="oneline"></param>
        /// <returns></returns>
        public string[] splitLine(string oneline) 
        {
            
            string pattern = @",(?=(?:[^\""]*\""[^\""]*\"")*(?![^\""]*\""))";
            string[] parts = Regex.Split(oneline, pattern);
            return parts;
        }

    }
}
