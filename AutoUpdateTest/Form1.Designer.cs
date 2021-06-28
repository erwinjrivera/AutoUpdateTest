
namespace AutoUpdateTest
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
            this.vers = new System.Windows.Forms.Label();
            this.cmdArgs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vers
            // 
            this.vers.AutoSize = true;
            this.vers.Location = new System.Drawing.Point(330, 220);
            this.vers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(35, 13);
            this.vers.TabIndex = 5;
            this.vers.Text = "label2";
            // 
            // cmdArgs
            // 
            this.cmdArgs.AutoSize = true;
            this.cmdArgs.Location = new System.Drawing.Point(330, 236);
            this.cmdArgs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cmdArgs.Name = "cmdArgs";
            this.cmdArgs.Size = new System.Drawing.Size(35, 13);
            this.cmdArgs.TabIndex = 4;
            this.cmdArgs.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello World!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vers);
            this.Controls.Add(this.cmdArgs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vers;
        private System.Windows.Forms.Label cmdArgs;
        private System.Windows.Forms.Label label1;
    }
}

