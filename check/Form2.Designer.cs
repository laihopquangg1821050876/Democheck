namespace check
{
    partial class Form2
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
            this.saves = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Coment = new System.Windows.Forms.TextBox();
            this.Closes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saves
            // 
            this.saves.BackColor = System.Drawing.Color.Cyan;
            this.saves.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saves.Location = new System.Drawing.Point(16, 44);
            this.saves.Name = "saves";
            this.saves.Size = new System.Drawing.Size(96, 32);
            this.saves.TabIndex = 0;
            this.saves.Text = "Lưu";
            this.saves.UseVisualStyleBackColor = false;
            this.saves.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "comment";
            // 
            // Coment
            // 
            this.Coment.Location = new System.Drawing.Point(87, 8);
            this.Coment.Name = "Coment";
            this.Coment.Size = new System.Drawing.Size(139, 20);
            this.Coment.TabIndex = 2;
            // 
            // Closes
            // 
            this.Closes.BackColor = System.Drawing.Color.Red;
            this.Closes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closes.Location = new System.Drawing.Point(130, 44);
            this.Closes.Name = "Closes";
            this.Closes.Size = new System.Drawing.Size(96, 32);
            this.Closes.TabIndex = 3;
            this.Closes.Text = "Đóng ";
            this.Closes.UseVisualStyleBackColor = false;
            this.Closes.Click += new System.EventHandler(this.Closes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(242, 96);
            this.Controls.Add(this.Closes);
            this.Controls.Add(this.Coment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saves);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Coment;
        private System.Windows.Forms.Button Closes;
    }
}