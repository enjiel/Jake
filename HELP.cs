using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jake
{
    class HELP
    {
        public static void help()
        {
            string fileName = (@".\Jake\Resources\help.txt");
            StringBuilder sbHelp = new StringBuilder();
            using (StreamReader helpReader = new StreamReader(fileName))
            {
                while (helpReader.Peek() >= 0)
                {
                    sbHelp.Append(helpReader.ReadLine() + Environment.NewLine);
                }
            }
            Form1.cmdToUI.textOutput = sbHelp.ToString();
        }
    }
}
