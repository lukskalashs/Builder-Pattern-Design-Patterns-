
namespace Computers
{
    partial class CfrmMain
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
            this.lstBxComputers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBxComputers
            // 
            this.lstBxComputers.FormattingEnabled = true;
            this.lstBxComputers.Location = new System.Drawing.Point(13, 23);
            this.lstBxComputers.Name = "lstBxComputers";
            this.lstBxComputers.Size = new System.Drawing.Size(345, 407);
            this.lstBxComputers.TabIndex = 0;
            this.lstBxComputers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBxComputers_MouseDoubleClick);
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.lstBxComputers);
            this.Name = "CfrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxComputers;
    }
}

