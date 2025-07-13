namespace White_Ch8._2
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.AvgWordBtn = new System.Windows.Forms.Button();
            this.CharLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AvgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(316, 136);
            this.UserInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(228, 20);
            this.UserInput.TabIndex = 0;
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(193, 331);
            this.RunBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(137, 55);
            this.RunBtn.TabIndex = 1;
            this.RunBtn.Text = "Count Words";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Title.Location = new System.Drawing.Point(272, 28);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(367, 25);
            this.Title.TabIndex = 3;
            this.Title.Text = "WELCOME TO THE WORD COUNTER";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(571, 330);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(158, 56);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ResultLbl.Location = new System.Drawing.Point(356, 179);
            this.ResultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(18, 20);
            this.ResultLbl.TabIndex = 5;
            this.ResultLbl.Text = "#";
            // 
            // AvgWordBtn
            // 
            this.AvgWordBtn.Location = new System.Drawing.Point(384, 330);
            this.AvgWordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvgWordBtn.Name = "AvgWordBtn";
            this.AvgWordBtn.Size = new System.Drawing.Size(138, 56);
            this.AvgWordBtn.TabIndex = 6;
            this.AvgWordBtn.Text = "Find Average";
            this.AvgWordBtn.UseVisualStyleBackColor = true;
            // 
            // CharLbl
            // 
            this.CharLbl.AutoSize = true;
            this.CharLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CharLbl.Location = new System.Drawing.Point(356, 225);
            this.CharLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharLbl.Name = "CharLbl";
            this.CharLbl.Size = new System.Drawing.Size(18, 20);
            this.CharLbl.TabIndex = 7;
            this.CharLbl.Text = "#";
          //  this.CharLbl.Click += new System.EventHandler(this.CharLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(140, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Characters: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(140, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Words:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(140, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Avg Per Word: ";
            // 
            // AvgLbl
            // 
            this.AvgLbl.AutoSize = true;
            this.AvgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AvgLbl.Location = new System.Drawing.Point(356, 266);
            this.AvgLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvgLbl.Name = "AvgLbl";
            this.AvgLbl.Size = new System.Drawing.Size(18, 20);
            this.AvgLbl.TabIndex = 11;
            this.AvgLbl.Text = "#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 477);
            this.Controls.Add(this.AvgLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharLbl);
            this.Controls.Add(this.AvgWordBtn);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.UserInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button AvgWordBtn;
        private System.Windows.Forms.Label CharLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AvgLbl;
    }
}

