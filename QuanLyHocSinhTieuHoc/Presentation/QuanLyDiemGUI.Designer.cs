﻿namespace QuanLyHocSinhTieuHoc.Presentation
{
    partial class QuanLyDiemGUI
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
            this.dgvdiem = new System.Windows.Forms.DataGridView();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txttv = new System.Windows.Forms.TextBox();
            this.txtnamhoc = new System.Windows.Forms.TextBox();
            this.cbhocki = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdiem
            // 
            this.dgvdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiem.Location = new System.Drawing.Point(12, 130);
            this.dgvdiem.Name = "dgvdiem";
            this.dgvdiem.Size = new System.Drawing.Size(631, 308);
            this.dgvdiem.TabIndex = 0;
            this.dgvdiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdiem_CellClick);
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(12, 55);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(145, 20);
            this.txttoan.TabIndex = 1;
            // 
            // txttv
            // 
            this.txttv.Location = new System.Drawing.Point(12, 104);
            this.txttv.Name = "txttv";
            this.txttv.Size = new System.Drawing.Size(145, 20);
            this.txttv.TabIndex = 2;
            // 
            // txtnamhoc
            // 
            this.txtnamhoc.Location = new System.Drawing.Point(225, 55);
            this.txtnamhoc.Name = "txtnamhoc";
            this.txtnamhoc.Size = new System.Drawing.Size(145, 20);
            this.txtnamhoc.TabIndex = 3;
            // 
            // cbhocki
            // 
            this.cbhocki.FormattingEnabled = true;
            this.cbhocki.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbhocki.Location = new System.Drawing.Point(225, 103);
            this.cbhocki.Name = "cbhocki";
            this.cbhocki.Size = new System.Drawing.Size(145, 21);
            this.cbhocki.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Điểm toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Điểm tiếng việt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Học kì";
            // 
            // QuanLyDiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbhocki);
            this.Controls.Add(this.txtnamhoc);
            this.Controls.Add(this.txttv);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.dgvdiem);
            this.Name = "QuanLyDiemGUI";
            this.Text = "QuanLyDiemGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdiem;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txttv;
        private System.Windows.Forms.TextBox txtnamhoc;
        private System.Windows.Forms.ComboBox cbhocki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}