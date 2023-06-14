namespace HeThongQuanLyTTHV.QLTKB
{
    partial class RJTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDigit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDigit
            // 
            this.textBoxDigit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDigit.Location = new System.Drawing.Point(7, 7);
            this.textBoxDigit.Name = "textBoxDigit";
            this.textBoxDigit.Size = new System.Drawing.Size(119, 15);
            this.textBoxDigit.TabIndex = 0;
            this.textBoxDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDigit_KeyPress);
            // 
            // RJTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBoxDigit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "RJTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(133, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDigit;
    }
}
