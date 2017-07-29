namespace Vocabulary
{
    partial class frmStart
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.cmbTimePerWord = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llbAuthor = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add word";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(105, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 70);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(11, 50);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(77, 32);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // cmbTimePerWord
            // 
            this.cmbTimePerWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimePerWord.FormattingEnabled = true;
            this.cmbTimePerWord.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "10",
            "15"});
            this.cmbTimePerWord.Location = new System.Drawing.Point(39, 20);
            this.cmbTimePerWord.Name = "cmbTimePerWord";
            this.cmbTimePerWord.Size = new System.Drawing.Size(88, 21);
            this.cmbTimePerWord.TabIndex = 3;
            this.cmbTimePerWord.SelectedIndexChanged += new System.EventHandler(this.cmbTimePerWord_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "seconds";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTimePerWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time per 1 word";
            // 
            // llbAuthor
            // 
            this.llbAuthor.AutoSize = true;
            this.llbAuthor.Location = new System.Drawing.Point(89, 141);
            this.llbAuthor.Name = "llbAuthor";
            this.llbAuthor.Size = new System.Drawing.Size(143, 13);
            this.llbAuthor.TabIndex = 6;
            this.llbAuthor.TabStop = true;
            this.llbAuthor.Text = "Trong Nghia - February 2017";
            this.llbAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAuthor_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version 0.0.1 by";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llbAuthor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.Text = "Vocabulary Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStart_FormClosed);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.ComboBox cmbTimePerWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llbAuthor;
        private System.Windows.Forms.Label label2;
    }
}

