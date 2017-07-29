namespace Vocabulary
{
    partial class frminfo
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
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(7, 12);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(244, 237);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(92, 255);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(69, 23);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort word";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(167, 255);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Find word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frminfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.rtbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frminfo";
            this.Text = "All words";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frminfo_FormClosed);
            this.Load += new System.EventHandler(this.frminfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
    }
}