using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace Dot_Net_Code_Tips
{
    /// <summary>
    /// Read a csv file with fields that have embedded commas.
    /// </summary>
    class Read_a_csv_file
    {
        public string Process()
        {
            var rc = "";

            using (var inputFile = new StreamReader("Sample.csv"))
            {
                string line = inputFile.ReadLine();

                var parser = new TextFieldParser(new StringReader(line))
                {
                    HasFieldsEnclosedInQuotes = true
                };

                parser.SetDelimiters(",");

                var dataArray = new string[] { };

                while (!parser.EndOfData)
                    dataArray = parser.ReadFields();

                parser.Close();

                rc = dataArray[0];
            }
            return rc;
        }
    }
}
