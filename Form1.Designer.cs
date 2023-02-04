namespace TinhThue
{
    partial class TinhThue
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelBHXH = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.labelMienThueVoiNgLaoDong = new System.Windows.Forms.Label();
            this.textBoxNgLaoDong = new System.Windows.Forms.TextBox();
            this.labelMienThueVoiNgPhuThuoc = new System.Windows.Forms.Label();
            this.textBoxNgPhuThuoc = new System.Windows.Forms.TextBox();
            this.labelNgPhuThuoc = new System.Windows.Forms.Label();
            this.textBoxSoNgPhuThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelThuNhap = new System.Windows.Forms.Label();
            this.textBoxThuNhap = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonTaxThisMonth = new System.Windows.Forms.Button();
            this.buttonTaxThisYear = new System.Windows.Forms.Button();
            this.labelTinhThueThang = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelThongBaoUpdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin cá nhân:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(12, 47);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(49, 20);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "Năm:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 112);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Họ và tên:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(16, 135);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(417, 30);
            this.textBoxName.TabIndex = 4;
            // 
            // labelBHXH
            // 
            this.labelBHXH.AutoSize = true;
            this.labelBHXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBHXH.Location = new System.Drawing.Point(13, 180);
            this.labelBHXH.Name = "labelBHXH";
            this.labelBHXH.Size = new System.Drawing.Size(134, 20);
            this.labelBHXH.TabIndex = 5;
            this.labelBHXH.Text = "Bảo hiểm xã hội:";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.Location = new System.Drawing.Point(17, 204);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(51, 24);
            this.radioButtonYes.TabIndex = 6;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Có";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.Location = new System.Drawing.Point(87, 203);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(77, 24);
            this.radioButtonNo.TabIndex = 7;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Không";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // labelMienThueVoiNgLaoDong
            // 
            this.labelMienThueVoiNgLaoDong.AutoSize = true;
            this.labelMienThueVoiNgLaoDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMienThueVoiNgLaoDong.Location = new System.Drawing.Point(13, 237);
            this.labelMienThueVoiNgLaoDong.Name = "labelMienThueVoiNgLaoDong";
            this.labelMienThueVoiNgLaoDong.Size = new System.Drawing.Size(324, 20);
            this.labelMienThueVoiNgLaoDong.TabIndex = 8;
            this.labelMienThueVoiNgLaoDong.Text = "Hạn mức miễn trừ thuế với người lao động:";
            // 
            // textBoxNgLaoDong
            // 
            this.textBoxNgLaoDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgLaoDong.Location = new System.Drawing.Point(17, 260);
            this.textBoxNgLaoDong.Name = "textBoxNgLaoDong";
            this.textBoxNgLaoDong.Size = new System.Drawing.Size(416, 30);
            this.textBoxNgLaoDong.TabIndex = 9;
            this.textBoxNgLaoDong.TextChanged += new System.EventHandler(this.textBoxNgLaoDong_TextChanged);
            // 
            // labelMienThueVoiNgPhuThuoc
            // 
            this.labelMienThueVoiNgPhuThuoc.AutoSize = true;
            this.labelMienThueVoiNgPhuThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMienThueVoiNgPhuThuoc.Location = new System.Drawing.Point(12, 303);
            this.labelMienThueVoiNgPhuThuoc.Name = "labelMienThueVoiNgPhuThuoc";
            this.labelMienThueVoiNgPhuThuoc.Size = new System.Drawing.Size(334, 20);
            this.labelMienThueVoiNgPhuThuoc.TabIndex = 10;
            this.labelMienThueVoiNgPhuThuoc.Text = "Hạn mức miễn trừ thuế với người phụ thuộc:";
            // 
            // textBoxNgPhuThuoc
            // 
            this.textBoxNgPhuThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgPhuThuoc.Location = new System.Drawing.Point(16, 326);
            this.textBoxNgPhuThuoc.Name = "textBoxNgPhuThuoc";
            this.textBoxNgPhuThuoc.Size = new System.Drawing.Size(416, 30);
            this.textBoxNgPhuThuoc.TabIndex = 11;
            this.textBoxNgPhuThuoc.TextChanged += new System.EventHandler(this.textBoxNgPhuThuoc_TextChanged);
            // 
            // labelNgPhuThuoc
            // 
            this.labelNgPhuThuoc.AutoSize = true;
            this.labelNgPhuThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgPhuThuoc.Location = new System.Drawing.Point(13, 369);
            this.labelNgPhuThuoc.Name = "labelNgPhuThuoc";
            this.labelNgPhuThuoc.Size = new System.Drawing.Size(157, 20);
            this.labelNgPhuThuoc.TabIndex = 12;
            this.labelNgPhuThuoc.Text = "Số người phụ thuộc:";
            // 
            // textBoxSoNgPhuThuoc
            // 
            this.textBoxSoNgPhuThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoNgPhuThuoc.Location = new System.Drawing.Point(16, 392);
            this.textBoxSoNgPhuThuoc.Name = "textBoxSoNgPhuThuoc";
            this.textBoxSoNgPhuThuoc.Size = new System.Drawing.Size(416, 30);
            this.textBoxSoNgPhuThuoc.TabIndex = 13;
            this.textBoxSoNgPhuThuoc.TextChanged += new System.EventHandler(this.textBoxSoNgPhuThuoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thu nhập cá nhân:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(480, 47);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(60, 20);
            this.labelMonth.TabIndex = 15;
            this.labelMonth.Text = "Tháng:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(484, 70);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(148, 30);
            this.comboBoxMonth.TabIndex = 17;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            this.comboBoxMonth.SelectedValueChanged += new System.EventHandler(this.comboBoxMonth_SelectedValueChanged);
            // 
            // labelThuNhap
            // 
            this.labelThuNhap.AutoSize = true;
            this.labelThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThuNhap.Location = new System.Drawing.Point(669, 47);
            this.labelThuNhap.Name = "labelThuNhap";
            this.labelThuNhap.Size = new System.Drawing.Size(83, 20);
            this.labelThuNhap.TabIndex = 18;
            this.labelThuNhap.Text = "Thu nhập:";
            // 
            // textBoxThuNhap
            // 
            this.textBoxThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThuNhap.Location = new System.Drawing.Point(673, 70);
            this.textBoxThuNhap.Name = "textBoxThuNhap";
            this.textBoxThuNhap.Size = new System.Drawing.Size(188, 30);
            this.textBoxThuNhap.TabIndex = 19;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(835, 120);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 65);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Cập nhật";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonTaxThisMonth
            // 
            this.buttonTaxThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaxThisMonth.Location = new System.Drawing.Point(568, 342);
            this.buttonTaxThisMonth.Name = "buttonTaxThisMonth";
            this.buttonTaxThisMonth.Size = new System.Drawing.Size(293, 37);
            this.buttonTaxThisMonth.TabIndex = 21;
            this.buttonTaxThisMonth.Text = "Tính thuế TNCN của tháng";
            this.buttonTaxThisMonth.UseVisualStyleBackColor = true;
            this.buttonTaxThisMonth.Click += new System.EventHandler(this.buttonTaxThisMonth_Click);
            // 
            // buttonTaxThisYear
            // 
            this.buttonTaxThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaxThisYear.Location = new System.Drawing.Point(568, 385);
            this.buttonTaxThisYear.Name = "buttonTaxThisYear";
            this.buttonTaxThisYear.Size = new System.Drawing.Size(293, 37);
            this.buttonTaxThisYear.TabIndex = 22;
            this.buttonTaxThisYear.Text = "Tính thuế TNCN cả năm";
            this.buttonTaxThisYear.UseVisualStyleBackColor = true;
            this.buttonTaxThisYear.Click += new System.EventHandler(this.buttonTaxThisYear_Click);
            // 
            // labelTinhThueThang
            // 
            this.labelTinhThueThang.AutoSize = true;
            this.labelTinhThueThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTinhThueThang.Location = new System.Drawing.Point(480, 194);
            this.labelTinhThueThang.Name = "labelTinhThueThang";
            this.labelTinhThueThang.Size = new System.Drawing.Size(0, 25);
            this.labelTinhThueThang.TabIndex = 23;
            this.labelTinhThueThang.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 75);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
            // 
            // labelThongBaoUpdate
            // 
            this.labelThongBaoUpdate.AutoSize = true;
            this.labelThongBaoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBaoUpdate.Location = new System.Drawing.Point(481, 120);
            this.labelThongBaoUpdate.Name = "labelThongBaoUpdate";
            this.labelThongBaoUpdate.Size = new System.Drawing.Size(0, 20);
            this.labelThongBaoUpdate.TabIndex = 25;
            this.labelThongBaoUpdate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(868, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "(triệu đồng)";
            // 
            // TinhThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelThongBaoUpdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTinhThueThang);
            this.Controls.Add(this.buttonTaxThisYear);
            this.Controls.Add(this.buttonTaxThisMonth);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxThuNhap);
            this.Controls.Add(this.labelThuNhap);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSoNgPhuThuoc);
            this.Controls.Add(this.labelNgPhuThuoc);
            this.Controls.Add(this.textBoxNgPhuThuoc);
            this.Controls.Add(this.labelMienThueVoiNgPhuThuoc);
            this.Controls.Add(this.textBoxNgLaoDong);
            this.Controls.Add(this.labelMienThueVoiNgLaoDong);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.labelBHXH);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.label1);
            this.Name = "TinhThue";
            this.Text = "Chương Trình Tính Thuế TNCN";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelBHXH;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Label labelMienThueVoiNgLaoDong;
        private System.Windows.Forms.TextBox textBoxNgLaoDong;
        private System.Windows.Forms.Label labelMienThueVoiNgPhuThuoc;
        private System.Windows.Forms.TextBox textBoxNgPhuThuoc;
        private System.Windows.Forms.Label labelNgPhuThuoc;
        private System.Windows.Forms.TextBox textBoxSoNgPhuThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMonth;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button buttonTaxThisYear;
        private System.Windows.Forms.Button buttonTaxThisMonth;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxThuNhap;
        private System.Windows.Forms.Label labelThuNhap;
        private System.Windows.Forms.Label labelTinhThueThang;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelThongBaoUpdate;
    }
}

