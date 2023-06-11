namespace GS25ManagementApp
{
    partial class MainForm
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
            this.Btn_Pos = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Work = new System.Windows.Forms.Button();
            this.Btn_notice = new System.Windows.Forms.Button();
            this.btn_timecheck = new System.Windows.Forms.Button();
            this.btn_eventcheck = new System.Windows.Forms.Button();
            this.btn_leavetimecheck = new System.Windows.Forms.Button();
            this.Btn_calcu = new System.Windows.Forms.Button();
            this.Btn_info = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.worktime_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.start_work_label = new System.Windows.Forms.Label();
            this.rank_label = new System.Windows.Forms.Label();
            this.rank22_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.labelWeather);
            this.panel1.Controls.Add(this.Btn_Pos);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 60);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Pos
            // 
            this.Btn_Pos.BackColor = System.Drawing.Color.Navy;
            this.Btn_Pos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Pos.Location = new System.Drawing.Point(71, 13);
            this.Btn_Pos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Pos.Name = "Btn_Pos";
            this.Btn_Pos.Size = new System.Drawing.Size(76, 37);
            this.Btn_Pos.TabIndex = 11;
            this.Btn_Pos.Text = "POS 모드";
            this.Btn_Pos.UseVisualStyleBackColor = false;
            this.Btn_Pos.Click += new System.EventHandler(this.Btn_Pos_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(606, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "ver 1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GS25ManagementApp.Properties.Resources.GS25;
            this.pictureBox1.Location = new System.Drawing.Point(712, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Exit.Image = global::GS25ManagementApp.Properties.Resources.전원__2_;
            this.Btn_Exit.Location = new System.Drawing.Point(18, 13);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(39, 37);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Work
            // 
            this.Btn_Work.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Work.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Work.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Work.Location = new System.Drawing.Point(16, 73);
            this.Btn_Work.Name = "Btn_Work";
            this.Btn_Work.Size = new System.Drawing.Size(191, 189);
            this.Btn_Work.TabIndex = 1;
            this.Btn_Work.Text = "근무\r\n사항";
            this.Btn_Work.UseVisualStyleBackColor = false;
            this.Btn_Work.Click += new System.EventHandler(this.Btn_Work_Click);
            // 
            // Btn_notice
            // 
            this.Btn_notice.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_notice.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_notice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_notice.Location = new System.Drawing.Point(224, 73);
            this.Btn_notice.Name = "Btn_notice";
            this.Btn_notice.Size = new System.Drawing.Size(191, 189);
            this.Btn_notice.TabIndex = 2;
            this.Btn_notice.Text = "전달\r\n사항";
            this.Btn_notice.UseVisualStyleBackColor = false;
            this.Btn_notice.Click += new System.EventHandler(this.Btn_notice_Click);
            // 
            // btn_timecheck
            // 
            this.btn_timecheck.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_timecheck.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timecheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_timecheck.Location = new System.Drawing.Point(431, 73);
            this.btn_timecheck.Name = "btn_timecheck";
            this.btn_timecheck.Size = new System.Drawing.Size(191, 189);
            this.btn_timecheck.TabIndex = 3;
            this.btn_timecheck.Text = "근무자\r\n시간표";
            this.btn_timecheck.UseVisualStyleBackColor = false;
            this.btn_timecheck.Click += new System.EventHandler(this.btn_timecheck_Click);
            // 
            // btn_eventcheck
            // 
            this.btn_eventcheck.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eventcheck.Location = new System.Drawing.Point(16, 291);
            this.btn_eventcheck.Name = "btn_eventcheck";
            this.btn_eventcheck.Size = new System.Drawing.Size(135, 73);
            this.btn_eventcheck.TabIndex = 4;
            this.btn_eventcheck.Text = "행사확인";
            this.btn_eventcheck.UseVisualStyleBackColor = true;
            this.btn_eventcheck.Click += new System.EventHandler(this.btn_eventcheck_Click);
            // 
            // btn_leavetimecheck
            // 
            this.btn_leavetimecheck.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leavetimecheck.Location = new System.Drawing.Point(169, 291);
            this.btn_leavetimecheck.Name = "btn_leavetimecheck";
            this.btn_leavetimecheck.Size = new System.Drawing.Size(135, 73);
            this.btn_leavetimecheck.TabIndex = 5;
            this.btn_leavetimecheck.Text = "유통기한";
            this.btn_leavetimecheck.UseVisualStyleBackColor = true;
            this.btn_leavetimecheck.Click += new System.EventHandler(this.btn_leavetimecheck_Click);
            // 
            // Btn_calcu
            // 
            this.Btn_calcu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_calcu.Location = new System.Drawing.Point(325, 291);
            this.Btn_calcu.Name = "Btn_calcu";
            this.Btn_calcu.Size = new System.Drawing.Size(135, 73);
            this.Btn_calcu.TabIndex = 6;
            this.Btn_calcu.Text = "급여계산";
            this.Btn_calcu.UseVisualStyleBackColor = true;
            this.Btn_calcu.Click += new System.EventHandler(this.Btn_calcu_Click);
            // 
            // Btn_info
            // 
            this.Btn_info.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_info.Location = new System.Drawing.Point(487, 291);
            this.Btn_info.Name = "Btn_info";
            this.Btn_info.Size = new System.Drawing.Size(135, 73);
            this.Btn_info.TabIndex = 7;
            this.Btn_info.Text = "정보 관리";
            this.Btn_info.UseVisualStyleBackColor = true;
            this.Btn_info.Click += new System.EventHandler(this.Btn_info_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.worktime_label);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.start_work_label);
            this.panel2.Controls.Add(this.rank_label);
            this.panel2.Controls.Add(this.rank22_label);
            this.panel2.Controls.Add(this.Name_label);
            this.panel2.Location = new System.Drawing.Point(641, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 343);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(0, 199);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "환영합니다!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // worktime_label
            // 
            this.worktime_label.AutoSize = true;
            this.worktime_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worktime_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.worktime_label.Location = new System.Drawing.Point(49, 307);
            this.worktime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.worktime_label.Name = "worktime_label";
            this.worktime_label.Size = new System.Drawing.Size(55, 23);
            this.worktime_label.TabIndex = 5;
            this.worktime_label.Text = "근무자";
            this.worktime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::GS25ManagementApp.Properties.Resources.스토어매니저;
            this.pictureBox2.Location = new System.Drawing.Point(45, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // start_work_label
            // 
            this.start_work_label.AutoSize = true;
            this.start_work_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_work_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.start_work_label.Location = new System.Drawing.Point(1, 247);
            this.start_work_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start_work_label.Name = "start_work_label";
            this.start_work_label.Size = new System.Drawing.Size(104, 19);
            this.start_work_label.TabIndex = 3;
            this.start_work_label.Text = "2xxx-xx-xx 입사";
            this.start_work_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rank_label
            // 
            this.rank_label.AutoSize = true;
            this.rank_label.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank_label.Location = new System.Drawing.Point(27, 270);
            this.rank_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rank_label.Name = "rank_label";
            this.rank_label.Size = new System.Drawing.Size(172, 36);
            this.rank_label.TabIndex = 2;
            this.rank_label.Text = "스토어 매니저";
            this.rank_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rank22_label
            // 
            this.rank22_label.AutoSize = true;
            this.rank22_label.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank22_label.Location = new System.Drawing.Point(54, 209);
            this.rank22_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rank22_label.Name = "rank22_label";
            this.rank22_label.Size = new System.Drawing.Size(103, 36);
            this.rank22_label.TabIndex = 1;
            this.rank22_label.Text = "🔽직급";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(55, 135);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(47, 26);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "\"\"님";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelWeather.Location = new System.Drawing.Point(367, 8);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(83, 23);
            this.labelWeather.TabIndex = 12;
            this.labelWeather.Text = "날씨 : 맑음";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(840, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_info);
            this.Controls.Add(this.Btn_calcu);
            this.Controls.Add(this.btn_leavetimecheck);
            this.Controls.Add(this.btn_eventcheck);
            this.Controls.Add(this.btn_timecheck);
            this.Controls.Add(this.Btn_notice);
            this.Controls.Add(this.Btn_Work);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Work;
        private System.Windows.Forms.Button Btn_notice;
        private System.Windows.Forms.Button btn_timecheck;
        private System.Windows.Forms.Button btn_eventcheck;
        private System.Windows.Forms.Button btn_leavetimecheck;
        private System.Windows.Forms.Button Btn_calcu;
        private System.Windows.Forms.Button Btn_info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label start_work_label;
        private System.Windows.Forms.Label rank_label;
        private System.Windows.Forms.Label rank22_label;
        private System.Windows.Forms.Label worktime_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Pos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelWeather;
    }
}