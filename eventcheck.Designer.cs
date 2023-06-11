namespace GS25ManagementApp
{
    partial class eventcheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter1Plus1 = new System.Windows.Forms.Button();
            this.btnFilter2Plus1 = new System.Windows.Forms.Button();
            this.btnFilterCardPromotion = new System.Windows.Forms.Button();
            this.btnFilterFreeGift = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewEvent = new System.Windows.Forms.ListView();
            this.상품명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.바코드번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.행사기간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.프로모션 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_back);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 42);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(539, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 5);
            this.panel2.TabIndex = 11;
            // 
            // Btn_back
            // 
            this.Btn_back.BackColor = System.Drawing.SystemColors.InfoText;
            this.Btn_back.Image = global::GS25ManagementApp.Properties.Resources.뒤로가기;
            this.Btn_back.Location = new System.Drawing.Point(8, 7);
            this.Btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(38, 29);
            this.Btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_back.TabIndex = 2;
            this.Btn_back.TabStop = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "<6월 행사>";
            // 
            // btnFilter1Plus1
            // 
            this.btnFilter1Plus1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFilter1Plus1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter1Plus1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter1Plus1.Location = new System.Drawing.Point(396, 90);
            this.btnFilter1Plus1.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter1Plus1.Name = "btnFilter1Plus1";
            this.btnFilter1Plus1.Size = new System.Drawing.Size(94, 40);
            this.btnFilter1Plus1.TabIndex = 6;
            this.btnFilter1Plus1.Text = "1+1";
            this.btnFilter1Plus1.UseVisualStyleBackColor = false;
            this.btnFilter1Plus1.Click += new System.EventHandler(this.btnFilter1Plus1_Click);
            // 
            // btnFilter2Plus1
            // 
            this.btnFilter2Plus1.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFilter2Plus1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter2Plus1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter2Plus1.Location = new System.Drawing.Point(494, 90);
            this.btnFilter2Plus1.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter2Plus1.Name = "btnFilter2Plus1";
            this.btnFilter2Plus1.Size = new System.Drawing.Size(92, 40);
            this.btnFilter2Plus1.TabIndex = 7;
            this.btnFilter2Plus1.Text = "2+1";
            this.btnFilter2Plus1.UseVisualStyleBackColor = false;
            this.btnFilter2Plus1.Click += new System.EventHandler(this.btnFilter2Plus1_Click);
            // 
            // btnFilterCardPromotion
            // 
            this.btnFilterCardPromotion.BackColor = System.Drawing.Color.Lime;
            this.btnFilterCardPromotion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterCardPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterCardPromotion.Location = new System.Drawing.Point(590, 90);
            this.btnFilterCardPromotion.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterCardPromotion.Name = "btnFilterCardPromotion";
            this.btnFilterCardPromotion.Size = new System.Drawing.Size(98, 40);
            this.btnFilterCardPromotion.TabIndex = 8;
            this.btnFilterCardPromotion.Text = "카드행사";
            this.btnFilterCardPromotion.UseVisualStyleBackColor = false;
            this.btnFilterCardPromotion.Click += new System.EventHandler(this.btnFilterCardPromotion_Click);
            // 
            // btnFilterFreeGift
            // 
            this.btnFilterFreeGift.BackColor = System.Drawing.Color.Gold;
            this.btnFilterFreeGift.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterFreeGift.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterFreeGift.Location = new System.Drawing.Point(693, 90);
            this.btnFilterFreeGift.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterFreeGift.Name = "btnFilterFreeGift";
            this.btnFilterFreeGift.Size = new System.Drawing.Size(97, 40);
            this.btnFilterFreeGift.TabIndex = 9;
            this.btnFilterFreeGift.Text = "덤증정";
            this.btnFilterFreeGift.UseVisualStyleBackColor = false;
            this.btnFilterFreeGift.Click += new System.EventHandler(this.btnFilterFreeGift_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(163, 91);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(143, 35);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "상품명 : \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(324, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "검색\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewEvent
            // 
            this.listViewEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.상품명,
            this.바코드번호,
            this.행사기간,
            this.가격,
            this.프로모션});
            this.listViewEvent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEvent.HideSelection = false;
            this.listViewEvent.Location = new System.Drawing.Point(57, 142);
            this.listViewEvent.Margin = new System.Windows.Forms.Padding(2);
            this.listViewEvent.Name = "listViewEvent";
            this.listViewEvent.Scrollable = false;
            this.listViewEvent.Size = new System.Drawing.Size(734, 224);
            this.listViewEvent.TabIndex = 13;
            this.listViewEvent.UseCompatibleStateImageBehavior = false;
            this.listViewEvent.View = System.Windows.Forms.View.Details;
            this.listViewEvent.SelectedIndexChanged += new System.EventHandler(this.listViewEvent_SelectedIndexChanged);
            // 
            // 상품명
            // 
            this.상품명.Text = "상품명";
            this.상품명.Width = 100;
            // 
            // 바코드번호
            // 
            this.바코드번호.Text = "바코드번호";
            this.바코드번호.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.바코드번호.Width = 160;
            // 
            // 행사기간
            // 
            this.행사기간.Text = "행사기간";
            this.행사기간.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.행사기간.Width = 150;
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            this.가격.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.가격.Width = 180;
            // 
            // 프로모션
            // 
            this.프로모션.Text = "프로모션";
            this.프로모션.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.프로모션.Width = 140;
            // 
            // eventcheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(840, 400);
            this.Controls.Add(this.listViewEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFilterFreeGift);
            this.Controls.Add(this.btnFilterCardPromotion);
            this.Controls.Add(this.btnFilter2Plus1);
            this.Controls.Add(this.btnFilter1Plus1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "eventcheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eventcheck";
            this.Load += new System.EventHandler(this.eventcheck_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter1Plus1;
        private System.Windows.Forms.Button btnFilter2Plus1;
        private System.Windows.Forms.Button btnFilterCardPromotion;
        private System.Windows.Forms.Button btnFilterFreeGift;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewEvent;
        private System.Windows.Forms.ColumnHeader 상품명;
        private System.Windows.Forms.ColumnHeader 바코드번호;
        private System.Windows.Forms.ColumnHeader 행사기간;
        private System.Windows.Forms.ColumnHeader 가격;
        private System.Windows.Forms.ColumnHeader 프로모션;
    }
}