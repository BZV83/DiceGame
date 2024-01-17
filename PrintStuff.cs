using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreC_Fun
{
    internal class PrintStuff
    {
        private string lang;

        public PrintStuff()
        {
            lang = "EN";
        }

        public PrintStuff(string temp)
        {
            lang = temp;
        }
        public void PrintName(string fName)
        {
            if (lang == "EN")
            {
                System.Console.WriteLine("Hello, " + fName);
            }

            if (lang == "TAG")
            {
                System.Console.WriteLine("Kumusta, " + fName);
            }
        }
    }
}
