using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jake
{
    public partial class Form1 : Form
    {
            //Load initial values as global variable to Area (Intro Page)
        public static Areas Loc = new Areas("Intro", "Welcome!  Press Return to continue.");
        public Form1()
        {
            InitializeComponent();  //Load the interface
            Bitmap areaImage = new Bitmap(@".\Jake\Resources\" + Loc.areaName + ".png");         
            imageBox.Image = areaImage;
            outputBox.Text = Loc.areaText;
                //The "Enter" key takes commands
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(doCMD);
        }
            //Process input from inputBox using the "Enter" key
        private void doCMD(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                if (this.inputBox.Text != "") {
                    String text = this.inputBox.Text;
                    text = text.ToUpper();
                    if (text == "EXIT")
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        char delimiterChar = ' ';
                        string[] textStr = text.Split(delimiterChar);
                        String cmdStr = textStr[0];
                        String inputStr = "";

                        for (int i = 1; i < textStr.Length; i++)
                        {
                            inputStr = inputStr + " " + textStr[i];
                        }
                        CMD.cmdExec(cmdStr, inputStr);
                        Bitmap areaImage = new Bitmap(@".\Jake\Resources\" + Loc.areaName + ".png");
                        imageBox.Image = areaImage;
                        outputBox.Text = Form1.Loc.areaText;
                        inputBox.Text = "";
                    }
                }
            }
        }

            //This must be active to release the text box and hide the "Launch" button
        private void launchBtn_Click(object sender, EventArgs e)
        {
            Loc.areaName = "Area0";
            Loc.areaText = "You have entered Area0";
            Bitmap areaImage = new Bitmap(@".\Jake\Resources\" + Loc.areaName + ".png");
            imageBox.Image = areaImage;
            outputBox.Text = Loc.areaText;
            this.inputBox.ReadOnly = false;
            this.launchBtn.Visible = false;
            this.launchBtn.Enabled = false;
        }
    }
}
