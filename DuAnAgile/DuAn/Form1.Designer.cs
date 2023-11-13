namespace DuAn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDangnhap = new Button();
            lkbQuenMK = new LinkLabel();
            lkbDangKy = new LinkLabel();
            txtpassword = new TextBox();
            txtname = new TextBox();
            lbpassword = new Label();
            lbname = new Label();
            SuspendLayout();
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.ControlLight;
            btnDangnhap.Location = new Point(418, 329);
            btnDangnhap.Margin = new Padding(4);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(132, 68);
            btnDangnhap.TabIndex = 17;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click_1;
            // 
            // lkbQuenMK
            // 
            lkbQuenMK.AutoSize = true;
            lkbQuenMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lkbQuenMK.Location = new Point(247, 251);
            lkbQuenMK.Margin = new Padding(4, 0, 4, 0);
            lkbQuenMK.Name = "lkbQuenMK";
            lkbQuenMK.Size = new Size(194, 32);
            lkbQuenMK.TabIndex = 15;
            lkbQuenMK.TabStop = true;
            lkbQuenMK.Text = "Quên Mật Khẩu?";
            // 
            // lkbDangKy
            // 
            lkbDangKy.AutoSize = true;
            lkbDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lkbDangKy.Location = new Point(570, 251);
            lkbDangKy.Margin = new Padding(4, 0, 4, 0);
            lkbDangKy.Name = "lkbDangKy";
            lkbDangKy.Size = new Size(103, 32);
            lkbDangKy.TabIndex = 16;
            lkbDangKy.TabStop = true;
            lkbDangKy.Text = "Đăng Ký";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(297, 155);
            txtpassword.Margin = new Padding(4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(409, 36);
            txtpassword.TabIndex = 13;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(297, 54);
            txtname.Margin = new Padding(4);
            txtname.Name = "txtname";
            txtname.Size = new Size(409, 36);
            txtname.TabIndex = 14;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbpassword.Location = new Point(94, 159);
            lbpassword.Margin = new Padding(4, 0, 4, 0);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(115, 32);
            lbpassword.TabIndex = 11;
            lbpassword.Text = "Password";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbname.Location = new Point(94, 58);
            lbname.Margin = new Padding(4, 0, 4, 0);
            lbname.Name = "lbname";
            lbname.Size = new Size(128, 32);
            lbname.TabIndex = 12;
            lbname.Text = "UserName";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangnhap);
            Controls.Add(lkbQuenMK);
            Controls.Add(lkbDangKy);
            Controls.Add(txtpassword);
            Controls.Add(txtname);
            Controls.Add(lbpassword);
            Controls.Add(lbname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangnhap;
        private LinkLabel lkbQuenMK;
        private LinkLabel lkbDangKy;
        private TextBox txtpassword;
        private TextBox txtname;
        private Label lbpassword;
        private Label lbname;
    }
}