using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vactination_DB_Manager
{
    internal class TextExport
    {
        private string ColumnSeparator = "|";
        private string RowSeparator = "\n";
        private string resultString = "";
        private bool append = false;
        private int ajusting = 0;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="columnSeparator">роздільник стовбців</param>
        /// <param name="rowSeparator">роздільник колонок</param>
        /// <param name="append">режим дозапису</param>
        /// <param name="ajusting">вирівнювання</param>
        public TextExport(string columnSeparator, string rowSeparator, bool append, int ajusting)
        {
            ColumnSeparator = columnSeparator;
            RowSeparator = rowSeparator;
            this.append = append;
            this.ajusting = ajusting;
        }

        /// <summary>
        /// констуктор
        /// </summary>
        /// <param name="append">режим дозапису</param>
        /// <param name="ajusting">вирівнювання</param>
        public TextExport(bool append, int ajusting)
        {
            this.append = append;
            this.ajusting = ajusting;
        }

        /// <summary>
        /// додавання роздільника між значеннями
        /// </summary>
        /// <param name="newLine"></param>
        /// <returns></returns>
        private string PrepareInputString(string[] newLine)
        {
            string outStr = "";
            for (int i = 0; i < newLine.Length; i++)
            {
                string ajust = newLine[i];
                for(int j = ajust.Length; j < ajusting; j++)
                {
                    ajust += " ";
                }
                outStr += ajust + ColumnSeparator;
            }
            return outStr;
        }


        public void AddNewLine(string[] newLine)
        {
            resultString = PrepareInputString(newLine);
        }

        /// <summary>
        /// запис всього файлу
        /// </summary>
        /// <param name="fileName"></param>
        public void Export(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(resultString);
                writer.Close();
            }
        }

        /// <summary>
        /// дозапис по рядкам
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="newLine"></param>
        public void ExportByLine(string fileName, string[] newLine)
        {
            using (StreamWriter writer = new StreamWriter(fileName, append: append))
            {
                writer.WriteLine(PrepareInputString(newLine));
                writer.Close();
            }
        }

    }
}
