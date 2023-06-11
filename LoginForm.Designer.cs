namespace GS25ManagementApp
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_newid = new System.Windows.Forms.Button();
            this.TB_PN = new System.Windows.Forms.TextBox();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_log.Location = new System.Drawing.Point(56, 582);
            this.btn_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(120, 54);
            this.btn_log.TabIndex = 0;
            this.btn_log.Text = "로그인";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_newid
            // 
            this.btn_newid.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_newid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_newid.Location = new System.Drawing.Point(243, 579);
            this.btn_newid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_newid.Name = "btn_newid";
            this.btn_newid.Size = new System.Drawing.Size(120, 62);
            this.btn_newid.TabIndex = 1;
            this.btn_newid.Text = "회원가입";
            this.btn_newid.UseVisualStyleBackColor = false;
            this.btn_newid.Click += new System.EventHandler(this.btn_newid_Click);
            // 
            // TB_PN
            // 
            this.TB_PN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PN.Location = new System.Drawing.Point(56, 454);
            this.TB_PN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_PN.Name = "TB_PN";
            this.TB_PN.Size = new System.Drawing.Size(246, 24);
            this.TB_PN.TabIndex = 2;
            // 
            // TB_PW
            // 
            this.TB_PW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PW.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PW.Location = new System.Drawing.Point(60, 525);
            this.TB_PW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.PasswordChar = '*';
            this.TB_PW.Size = new System.Drawing.Size(246, 24);
            this.TB_PW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(106, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호를 잊어버리셧나요? ->";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(51, 482);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 2);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(56, 552);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 2);
            this.panel2.TabIndex = 7;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.phoneNumber.Location = new System.Drawing.Point(51, 423);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(204, 28);
            this.phoneNumber.TabIndex = 8;
            this.phoneNumber.Text = "User Phone Number";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.password.Location = new System.Drawing.Point(56, 494);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 28);
            this.password.TabIndex = 9;
            this.password.Text = "password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GS25ManagementApp.Properties.Resources.GS25;
            this.pictureBox1.Location = new System.Drawing.Point(51, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "근무 도우미";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(429, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_PW);
            this.Controls.Add(this.TB_PN);
            this.Controls.Add(this.btn_newid);
            this.Controls.Add(this.btn_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_newid;
        private System.Windows.Forms.TextBox TB_PN;
        private System.Windows.Forms.TextBox TB_PW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

