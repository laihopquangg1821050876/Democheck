namespace check
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
            this.Run = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Acc = new System.Windows.Forms.Label();
            this.IDpost = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.TextBox();
            this.txtIdBaiViet = new System.Windows.Forms.TextBox();
            this.Ketqua = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Run.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.Location = new System.Drawing.Point(277, 75);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(113, 30);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Acc
            // 
            this.Acc.AutoSize = true;
            this.Acc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Acc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc.Location = new System.Drawing.Point(37, 29);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(77, 17);
            this.Acc.TabIndex = 3;
            this.Acc.Text = "Tài khoản ";
            // 
            // IDpost
            // 
            this.IDpost.AutoSize = true;
            this.IDpost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDpost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDpost.Location = new System.Drawing.Point(37, 64);
            this.IDpost.Name = "IDpost";
            this.IDpost.Size = new System.Drawing.Size(60, 17);
            this.IDpost.TabIndex = 4;
            this.IDpost.Text = "bài viết ";
            this.IDpost.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(414, 64);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(61, 17);
            this.result.TabIndex = 5;
            this.result.Text = "kết quả ";
            this.result.Click += new System.EventHandler(this.label3_Click);
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(125, 29);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(301, 20);
            this.Account.TabIndex = 6;
            // 
            // txtIdBaiViet
            // 
            this.txtIdBaiViet.Location = new System.Drawing.Point(103, 64);
            this.txtIdBaiViet.Multiline = true;
            this.txtIdBaiViet.Name = "txtIdBaiViet";
            this.txtIdBaiViet.Size = new System.Drawing.Size(158, 115);
            this.txtIdBaiViet.TabIndex = 7;
            this.txtIdBaiViet.TextChanged += new System.EventHandler(this.txtIdBaiViet_TextChanged);
            // 
            // Ketqua
            // 
            this.Ketqua.Location = new System.Drawing.Point(481, 64);
            this.Ketqua.Multiline = true;
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(158, 115);
            this.Ketqua.TabIndex = 8;
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.Color.Yellow;
            this.Comment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(277, 111);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(113, 30);
            this.Comment.TabIndex = 9;
            this.Comment.Text = "Comment";
            this.Comment.UseVisualStyleBackColor = false;
            this.Comment.Click += new System.EventHandler(this.Comment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(659, 220);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.txtIdBaiViet);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.result);
            this.Controls.Add(this.IDpost);
            this.Controls.Add(this.Acc);
            this.Controls.Add(this.Run);
            this.Name = "Form1";
            this.Text = "checkid";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label Acc;
        private System.Windows.Forms.Label IDpost;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.TextBox txtIdBaiViet;
        private System.Windows.Forms.TextBox Ketqua;
        private System.Windows.Forms.Button Comment;
    }
}

