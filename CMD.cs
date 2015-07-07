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
    class CMD
    {
        public static void cmdExec(string command, string input) {
            switch (command)
            {
                case "GO":
                    String Go = direction(input);
                    goTo(Go);
                    break;
                case "EAT":
                    command = "eat";
                    break;
                case "TAKE":
                    command = "take";
                    break;
                case "USE":
                    command = "go";
                    break;
                case "TALK":
                    command = "eat";
                    break;
                case "FIGHT":
                    command = "take";
                    break;
                case "HELP":
                    command = "help";
                    break;
            }
        }

        private static void goTo(string input)
        {
            switch (input)
            { 
                case "AREA0":
                    Move.area0();
                    break;
                case "AREA1":
                    Move.area1();
                    break;
            }
        }

        private static String direction(string input)
        {
            string output = "output unscathed";
            MessageBox.Show("input at direction method: " + input);
            switch (input)
            {
                case "UP":
                    MessageBox.Show("UP case called: ");
                    output = Form1.Loc.areaUp;
                    MessageBox.Show("Form1 output: " + output);
                    break;
                case "DOWN":
                    output = Form1.Loc.areaDown;
                    break;
            }
            MessageBox.Show("Output returned: " + output);
            return output;
        }
            
    }
}
