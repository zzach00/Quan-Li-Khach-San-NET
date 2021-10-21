
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
            this.btmTimKiemThongTin = new System.Windows.Forms.Button();
            this.dataGridViewTimKiemThongTin = new System.Windows.Forms.DataGridView();
            this.cboMaDatPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rbtnTenKH = new System.Windows.Forms.RadioButton();
            this.rbtnTenLoaiPhong = new System.Windows.Forms.RadioButton();
            this.rbtnMaNhanVien = new System.Windows.Forms.RadioButton();
            this.rbtnTenPhong = new System.Windows.Forms.RadioButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 635);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1107, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
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
            this.nhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 40);
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
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            this.đặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.đặtPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng - Hóa đơn";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuLoaiPhong,
            this.tìnhTrạngPhòngToolStripMenuItem});
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.phòngToolStripMenuItem.Text = "Phòng";
            // 
            // stripMenuLoaiPhong
            // 
            this.stripMenuLoaiPhong.Name = "stripMenuLoaiPhong";
            this.stripMenuLoaiPhong.Size = new System.Drawing.Size(291, 36);
            this.stripMenuLoaiPhong.Text = "Loại phòng";
            this.stripMenuLoaiPhong.Click += new System.EventHandler(this.stripMenuLoaiPhong_Click);
            // 
            // tìnhTrạngPhòngToolStripMenuItem
            // 
            this.tìnhTrạngPhòngToolStripMenuItem.Name = "tìnhTrạngPhòngToolStripMenuItem";
            this.tìnhTrạngPhòngToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.tìnhTrạngPhòngToolStripMenuItem.Text = "Tình trạng phòng";
            this.tìnhTrạngPhòngToolStripMenuItem.Click += new System.EventHandler(this.tìnhTrạngPhòngToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânViênToolStripMenuItem,
            this.thôngTinChứcVụToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(321, 36);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // thôngTinChứcVụToolStripMenuItem
            // 
            this.thôngTinChứcVụToolStripMenuItem.Name = "thôngTinChứcVụToolStripMenuItem";
            this.thôngTinChứcVụToolStripMenuItem.Size = new System.Drawing.Size(321, 36);
            this.thôngTinChứcVụToolStripMenuItem.Text = "Thông tin chức vụ";
            this.thôngTinChứcVụToolStripMenuItem.Click += new System.EventHandler(this.thôngTinChứcVụToolStripMenuItem_Click);
            // 
            // btmTimKiemThongTin
            // 
            this.btmTimKiemThongTin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmTimKiemThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmTimKiemThongTin.Location = new System.Drawing.Point(879, 159);
            this.btmTimKiemThongTin.Name = "btmTimKiemThongTin";
            this.btmTimKiemThongTin.Size = new System.Drawing.Size(163, 49);
            this.btmTimKiemThongTin.TabIndex = 84;
            this.btmTimKiemThongTin.Text = "Tìm kiếm";
            this.btmTimKiemThongTin.UseVisualStyleBackColor = false;
            this.btmTimKiemThongTin.Click += new System.EventHandler(this.btmTimKiemThongTin_Click);
            // 
            // dataGridViewTimKiemThongTin
            // 
            this.dataGridViewTimKiemThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemThongTin.Location = new System.Drawing.Point(93, 386);
            this.dataGridViewTimKiemThongTin.Name = "dataGridViewTimKiemThongTin";
            this.dataGridViewTimKiemThongTin.RowHeadersWidth = 51;
            this.dataGridViewTimKiemThongTin.RowTemplate.Height = 24;
            this.dataGridViewTimKiemThongTin.Size = new System.Drawing.Size(752, 230);
            this.dataGridViewTimKiemThongTin.TabIndex = 82;
            // 
            // cboMaDatPhong
            // 
            this.cboMaDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaDatPhong.FormattingEnabled = true;
            this.cboMaDatPhong.Location = new System.Drawing.Point(437, 215);
            this.cboMaDatPhong.Name = "cboMaDatPhong";
            this.cboMaDatPhong.Size = new System.Drawing.Size(358, 37);
            this.cboMaDatPhong.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(422, 44);
            this.label6.TabIndex = 78;
            this.label6.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(437, 272);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(358, 37);
            this.comboBox2.TabIndex = 81;
            // 
            // rbtnTenKH
            // 
            this.rbtnTenKH.AutoSize = true;
            this.rbtnTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTenKH.Location = new System.Drawing.Point(202, 158);
            this.rbtnTenKH.Name = "rbtnTenKH";
            this.rbtnTenKH.Size = new System.Drawing.Size(205, 33);
            this.rbtnTenKH.TabIndex = 85;
            this.rbtnTenKH.TabStop = true;
            this.rbtnTenKH.Text = "Tên khách hàng";
            this.rbtnTenKH.UseVisualStyleBackColor = true;
            // 
            // rbtnTenLoaiPhong
            // 
            this.rbtnTenLoaiPhong.AutoSize = true;
            this.rbtnTenLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTenLoaiPhong.Location = new System.Drawing.Point(202, 216);
            this.rbtnTenLoaiPhong.Name = "rbtnTenLoaiPhong";
            this.rbtnTenLoaiPhong.Size = new System.Drawing.Size(196, 33);
            this.rbtnTenLoaiPhong.TabIndex = 85;
            this.rbtnTenLoaiPhong.TabStop = true;
            this.rbtnTenLoaiPhong.Text = "Tên loại phòng";
            this.rbtnTenLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // rbtnMaNhanVien
            // 
            this.rbtnMaNhanVien.AutoSize = true;
            this.rbtnMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMaNhanVien.Location = new System.Drawing.Point(202, 330);
            this.rbtnMaNhanVien.Name = "rbtnMaNhanVien";
            this.rbtnMaNhanVien.Size = new System.Drawing.Size(175, 33);
            this.rbtnMaNhanVien.TabIndex = 85;
            this.rbtnMaNhanVien.TabStop = true;
            this.rbtnMaNhanVien.Text = "Mã nhân viên";
            this.rbtnMaNhanVien.UseVisualStyleBackColor = true;
            // 
            // rbtnTenPhong
            // 
            this.rbtnTenPhong.AutoSize = true;
            this.rbtnTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTenPhong.Location = new System.Drawing.Point(202, 276);
            this.rbtnTenPhong.Name = "rbtnTenPhong";
            this.rbtnTenPhong.Size = new System.Drawing.Size(151, 33);
            this.rbtnTenPhong.TabIndex = 85;
            this.rbtnTenPhong.TabStop = true;
            this.rbtnTenPhong.Text = "Tên phòng";
            this.rbtnTenPhong.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(437, 329);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(358, 37);
            this.comboBox3.TabIndex = 81;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(437, 159);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(358, 34);
            this.txtMaHoaDon.TabIndex = 86;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 661);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.rbtnTenPhong);
            this.Controls.Add(this.rbtnMaNhanVien);
            this.Controls.Add(this.rbtnTenLoaiPhong);
            this.Controls.Add(this.rbtnTenKH);
            this.Controls.Add(this.btmTimKiemThongTin);
            this.Controls.Add(this.dataGridViewTimKiemThongTin);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cboMaDatPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cboMaDatPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rbtnTenKH;
        private System.Windows.Forms.RadioButton rbtnTenLoaiPhong;
        private System.Windows.Forms.RadioButton rbtnMaNhanVien;
        private System.Windows.Forms.RadioButton rbtnTenPhong;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtMaHoaDon;
    }
}



