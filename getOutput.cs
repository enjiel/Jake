using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    public class getOutput
    {
        public string textOutput { get; set; }
        public string imageOutput { get; set; }

        public getOutput(string textOutput, string imageOutput)
        {
            this.textOutput = textOutput;
            this.imageOutput = imageOutput;
        }
    }
}
