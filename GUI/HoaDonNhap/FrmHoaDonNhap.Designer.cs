namespace GUI.HoaDonNhap
{
    partial class FrmHoaDonNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_hoadonnhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_hoadonnhap_detail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadonnhap)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadonnhap_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.dgv_hoadonnhap);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(28, 23);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(909, 762);
            this.guna2GroupBox3.TabIndex = 85;
            this.guna2GroupBox3.Text = "Hóa đơn nhập";
            // 
            // dgv_hoadonnhap
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoadonnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_hoadonnhap.ColumnHeadersHeight = 4;
            this.dgv_hoadonnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hoadonnhap.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_hoadonnhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap.Location = new System.Drawing.Point(18, 62);
            this.dgv_hoadonnhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_hoadonnhap.Name = "dgv_hoadonnhap";
            this.dgv_hoadonnhap.RowHeadersVisible = false;
            this.dgv_hoadonnhap.RowHeadersWidth = 51;
            this.dgv_hoadonnhap.RowTemplate.Height = 24;
            this.dgv_hoadonnhap.Size = new System.Drawing.Size(871, 666);
            this.dgv_hoadonnhap.TabIndex = 88;
            this.dgv_hoadonnhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_hoadonnhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_hoadonnhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_hoadonnhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_hoadonnhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hoadonnhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_hoadonnhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_hoadonnhap.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_hoadonnhap.ThemeStyle.ReadOnly = false;
            this.dgv_hoadonnhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoadonnhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_hoadonnhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgv_hoadonnhap.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_hoadonnhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoadonnhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadonnhap_CellContentClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgv_hoadonnhap_detail);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(953, 23);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(451, 762);
            this.guna2GroupBox1.TabIndex = 83;
            this.guna2GroupBox1.Text = "Danh sách hóa đơn nhập";
            // 
            // dgv_hoadonnhap_detail
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoadonnhap_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_hoadonnhap_detail.ColumnHeadersHeight = 4;
            this.dgv_hoadonnhap_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hoadonnhap_detail.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_hoadonnhap_detail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap_detail.Location = new System.Drawing.Point(24, 62);
            this.dgv_hoadonnhap_detail.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_hoadonnhap_detail.Name = "dgv_hoadonnhap_detail";
            this.dgv_hoadonnhap_detail.RowHeadersVisible = false;
            this.dgv_hoadonnhap_detail.RowHeadersWidth = 51;
            this.dgv_hoadonnhap_detail.RowTemplate.Height = 24;
            this.dgv_hoadonnhap_detail.Size = new System.Drawing.Size(404, 666);
            this.dgv_hoadonnhap_detail.TabIndex = 89;
            this.dgv_hoadonnhap_detail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap_detail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_hoadonnhap_detail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_hoadonnhap_detail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_hoadonnhap_detail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_hoadonnhap_detail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap_detail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap_detail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap_detail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hoadonnhap_detail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_hoadonnhap_detail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap_detail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_hoadonnhap_detail.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_hoadonnhap_detail.ThemeStyle.ReadOnly = false;
            this.dgv_hoadonnhap_detail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoadonnhap_detail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoadonnhap_detail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_hoadonnhap_detail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgv_hoadonnhap_detail.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_hoadonnhap_detail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoadonnhap_detail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoadonnhap_detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadonnhap_detail_CellContentClick);
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 961);
            this.ControlBox = false;
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHoaDonNhap";
            this.Text = "FrmHoaDonNhap";
            this.Load += new System.EventHandler(this.FrmHoaDonNhap_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadonnhap)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadonnhap_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_hoadonnhap;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_hoadonnhap_detail;
    }
}