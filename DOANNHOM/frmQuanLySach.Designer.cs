namespace DOANNHOM
{
    partial class frmQuanLySach
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
            this.btnNXB = new System.Windows.Forms.Button();
            this.btnTacGia = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnQLS = new System.Windows.Forms.Button();
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.rbNXB = new System.Windows.Forms.RadioButton();
            this.rbLoaiSach = new System.Windows.Forms.RadioButton();
            this.rbTacGia = new System.Windows.Forms.RadioButton();
            this.rbTenSach = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNXB
            // 
            this.btnNXB.Location = new System.Drawing.Point(644, 136);
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Size = new System.Drawing.Size(113, 38);
            this.btnNXB.TabIndex = 18;
            this.btnNXB.Text = "NHÀ SUÂT BẢN ";
            this.btnNXB.UseVisualStyleBackColor = true;
            // 
            // btnTacGia
            // 
            this.btnTacGia.Location = new System.Drawing.Point(505, 136);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(113, 36);
            this.btnTacGia.TabIndex = 16;
            this.btnTacGia.Text = "TÁC GIẢ";
            this.btnTacGia.UseVisualStyleBackColor = true;
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Location = new System.Drawing.Point(505, 88);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(113, 38);
            this.btnTheLoai.TabIndex = 17;
            this.btnTheLoai.Text = "THỂ LOẠI";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnQLS
            // 
            this.btnQLS.Location = new System.Drawing.Point(644, 88);
            this.btnQLS.Name = "btnQLS";
            this.btnQLS.Size = new System.Drawing.Size(113, 38);
            this.btnQLS.TabIndex = 15;
            this.btnQLS.Text = "SÁCH";
            this.btnQLS.UseVisualStyleBackColor = true;
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.Location = new System.Drawing.Point(24, 206);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.Size = new System.Drawing.Size(738, 177);
            this.dgvDSTK.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.rbNXB);
            this.groupBox1.Controls.Add(this.rbLoaiSach);
            this.groupBox1.Controls.Add(this.rbTacGia);
            this.groupBox1.Controls.Add(this.rbTenSach);
            this.groupBox1.Location = new System.Drawing.Point(24, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 134);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(84, 88);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(252, 20);
            this.txtTK.TabIndex = 10;
            // 
            // rbNXB
            // 
            this.rbNXB.AutoSize = true;
            this.rbNXB.Location = new System.Drawing.Point(305, 43);
            this.rbNXB.Name = "rbNXB";
            this.rbNXB.Size = new System.Drawing.Size(89, 17);
            this.rbNXB.TabIndex = 9;
            this.rbNXB.TabStop = true;
            this.rbNXB.Text = "Nhà xuất bản";
            this.rbNXB.UseVisualStyleBackColor = true;
            // 
            // rbLoaiSach
            // 
            this.rbLoaiSach.AutoSize = true;
            this.rbLoaiSach.Location = new System.Drawing.Point(123, 43);
            this.rbLoaiSach.Name = "rbLoaiSach";
            this.rbLoaiSach.Size = new System.Drawing.Size(71, 17);
            this.rbLoaiSach.TabIndex = 8;
            this.rbLoaiSach.TabStop = true;
            this.rbLoaiSach.Text = "Loại sách";
            this.rbLoaiSach.UseVisualStyleBackColor = true;
            // 
            // rbTacGia
            // 
            this.rbTacGia.AutoSize = true;
            this.rbTacGia.Location = new System.Drawing.Point(218, 43);
            this.rbTacGia.Name = "rbTacGia";
            this.rbTacGia.Size = new System.Drawing.Size(61, 17);
            this.rbTacGia.TabIndex = 7;
            this.rbTacGia.TabStop = true;
            this.rbTacGia.Text = "Tác giả";
            this.rbTacGia.UseVisualStyleBackColor = true;
            // 
            // rbTenSach
            // 
            this.rbTenSach.AutoSize = true;
            this.rbTenSach.Location = new System.Drawing.Point(27, 43);
            this.rbTenSach.Name = "rbTenSach";
            this.rbTenSach.Size = new System.Drawing.Size(70, 17);
            this.rbTenSach.TabIndex = 6;
            this.rbTenSach.TabStop = true;
            this.rbTenSach.Text = "Tên sách";
            this.rbTenSach.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quảnLýSáchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(187, 41);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNXB);
            this.Controls.Add(this.btnTacGia);
            this.Controls.Add(this.btnTheLoai);
            this.Controls.Add(this.btnQLS);
            this.Controls.Add(this.dgvDSTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLySach";
            this.Text = "frmQuanLySach";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNXB;
        private System.Windows.Forms.Button btnTacGia;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnQLS;
        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.RadioButton rbNXB;
        private System.Windows.Forms.RadioButton rbLoaiSach;
        private System.Windows.Forms.RadioButton rbTacGia;
        private System.Windows.Forms.RadioButton rbTenSach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
    }
}