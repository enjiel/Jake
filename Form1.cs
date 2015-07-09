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
        public static Areas Loc = new Areas("Intro", "Welcome!  Press START to begin.", "", "", "", "", "", "", "");
        public static CMD cmd = new CMD("","");
        public static getOutput cmdToUI = new getOutput("","");
        public Form1()
        {
            InitializeComponent();  //Load the interface
            Bitmap areaImage = new Bitmap(@".\Jake\Resources\" + Loc.areaName + ".png");         
            imageBox.Image = areaImage;
            outputBox.Text += Loc.areaText;
                //The "Enter" key takes commands
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(doCMD);
        }
            //Process input from inputBox using the "Enter" key
        private void doCMD(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                if (this.inputBox.Text != "") {
                    char delimiterChar = ' ';
                    String text = this.inputBox.Text;
                    text = text.ToUpper();
                    string[] textStr = text.Split(delimiterChar);
                    String cmdStr = textStr[0];
                    String inputStr = "";
                    for (int i = 1; i < textStr.Length; i++)
                    {
                        inputStr = inputStr + " " + textStr[i];
                    }
                    cmdExec.newCMD(cmdStr, inputStr);
                    cmdExec.runCMD();
                    inputBox.Text = "";
                    outputBox.AppendText(Environment.NewLine + cmdToUI.textOutput);
                    string loadImage = cmdToUI.imageOutput;
                    if (loadImage == "true") {
                    Bitmap areaImage = new Bitmap(@".\Jake\Resources\" + Loc.areaName + ".png");
                    imageBox.Image = areaImage;
                    }
                    }
                }
            }

            //This must be active to release the text box and hide the "Launch" button
        private void launchBtn_Click(object sender, EventArgs e)
        {
            MoveLoc.area0();
            Bitmap areaImage = new Bitmap(@".\Jake\Resources\" + Loc.areaName + ".png");
            imageBox.Image = areaImage;
            outputBox.Text = Loc.areaText;
            this.inputBox.ReadOnly = false;
            this.launchBtn.Visible = false;
            this.launchBtn.Enabled = false;
        }
    }
}
