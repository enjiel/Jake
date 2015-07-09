using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    class cmdExec {
        public static void newCMD(string cmd, string input)
        {
            Form1.cmd.input = input;
            Form1.cmd.cmd = cmd;
        }

        public static void runCMD()
        {
            string input = Form1.cmd.input;
            string cmd = Form1.cmd.cmd;
            Form1.cmdToUI.imageOutput = "false";
            switch (cmd)
            {
                case "GO":
                    String Go = GO.direction(input);
                    GO.goTo(Go);
                    break;
                case "LOOK":
                    /*EAT*/
                    break;
                case "EAT":
                    /*EAT*/
                    break;
                case "TAKE":
                    /*TAKE*/
                    break;
                case "USE":
                    /*USE*/
                    break;
                case "TALK":
                    /*TALK*/
                    break;
                case "FIGHT":
                    /*FIGHT*/
                    break;
                case "CAST":
                    /*CAST*/
                    break;
                case "HELP":
                    HELP.help();
                    break;
                case "QUIT":
                    System.Windows.Forms.Application.Exit();
                    break;
                default:
                    Form1.cmdToUI.textOutput = "That is not a valid command";
                    break;
            }
        }
    }
}
