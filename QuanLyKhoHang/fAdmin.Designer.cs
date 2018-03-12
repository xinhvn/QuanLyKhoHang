namespace QuanLyKhoHang
{
    partial class fAdmin
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
            this.tcGioiThieu = new System.Windows.Forms.TabControl();
            this.tcTaiKhoan = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataAdmin = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tcGioiThieu.SuspendLayout();
            this.tcTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdmin)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcGioiThieu
            // 
            this.tcGioiThieu.Controls.Add(this.tcTaiKhoan);
            this.tcGioiThieu.Controls.Add(this.tabPage2);
            this.tcGioiThieu.Location = new System.Drawing.Point(12, 12);
            this.tcGioiThieu.Name = "tcGioiThieu";
            this.tcGioiThieu.SelectedIndex = 0;
            this.tcGioiThieu.Size = new System.Drawing.Size(512, 329);
            this.tcGioiThieu.TabIndex = 0;
            this.tcGioiThieu.Tag = "";
            // 
            // tcTaiKhoan
            // 
            this.tcTaiKhoan.Controls.Add(this.btnExit);
            this.tcTaiKhoan.Controls.Add(this.dataAdmin);
            this.tcTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tcTaiKhoan.Name = "tcTaiKhoan";
            this.tcTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tcTaiKhoan.Size = new System.Drawing.Size(504, 303);
            this.tcTaiKhoan.TabIndex = 0;
            this.tcTaiKhoan.Text = "Tài Khoản";
            this.tcTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(416, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataAdmin
            // 
            this.dataAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdmin.Location = new System.Drawing.Point(6, 6);
            this.dataAdmin.Name = "dataAdmin";
            this.dataAdmin.Size = new System.Drawing.Size(485, 239);
            this.dataAdmin.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThoat);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giới Thiệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Word";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(394, 254);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 350);
            this.Controls.Add(this.tcGioiThieu);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.tcGioiThieu.ResumeLayout(false);
            this.tcTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAdmin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcGioiThieu;
        private System.Windows.Forms.TabPage tcTaiKhoan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}