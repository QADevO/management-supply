namespace GUI.NguyenLieu
{
    partial class FrmNguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DVT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_ThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_NguyenLieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TonKho = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1029, 159);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(180, 45);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhat.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(1029, 93);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(180, 45);
            this.btn_CapNhat.TabIndex = 32;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Đơn vị tính";
            // 
            // txt_DVT
            // 
            this.txt_DVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DVT.DefaultText = "";
            this.txt_DVT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DVT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DVT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DVT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DVT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DVT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DVT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DVT.Location = new System.Drawing.Point(621, 98);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.PasswordChar = '\0';
            this.txt_DVT.PlaceholderText = "";
            this.txt_DVT.SelectedText = "";
            this.txt_DVT.Size = new System.Drawing.Size(327, 36);
            this.txt_DVT.TabIndex = 28;
            this.txt_DVT.TextChanged += new System.EventHandler(this.txt_DVT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên nguyên liệu";
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenNL.DefaultText = "";
            this.txt_TenNL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenNL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenNL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenNL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenNL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenNL.Location = new System.Drawing.Point(198, 173);
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.PasswordChar = '\0';
            this.txt_TenNL.PlaceholderText = "";
            this.txt_TenNL.SelectedText = "";
            this.txt_TenNL.Size = new System.Drawing.Size(244, 36);
            this.txt_TenNL.TabIndex = 24;
            this.txt_TenNL.TextChanged += new System.EventHandler(this.txt_TenNL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã nguyên liệu";
            // 
            // txt_MaNL
            // 
            this.txt_MaNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNL.DefaultText = "";
            this.txt_MaNL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNL.Location = new System.Drawing.Point(198, 98);
            this.txt_MaNL.Name = "txt_MaNL";
            this.txt_MaNL.PasswordChar = '\0';
            this.txt_MaNL.PlaceholderText = "";
            this.txt_MaNL.SelectedText = "";
            this.txt_MaNL.Size = new System.Drawing.Size(244, 36);
            this.txt_MaNL.TabIndex = 22;
            this.txt_MaNL.TextChanged += new System.EventHandler(this.txt_MaNL_TextChanged);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemMoi.FillColor = System.Drawing.Color.Lime;
            this.btn_ThemMoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMoi.ForeColor = System.Drawing.Color.White;
            this.btn_ThemMoi.Location = new System.Drawing.Point(664, 15);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(180, 45);
            this.btn_ThemMoi.TabIndex = 21;
            this.btn_ThemMoi.Text = "Thêm Mới";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_TimKiem.BorderRadius = 20;
            this.btn_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search;
            this.btn_TimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_TimKiem.Location = new System.Drawing.Point(549, 15);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(70, 45);
            this.btn_TimKiem.TabIndex = 20;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderColor = System.Drawing.Color.Gray;
            this.txt_TimKiem.BorderRadius = 18;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Location = new System.Drawing.Point(7, 15);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PasswordChar = '\0';
            this.txt_TimKiem.PlaceholderText = "";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(536, 45);
            this.txt_TimKiem.TabIndex = 19;
            // 
            // dgv_NguyenLieu
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_NguyenLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_NguyenLieu.ColumnHeadersHeight = 4;
            this.dgv_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NguyenLieu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_NguyenLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_NguyenLieu.Location = new System.Drawing.Point(52, 311);
            this.dgv_NguyenLieu.Name = "dgv_NguyenLieu";
            this.dgv_NguyenLieu.RowHeadersVisible = false;
            this.dgv_NguyenLieu.Size = new System.Drawing.Size(1470, 538);
            this.dgv_NguyenLieu.TabIndex = 18;
            this.dgv_NguyenLieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NguyenLieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_NguyenLieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_NguyenLieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_NguyenLieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_NguyenLieu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NguyenLieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_NguyenLieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_NguyenLieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_NguyenLieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_NguyenLieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_NguyenLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_NguyenLieu.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_NguyenLieu.ThemeStyle.ReadOnly = false;
            this.dgv_NguyenLieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NguyenLieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_NguyenLieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_NguyenLieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_NguyenLieu.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_NguyenLieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_NguyenLieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_NguyenLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NguyenLieu_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tồn kho";
            // 
            // txt_TonKho
            // 
            this.txt_TonKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TonKho.DefaultText = "";
            this.txt_TonKho.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TonKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TonKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TonKho.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TonKho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TonKho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TonKho.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TonKho.Location = new System.Drawing.Point(621, 173);
            this.txt_TonKho.Name = "txt_TonKho";
            this.txt_TonKho.PasswordChar = '\0';
            this.txt_TonKho.PlaceholderText = "";
            this.txt_TonKho.SelectedText = "";
            this.txt_TonKho.Size = new System.Drawing.Size(327, 36);
            this.txt_TonKho.TabIndex = 35;
            this.txt_TonKho.TextChanged += new System.EventHandler(this.txt_TonKho_TextChanged);
            // 
            // FrmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 1000);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TonKho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenNL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaNL);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dgv_NguyenLieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNguyenLieu";
            this.Text = "FrmNguyenLieu";
            this.Load += new System.EventHandler(this.FrmNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_CapNhat;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_DVT;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenNL;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaNL;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMoi;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_NguyenLieu;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_TonKho;
    }
}