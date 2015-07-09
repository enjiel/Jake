using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Jake
{
    public class CMD
    {
        public string input { get; set; }
        public string cmd { get; set; }

        public CMD(string input, string output)
        {
            this.input = input;
            this.cmd = cmd;
        }
    }
}
