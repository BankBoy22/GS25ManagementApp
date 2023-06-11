namespace GS25ManagementApp
{
    partial class infomation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_back = new System.Windows.Forms.PictureBox();
            this.TITLE_LABEL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rank_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.workstart_label = new System.Windows.Forms.Label();
            this.worktime_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.info_change_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_back);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 63);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(770, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 8);
            this.panel2.TabIndex = 11;
            // 
            // Btn_back
            // 
            this.Btn_back.BackColor = System.Drawing.SystemColors.InfoText;
            this.Btn_back.Image = global::GS25ManagementApp.Properties.Resources.뒤로가기;
            this.Btn_back.Location = new System.Drawing.Point(11, 10);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(54, 44);
            this.Btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_back.TabIndex = 2;
            this.Btn_back.TabStop = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // TITLE_LABEL
            // 
            this.TITLE_LABEL.AutoSize = true;
            this.TITLE_LABEL.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE_LABEL.Location = new System.Drawing.Point(443, 76);
            this.TITLE_LABEL.Name = "TITLE_LABEL";
            this.TITLE_LABEL.Size = new System.Drawing.Size(186, 39);
            this.TITLE_LABEL.TabIndex = 5;
            this.TITLE_LABEL.Text = "<근무자 정보>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::GS25ManagementApp.Properties.Resources.스토어매니저;
            this.pictureBox1.Location = new System.Drawing.Point(369, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(679, 164);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(95, 39);
            this.name_label.TabIndex = 7;
            this.name_label.Text = "한재훈";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "🔽직급";
            // 
            // rank_label
            // 
            this.rank_label.AutoSize = true;
            this.rank_label.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank_label.Location = new System.Drawing.Point(584, 266);
            this.rank_label.Name = "rank_label";
            this.rank_label.Size = new System.Drawing.Size(180, 39);
            this.rank_label.TabIndex = 9;
            this.rank_label.Text = "스토어 매니저";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "근무 시작일 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "근무 시간 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "휴대폰 번호 :";
            // 
            // workstart_label
            // 
            this.workstart_label.AutoSize = true;
            this.workstart_label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workstart_label.Location = new System.Drawing.Point(571, 351);
            this.workstart_label.Name = "workstart_label";
            this.workstart_label.Size = new System.Drawing.Size(102, 23);
            this.workstart_label.TabIndex = 13;
            this.workstart_label.Text = "2019-07-15";
            // 
            // worktime_label
            // 
            this.worktime_label.AutoSize = true;
            this.worktime_label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worktime_label.Location = new System.Drawing.Point(571, 399);
            this.worktime_label.Name = "worktime_label";
            this.worktime_label.Size = new System.Drawing.Size(70, 23);
            this.worktime_label.TabIndex = 14;
            this.worktime_label.Text = "주말오전";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_label.Location = new System.Drawing.Point(571, 450);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(120, 23);
            this.phoneNumber_label.TabIndex = 15;
            this.phoneNumber_label.Text = "01082006642";
            // 
            // info_change_btn
            // 
            this.info_change_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.info_change_btn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_change_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info_change_btn.Location = new System.Drawing.Point(471, 508);
            this.info_change_btn.Name = "info_change_btn";
            this.info_change_btn.Size = new System.Drawing.Size(246, 62);
            this.info_change_btn.TabIndex = 16;
            this.info_change_btn.Text = "근무자 정보 수정";
            this.info_change_btn.UseVisualStyleBackColor = false;
            this.info_change_btn.Click += new System.EventHandler(this.info_change_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "이름 :";
            // 
            // infomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info_change_btn);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.worktime_label);
            this.Controls.Add(this.workstart_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rank_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TITLE_LABEL);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "infomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "infomation";
            this.Load += new System.EventHandler(this.infomation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Btn_back;
        private System.Windows.Forms.Label TITLE_LABEL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rank_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label workstart_label;
        private System.Windows.Forms.Label worktime_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Button info_change_btn;
        private System.Windows.Forms.Label label1;
    }
}