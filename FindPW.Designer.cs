namespace GS25ManagementApp
{
    partial class FindPW
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
            this.newwork_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_PN = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newwork_label
            // 
            this.newwork_label.AutoSize = true;
            this.newwork_label.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newwork_label.Location = new System.Drawing.Point(59, 18);
            this.newwork_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newwork_label.Name = "newwork_label";
            this.newwork_label.Size = new System.Drawing.Size(153, 27);
            this.newwork_label.TabIndex = 3;
            this.newwork_label.Text = "<비밀번호 찾기>";
            this.newwork_label.Click += new System.EventHandler(this.newwork_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(34, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "휴대폰 번호를 입력하세요\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(34, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 38;
            // 
            // TB_PN
            // 
            this.TB_PN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PN.Location = new System.Drawing.Point(37, 137);
            this.TB_PN.Name = "TB_PN";
            this.TB_PN.Size = new System.Drawing.Size(172, 16);
            this.TB_PN.TabIndex = 37;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.phoneNumber.Location = new System.Drawing.Point(34, 66);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(99, 18);
            this.phoneNumber.TabIndex = 36;
            this.phoneNumber.Text = "이름을 입력하세요";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(34, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 1);
            this.panel1.TabIndex = 35;
            // 
            // TB_Name
            // 
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(37, 87);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(172, 16);
            this.TB_Name.TabIndex = 34;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Find.Location = new System.Drawing.Point(88, 175);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(96, 36);
            this.btn_Find.TabIndex = 40;
            this.btn_Find.Text = "비밀번호 찾기";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // FindPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(283, 234);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TB_PN);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.newwork_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindPW";
            this.Load += new System.EventHandler(this.FindPW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newwork_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_PN;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button btn_Find;
    }
}