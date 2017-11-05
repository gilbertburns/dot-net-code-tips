using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Code_Tips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dot Net Code Tips Sample Code");
            Console.WriteLine("");

            // Tip: Read a csv file with embedded commas
            var tipReadCsv = new Read_a_csv_file();
            Console.WriteLine(tipReadCsv.Process());


            // End program
            Console.WriteLine("Press ENTER to exit.");
            var pause = Console.ReadLine();
        }
    }
}
