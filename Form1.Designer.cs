namespace Jake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.launchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(163, 433);
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(401, 20);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.CausesValidation = false;
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(163, 303);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(401, 124);
            this.outputBox.TabIndex = 1;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(163, 24);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(401, 273);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // launchBtn
            // 
            this.launchBtn.Location = new System.Drawing.Point(609, 116);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(75, 23);
            this.launchBtn.TabIndex = 3;
            this.launchBtn.Text = "Launch";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 534);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button launchBtn;
    }
}


