namespace GUI.HoaDon
{
    partial class FrmHoaDon
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
            this.SuspendLayout();
            // 
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_invoice_detail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_listDaiLy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_loSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_add_loSP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_donViTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.TenSP = new System.Windows.Forms.Label();
            this.txt_TenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SLBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Gia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaLoHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_ = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_SP = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice_detail)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loSanPham)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.dgv_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_invoice_detail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_invoice_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoice_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_invoice_detail.ColumnHeadersHeight = 4;
            this.dgv_invoice_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_invoice_detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_invoice_detail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_invoice_detail.Location = new System.Drawing.Point(28, 124);
            this.dgv_invoice_detail.Name = "dgv_invoice_detail";
            this.dgv_invoice_detail.RowHeadersVisible = false;
            this.dgv_invoice_detail.Size = new System.Drawing.Size(893, 611);
            this.dgv_invoice_detail.TabIndex = 0;
            this.dgv_invoice_detail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_invoice_detail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_invoice_detail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_invoice_detail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_invoice_detail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_invoice_detail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_invoice_detail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_invoice_detail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_invoice_detail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_invoice_detail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_invoice_detail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_invoice_detail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_invoice_detail.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_invoice_detail.ThemeStyle.ReadOnly = false;
            this.dgv_invoice_detail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_invoice_detail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_invoice_detail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_invoice_detail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_invoice_detail.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_invoice_detail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_invoice_detail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_invoice_detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoice_detail_CellContentClick);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.cbb_listDaiLy);
            this.guna2GroupBox2.Controls.Add(this.guna2Button2);
            this.guna2GroupBox2.Controls.Add(this.dgv_invoice_detail);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(651, 25);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(942, 887);
            this.guna2GroupBox2.TabIndex = 3;
            this.guna2GroupBox2.Text = "Chi tiết hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đại lý";
            // 
            // cbb_listDaiLy
            // 
            this.cbb_listDaiLy.BackColor = System.Drawing.Color.Transparent;
            this.cbb_listDaiLy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_listDaiLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_listDaiLy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_listDaiLy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_listDaiLy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_listDaiLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_listDaiLy.ItemHeight = 30;
            this.cbb_listDaiLy.Location = new System.Drawing.Point(122, 69);
            this.cbb_listDaiLy.Name = "cbb_listDaiLy";
            this.cbb_listDaiLy.Size = new System.Drawing.Size(799, 36);
            this.cbb_listDaiLy.TabIndex = 3;
            this.cbb_listDaiLy.SelectedIndexChanged += new System.EventHandler(this.cbb_listDaiLy_SelectedIndexChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(224, 811);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(554, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "tạo hóa đơn";
            // 
            // dgv_loSanPham
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_loSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_loSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_loSanPham.ColumnHeadersHeight = 4;
            this.dgv_loSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_loSanPham.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_loSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_loSanPham.Location = new System.Drawing.Point(34, 53);
            this.dgv_loSanPham.Name = "dgv_loSanPham";
            this.dgv_loSanPham.RowHeadersVisible = false;
            this.dgv_loSanPham.Size = new System.Drawing.Size(540, 165);
            this.dgv_loSanPham.TabIndex = 0;
            this.dgv_loSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_loSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_loSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_loSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_loSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_loSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_loSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_loSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_loSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_loSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_loSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_loSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_loSanPham.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_loSanPham.ThemeStyle.ReadOnly = false;
            this.dgv_loSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_loSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_loSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_loSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_loSanPham.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_loSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_loSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_loSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loSanPham_CellContentClick);
            // 
            // btn_add_loSP
            // 
            this.btn_add_loSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_loSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_loSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_loSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_loSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add_loSP.ForeColor = System.Drawing.Color.White;
            this.btn_add_loSP.Location = new System.Drawing.Point(446, 224);
            this.btn_add_loSP.Name = "btn_add_loSP";
            this.btn_add_loSP.Size = new System.Drawing.Size(128, 192);
            this.btn_add_loSP.TabIndex = 1;
            this.btn_add_loSP.Text = "Thêm vào chi tiết hóa đơn";
            this.btn_add_loSP.Click += new System.EventHandler(this.btn_add_loSP_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.txt_donViTinh);
            this.guna2GroupBox1.Controls.Add(this.TenSP);
            this.guna2GroupBox1.Controls.Add(this.txt_TenSP);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.txt_SLBan);
            this.guna2GroupBox1.Controls.Add(this.txt_Gia);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txt_MaSP);
            this.guna2GroupBox1.Controls.Add(this.txt_MaLoHang);
            this.guna2GroupBox1.Controls.Add(this.btn_add_loSP);
            this.guna2GroupBox1.Controls.Add(this.dgv_loSanPham);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(32, 488);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(600, 424);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Lô sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đơn Vị Tính";
            // 
            // txt_donViTinh
            // 
            this.txt_donViTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_donViTinh.DefaultText = "";
            this.txt_donViTinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_donViTinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_donViTinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_donViTinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_donViTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_donViTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_donViTinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_donViTinh.Location = new System.Drawing.Point(174, 323);
            this.txt_donViTinh.Name = "txt_donViTinh";
            this.txt_donViTinh.PasswordChar = '\0';
            this.txt_donViTinh.PlaceholderText = "";
            this.txt_donViTinh.SelectedText = "";
            this.txt_donViTinh.Size = new System.Drawing.Size(244, 27);
            this.txt_donViTinh.TabIndex = 13;
            this.txt_donViTinh.TextChanged += new System.EventHandler(this.txt_donViTinh_TextChanged);
            // 
            // TenSP
            // 
            this.TenSP.AutoSize = true;
            this.TenSP.Location = new System.Drawing.Point(61, 274);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(39, 15);
            this.TenSP.TabIndex = 12;
            this.TenSP.Text = "TenSP";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenSP.DefaultText = "";
            this.txt_TenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenSP.Location = new System.Drawing.Point(174, 255);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.PasswordChar = '\0';
            this.txt_TenSP.PlaceholderText = "";
            this.txt_TenSP.SelectedText = "";
            this.txt_TenSP.Size = new System.Drawing.Size(244, 27);
            this.txt_TenSP.TabIndex = 11;
            this.txt_TenSP.TextChanged += new System.EventHandler(this.txt_TenSP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá";
            // 
            // txt_SLBan
            // 
            this.txt_SLBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SLBan.DefaultText = "";
            this.txt_SLBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SLBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SLBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SLBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SLBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SLBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SLBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SLBan.Location = new System.Drawing.Point(174, 388);
            this.txt_SLBan.Name = "txt_SLBan";
            this.txt_SLBan.PasswordChar = '\0';
            this.txt_SLBan.PlaceholderText = "";
            this.txt_SLBan.SelectedText = "";
            this.txt_SLBan.Size = new System.Drawing.Size(244, 23);
            this.txt_SLBan.TabIndex = 8;
            this.txt_SLBan.TextChanged += new System.EventHandler(this.txt_SLBan_TextChanged);
            // 
            // txt_Gia
            // 
            this.txt_Gia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Gia.DefaultText = "";
            this.txt_Gia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Gia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Gia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Gia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Gia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Gia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Gia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Gia.Location = new System.Drawing.Point(174, 287);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.PasswordChar = '\0';
            this.txt_Gia.PlaceholderText = "";
            this.txt_Gia.SelectedText = "";
            this.txt_Gia.Size = new System.Drawing.Size(244, 28);
            this.txt_Gia.TabIndex = 7;
            this.txt_Gia.TextChanged += new System.EventHandler(this.txt_Gia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "MaSP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Lô Hàng";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaSP.DefaultText = "";
            this.txt_MaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaSP.Location = new System.Drawing.Point(174, 224);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.PasswordChar = '\0';
            this.txt_MaSP.PlaceholderText = "";
            this.txt_MaSP.SelectedText = "";
            this.txt_MaSP.Size = new System.Drawing.Size(244, 27);
            this.txt_MaSP.TabIndex = 3;
            this.txt_MaSP.TextChanged += new System.EventHandler(this.txt_soLuongBan_TextChanged);
            // 
            // txt_MaLoHang
            // 
            this.txt_MaLoHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLoHang.DefaultText = "";
            this.txt_MaLoHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaLoHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaLoHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLoHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLoHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaLoHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaLoHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaLoHang.Location = new System.Drawing.Point(174, 358);
            this.txt_MaLoHang.Name = "txt_MaLoHang";
            this.txt_MaLoHang.PasswordChar = '\0';
            this.txt_MaLoHang.PlaceholderText = "";
            this.txt_MaLoHang.SelectedText = "";
            this.txt_MaLoHang.Size = new System.Drawing.Size(244, 27);
            this.txt_MaLoHang.TabIndex = 2;
            this.txt_MaLoHang.TextChanged += new System.EventHandler(this.txt_MaLoHang_TextChanged);
            // 
            // dgv_
            // 
            this.dgv_.Controls.Add(this.dgv_SP);
            this.dgv_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgv_.Location = new System.Drawing.Point(32, 25);
            this.dgv_.Name = "dgv_";
            this.dgv_.Size = new System.Drawing.Size(600, 457);
            this.dgv_.TabIndex = 1;
            this.dgv_.Text = "Danh sách sản phẩm";
            // 
            // dgv_SP
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_SP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_SP.ColumnHeadersHeight = 4;
            this.dgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SP.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_SP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SP.Location = new System.Drawing.Point(34, 57);
            this.dgv_SP.Name = "dgv_SP";
            this.dgv_SP.RowHeadersVisible = false;
            this.dgv_SP.Size = new System.Drawing.Size(540, 382);
            this.dgv_SP.TabIndex = 0;
            this.dgv_SP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_SP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_SP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_SP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_SP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_SP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_SP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_SP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_SP.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_SP.ThemeStyle.ReadOnly = false;
            this.dgv_SP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_SP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SP.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_SP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellClick);
            this.dgv_SP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellContentClick);
            // 

            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(308, 779);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "tạo hóa đơn";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 625);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.ClientSize = new System.Drawing.Size(1676, 936);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgv_);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice_detail)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loSanPham)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.dgv_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_invoice_detail;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_loSanPham;
        private Guna.UI2.WinForms.Guna2Button btn_add_loSP;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox dgv_;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_SP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_listDaiLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaSP;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaLoHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_SLBan;
        private Guna.UI2.WinForms.Guna2TextBox txt_Gia;
        private System.Windows.Forms.Label TenSP;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenSP;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_donViTinh;
    }
}