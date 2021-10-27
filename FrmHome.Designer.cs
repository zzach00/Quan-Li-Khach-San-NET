
namespace Quan_Li_Khach_San_NET
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhTrạngPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDnahSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoPhòngĐangSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btmTimKiemThongTin = new System.Windows.Forms.Button();
            this.dataGridViewTimKiemThongTin = new System.Windows.Forms.DataGridView();
            this.cboTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTenPhong = new System.Windows.Forms.ComboBox();
            this.rbtnTenKH = new System.Windows.Forms.RadioButton();
            this.rbtnTenLoaiPhong = new System.Windows.Forms.RadioButton();
            this.rbtnMaNhanVien = new System.Windows.Forms.RadioButton();
            this.rbtnTenPhong = new System.Windows.Forms.RadioButton();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 563);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1129, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1129, 33);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.đặtPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            this.đặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.đặtPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng - Hóa đơn";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuLoaiPhong,
            this.tìnhTrạngPhòngToolStripMenuItem});
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.phòngToolStripMenuItem.Text = "Phòng";
            // 
            // stripMenuLoaiPhong
            // 
            this.stripMenuLoaiPhong.Name = "stripMenuLoaiPhong";
            this.stripMenuLoaiPhong.Size = new System.Drawing.Size(231, 30);
            this.stripMenuLoaiPhong.Text = "Loại phòng";
            this.stripMenuLoaiPhong.Click += new System.EventHandler(this.stripMenuLoaiPhong_Click);
            // 
            // tìnhTrạngPhòngToolStripMenuItem
            // 
            this.tìnhTrạngPhòngToolStripMenuItem.Name = "tìnhTrạngPhòngToolStripMenuItem";
            this.tìnhTrạngPhòngToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.tìnhTrạngPhòngToolStripMenuItem.Text = "Tình trạng phòng";
            this.tìnhTrạngPhòngToolStripMenuItem.Click += new System.EventHandler(this.tìnhTrạngPhòngToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânViênToolStripMenuItem,
            this.thôngTinChứcVụToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // thôngTinChứcVụToolStripMenuItem
            // 
            this.thôngTinChứcVụToolStripMenuItem.Name = "thôngTinChứcVụToolStripMenuItem";
            this.thôngTinChứcVụToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.thôngTinChứcVụToolStripMenuItem.Text = "Thông tin chức vụ";
            this.thôngTinChứcVụToolStripMenuItem.Click += new System.EventHandler(this.thôngTinChứcVụToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem,
            this.báoCáoDnahSáchNhânViênToolStripMenuItem,
            this.báoCáoPhòngĐangSửDụngToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem
            // 
            this.báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem.Name = "báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem";
            this.báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(361, 30);
            this.báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem.Text = "Báo cáo doanh thu theo hóa đơn";
            this.báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem_Click);
            // 
            // báoCáoDnahSáchNhânViênToolStripMenuItem
            // 
            this.báoCáoDnahSáchNhânViênToolStripMenuItem.Name = "báoCáoDnahSáchNhânViênToolStripMenuItem";
            this.báoCáoDnahSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(361, 30);
            this.báoCáoDnahSáchNhânViênToolStripMenuItem.Text = "Báo cáo danh sách nhân viên";
            this.báoCáoDnahSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDnahSáchNhânViênToolStripMenuItem_Click);
            // 
            // báoCáoPhòngĐangSửDụngToolStripMenuItem
            // 
            this.báoCáoPhòngĐangSửDụngToolStripMenuItem.Name = "báoCáoPhòngĐangSửDụngToolStripMenuItem";
            this.báoCáoPhòngĐangSửDụngToolStripMenuItem.Size = new System.Drawing.Size(361, 30);
            this.báoCáoPhòngĐangSửDụngToolStripMenuItem.Text = "Báo cáo phòng đang sử dụng";
            this.báoCáoPhòngĐangSửDụngToolStripMenuItem.Click += new System.EventHandler(this.báoCáoPhòngĐangSửDụngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btmTimKiemThongTin
            // 
            this.btmTimKiemThongTin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmTimKiemThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmTimKiemThongTin.Location = new System.Drawing.Point(659, 129);
            this.btmTimKiemThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.btmTimKiemThongTin.Name = "btmTimKiemThongTin";
            this.btmTimKiemThongTin.Size = new System.Drawing.Size(122, 40);
            this.btmTimKiemThongTin.TabIndex = 84;
            this.btmTimKiemThongTin.Text = "Tìm kiếm";
            this.btmTimKiemThongTin.UseVisualStyleBackColor = false;
            this.btmTimKiemThongTin.Click += new System.EventHandler(this.btmTimKiemThongTin_Click);
            // 
            // dataGridViewTimKiemThongTin
            // 
            this.dataGridViewTimKiemThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemThongTin.Location = new System.Drawing.Point(70, 314);
            this.dataGridViewTimKiemThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTimKiemThongTin.Name = "dataGridViewTimKiemThongTin";
            this.dataGridViewTimKiemThongTin.RowHeadersWidth = 51;
            this.dataGridViewTimKiemThongTin.RowTemplate.Height = 24;
            this.dataGridViewTimKiemThongTin.Size = new System.Drawing.Size(656, 187);
            this.dataGridViewTimKiemThongTin.TabIndex = 82;
            // 
            // cboTenLoaiPhong
            // 
            this.cboTenLoaiPhong.Enabled = false;
            this.cboTenLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenLoaiPhong.FormattingEnabled = true;
            this.cboTenLoaiPhong.Location = new System.Drawing.Point(328, 175);
            this.cboTenLoaiPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenLoaiPhong.Name = "cboTenLoaiPhong";
            this.cboTenLoaiPhong.Size = new System.Drawing.Size(270, 30);
            this.cboTenLoaiPhong.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 36);
            this.label6.TabIndex = 78;
            this.label6.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // cboTenPhong
            // 
            this.cboTenPhong.Enabled = false;
            this.cboTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenPhong.FormattingEnabled = true;
            this.cboTenPhong.Location = new System.Drawing.Point(328, 221);
            this.cboTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenPhong.Name = "cboTenPhong";
            this.cboTenPhong.Size = new System.Drawing.Size(270, 30);
            this.cboTenPhong.TabIndex = 81;
            // 
            // rbtnTenKH
            // 
            this.rbtnTenKH.AutoSize = true;
            this.rbtnTenKH.Checked = true;
            this.rbtnTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTenKH.Location = new System.Drawing.Point(152, 128);
            this.rbtnTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTenKH.Name = "rbtnTenKH";
            this.rbtnTenKH.Size = new System.Drawing.Size(166, 28);
            this.rbtnTenKH.TabIndex = 85;
            this.rbtnTenKH.TabStop = true;
            this.rbtnTenKH.Text = "Tên khách hàng";
            this.rbtnTenKH.UseVisualStyleBackColor = true;
            this.rbtnTenKH.CheckedChanged += new System.EventHandler(this.rbtnTenKH_CheckedChanged);
            // 
            // rbtnTenLoaiPhong
            // 
            this.rbtnTenLoaiPhong.AutoSize = true;
            this.rbtnTenLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTenLoaiPhong.Location = new System.Drawing.Point(152, 176);
            this.rbtnTenLoaiPhong.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTenLoaiPhong.Name = "rbtnTenLoaiPhong";
            this.rbtnTenLoaiPhong.Size = new System.Drawing.Size(156, 28);
            this.rbtnTenLoaiPhong.TabIndex = 85;
            this.rbtnTenLoaiPhong.TabStop = true;
            this.rbtnTenLoaiPhong.Text = "Tên loại phòng";
            this.rbtnTenLoaiPhong.UseVisualStyleBackColor = true;
            this.rbtnTenLoaiPhong.CheckedChanged += new System.EventHandler(this.rbtnTenLoaiPhong_CheckedChanged);
            // 
            // rbtnMaNhanVien
            // 
            this.rbtnMaNhanVien.AutoSize = true;
            this.rbtnMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMaNhanVien.Location = new System.Drawing.Point(152, 268);
            this.rbtnMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMaNhanVien.Name = "rbtnMaNhanVien";
            this.rbtnMaNhanVien.Size = new System.Drawing.Size(142, 28);
            this.rbtnMaNhanVien.TabIndex = 85;
            this.rbtnMaNhanVien.TabStop = true;
            this.rbtnMaNhanVien.Text = "Mã nhân viên";
            this.rbtnMaNhanVien.UseVisualStyleBackColor = true;
            this.rbtnMaNhanVien.CheckedChanged += new System.EventHandler(this.rbtnMaNhanVien_CheckedChanged);
            // 
            // rbtnTenPhong
            // 
            this.rbtnTenPhong.AutoSize = true;
            this.rbtnTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTenPhong.Location = new System.Drawing.Point(152, 224);
            this.rbtnTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTenPhong.Name = "rbtnTenPhong";
            this.rbtnTenPhong.Size = new System.Drawing.Size(122, 28);
            this.rbtnTenPhong.TabIndex = 85;
            this.rbtnTenPhong.TabStop = true;
            this.rbtnTenPhong.Text = "Tên phòng";
            this.rbtnTenPhong.UseVisualStyleBackColor = true;
            this.rbtnTenPhong.CheckedChanged += new System.EventHandler(this.rbtnTenPhong_CheckedChanged);
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.Enabled = false;
            this.cboMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(328, 267);
            this.cboMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(270, 30);
            this.cboMaNhanVien.TabIndex = 81;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(328, 129);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(270, 28);
            this.txtKhachHang.TabIndex = 86;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 585);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.rbtnTenPhong);
            this.Controls.Add(this.rbtnMaNhanVien);
            this.Controls.Add(this.rbtnTenLoaiPhong);
            this.Controls.Add(this.rbtnTenKH);
            this.Controls.Add(this.btmTimKiemThongTin);
            this.Controls.Add(this.dataGridViewTimKiemThongTin);
            this.Controls.Add(this.cboMaNhanVien);
            this.Controls.Add(this.cboTenPhong);
            this.Controls.Add(this.cboTenLoaiPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMenuLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem tìnhTrạngPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChứcVụToolStripMenuItem;
        private System.Windows.Forms.Button btmTimKiemThongTin;
        private System.Windows.Forms.DataGridView dataGridViewTimKiemThongTin;
        private System.Windows.Forms.ComboBox cboTenLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTenPhong;
        private System.Windows.Forms.RadioButton rbtnTenKH;
        private System.Windows.Forms.RadioButton rbtnTenLoaiPhong;
        private System.Windows.Forms.RadioButton rbtnMaNhanVien;
        private System.Windows.Forms.RadioButton rbtnTenPhong;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuTheoHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDnahSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoPhòngĐangSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}



