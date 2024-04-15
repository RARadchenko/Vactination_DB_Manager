using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vactination_DB_Manager
{
    internal class TxtExport
    {
        private string ColumnSeparator = "|";
        private string RowSeparator = "\n";
        private int startElement = 0;
        private int endElement = 0;
        private string resultString = "";

        public TxtExport(string columnSeparator, string rowSeparator, int startElement, int endElement)
        {
            ColumnSeparator = columnSeparator;
            RowSeparator = rowSeparator;
            if (startElement < endElement)
            {
                this.startElement = startElement;
                this.endElement = endElement;
            }
            else
            {
                throw new ArgumentException("startElement must be less than endElement");
            }
        }

        public TxtExport(int startElement, int endElement)
        {
            if (startElement < endElement)
            {
                this.startElement = startElement;
                this.endElement = endElement;
            }
            else
            {
                throw new ArgumentException("startElement must be less than endElement");
            }
        }

        private string PrepareInputString(string[] newLine)
        {
            string outStr = "";
            for (int i = 0; i < newLine.Length; i++)
            {
                string ajust = newLine[i];
                for(int j = ajust.Length; j < 40; j++)
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

        public void Export(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine();
                writer.Close();
            }
        }

        public void ExportByLine(string fileName, string[] newLine)
        {
            using (StreamWriter writer = new StreamWriter(fileName, append: true))
            {
                writer.WriteLine(PrepareInputString(newLine));
                writer.Close();
            }
        }

    }
}
