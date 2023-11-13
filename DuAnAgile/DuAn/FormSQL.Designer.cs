namespace DuAn
{
    partial class FormSQL
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
            label10 = new Label();
            dtpNgaySinh = new DateTimePicker();
            CboGioiTinh = new ComboBox();
            txtDiemTB = new TextBox();
            txtDiemDuAn = new TextBox();
            txtDiemTiengAnh = new TextBox();
            txtDiemIT = new TextBox();
            txtEmail = new TextBox();
            txtLop = new TextBox();
            txtTenSv = new TextBox();
            txtMaSv = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvDanhSach = new ListView();
            MaSV = new ColumnHeader();
            TenSV = new ColumnHeader();
            NgaySinh = new ColumnHeader();
            GioiTinh = new ColumnHeader();
            Email = new ColumnHeader();
            Lop = new ColumnHeader();
            DiemIT = new ColumnHeader();
            DiemTiengAnh = new ColumnHeader();
            DiemDuAn = new ColumnHeader();
            DiemTB = new ColumnHeader();
            btnSua = new Button();
            btnthem = new Button();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(479, 395);
            label10.Name = "label10";
            label10.Size = new Size(73, 25);
            label10.TabIndex = 47;
            label10.Text = "DiemTB";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(124, 280);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(247, 31);
            dtpNgaySinh.TabIndex = 46;
            // 
            // CboGioiTinh
            // 
            CboGioiTinh.FormattingEnabled = true;
            CboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            CboGioiTinh.Location = new Point(124, 334);
            CboGioiTinh.Name = "CboGioiTinh";
            CboGioiTinh.Size = new Size(247, 33);
            CboGioiTinh.TabIndex = 45;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(623, 395);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(271, 31);
            txtDiemTB.TabIndex = 43;
            txtDiemTB.TextChanged += txtDiemTB_TextChanged;
            // 
            // txtDiemDuAn
            // 
            txtDiemDuAn.Location = new Point(623, 337);
            txtDiemDuAn.Name = "txtDiemDuAn";
            txtDiemDuAn.Size = new Size(271, 31);
            txtDiemDuAn.TabIndex = 42;
            // 
            // txtDiemTiengAnh
            // 
            txtDiemTiengAnh.Location = new Point(623, 280);
            txtDiemTiengAnh.Name = "txtDiemTiengAnh";
            txtDiemTiengAnh.Size = new Size(271, 31);
            txtDiemTiengAnh.TabIndex = 41;
            // 
            // txtDiemIT
            // 
            txtDiemIT.Location = new Point(623, 232);
            txtDiemIT.Name = "txtDiemIT";
            txtDiemIT.Size = new Size(271, 31);
            txtDiemIT.TabIndex = 40;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 387);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 31);
            txtEmail.TabIndex = 39;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(623, 185);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(271, 31);
            txtLop.TabIndex = 38;
            // 
            // txtTenSv
            // 
            txtTenSv.Location = new Point(124, 232);
            txtTenSv.Name = "txtTenSv";
            txtTenSv.Size = new Size(247, 31);
            txtTenSv.TabIndex = 44;
            // 
            // txtMaSv
            // 
            txtMaSv.Location = new Point(124, 185);
            txtMaSv.Name = "txtMaSv";
            txtMaSv.Size = new Size(247, 31);
            txtMaSv.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(479, 337);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 35;
            label9.Text = "DiemDuAn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(479, 286);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 34;
            label8.Text = "DiemTiengAnh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(479, 238);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 33;
            label7.Text = "DiemIT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 188);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 32;
            label6.Text = "Lop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 384);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 31;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 334);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 30;
            label4.Text = "GioiTinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 283);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 29;
            label3.Text = "NgaySInh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 238);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 36;
            label2.Text = "TenSV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 188);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 28;
            label1.Text = "MaSV";
            // 
            // lvDanhSach
            // 
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { MaSV, TenSV, NgaySinh, GioiTinh, Email, Lop, DiemIT, DiemTiengAnh, DiemDuAn, DiemTB });
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.Location = new Point(0, 2);
            lvDanhSach.Margin = new Padding(4);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(1153, 171);
            lvDanhSach.TabIndex = 25;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            lvDanhSach.SelectedIndexChanged += lvDanhSach_SelectedIndexChanged;
            // 
            // MaSV
            // 
            MaSV.Text = "MaSV";
            MaSV.Width = 100;
            // 
            // TenSV
            // 
            TenSV.Text = "TenSV";
            TenSV.Width = 150;
            // 
            // NgaySinh
            // 
            NgaySinh.Text = "NgaySinh";
            NgaySinh.Width = 150;
            // 
            // GioiTinh
            // 
            GioiTinh.Text = "GioiTinh";
            GioiTinh.Width = 100;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 100;
            // 
            // Lop
            // 
            Lop.Text = "Lop";
            Lop.Width = 100;
            // 
            // DiemIT
            // 
            DiemIT.Text = "DiemIT";
            DiemIT.Width = 100;
            // 
            // DiemTiengAnh
            // 
            DiemTiengAnh.Text = "DiemTiengAnh";
            DiemTiengAnh.Width = 150;
            // 
            // DiemDuAn
            // 
            DiemDuAn.Text = "DiemDuAn";
            DiemDuAn.Width = 100;
            // 
            // DiemTB
            // 
            DiemTB.Text = "DiemTB";
            DiemTB.Width = 100;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(175, 454);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(136, 58);
            btnSua.TabIndex = 27;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(14, 454);
            btnthem.Margin = new Padding(4);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(136, 58);
            btnthem.TabIndex = 26;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click_1;
            // 
            // FormSQL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 591);
            Controls.Add(label10);
            Controls.Add(dtpNgaySinh);
            Controls.Add(CboGioiTinh);
            Controls.Add(txtDiemTB);
            Controls.Add(txtDiemDuAn);
            Controls.Add(txtDiemTiengAnh);
            Controls.Add(txtDiemIT);
            Controls.Add(txtEmail);
            Controls.Add(txtLop);
            Controls.Add(txtTenSv);
            Controls.Add(txtMaSv);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvDanhSach);
            Controls.Add(btnSua);
            Controls.Add(btnthem);
            Name = "FormSQL";
            Text = "FormSQL";
            Load += FormSQL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DateTimePicker dtpNgaySinh;
        private ComboBox CboGioiTinh;
        private TextBox txtDiemTB;
        private TextBox txtDiemDuAn;
        private TextBox txtDiemTiengAnh;
        private TextBox txtDiemIT;
        private TextBox txtEmail;
        private TextBox txtLop;
        private TextBox txtTenSv;
        private TextBox txtMaSv;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvDanhSach;
        private ColumnHeader MaSV;
        private ColumnHeader TenSV;
        private ColumnHeader NgaySinh;
        private ColumnHeader GioiTinh;
        private ColumnHeader Email;
        private ColumnHeader Lop;
        private ColumnHeader DiemIT;
        private ColumnHeader DiemTiengAnh;
        private ColumnHeader DiemDuAn;
        private ColumnHeader DiemTB;
        private Button btnSua;
        private Button btnthem;
    }
}