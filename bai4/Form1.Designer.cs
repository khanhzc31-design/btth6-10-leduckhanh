namespace THB4_6_10_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelTop = new System.Windows.Forms.Panel();
            lblViewMode = new System.Windows.Forms.Label();
            cboViewMode = new System.Windows.Forms.ComboBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tvDepartments = new System.Windows.Forms.TreeView();
            lsvEmployees = new System.Windows.Forms.ListView();
            imgListSmall = new System.Windows.Forms.ImageList(components);
            imgListLarge = new System.Windows.Forms.ImageList(components);
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(cboViewMode);
            panelTop.Controls.Add(lblViewMode);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(800, 45);
            panelTop.TabIndex = 0;
            // 
            // lblViewMode
            // 
            lblViewMode.AutoSize = true;
            lblViewMode.Location = new System.Drawing.Point(520, 12);
            lblViewMode.Name = "lblViewMode";
            lblViewMode.Size = new System.Drawing.Size(102, 20);
            lblViewMode.TabIndex = 0;
            lblViewMode.Text = "Chế độ xem:";
            // 
            // cboViewMode
            // 
            cboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Location = new System.Drawing.Point(628, 9);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new System.Drawing.Size(160, 28);
            cboViewMode.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 45);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Size = new System.Drawing.Size(800, 405);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 1;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            tvDepartments.Location = new System.Drawing.Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.Size = new System.Drawing.Size(260, 405);
            tvDepartments.TabIndex = 0;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            lsvEmployees.LargeImageList = imgListLarge;
            lsvEmployees.Location = new System.Drawing.Point(0, 0);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new System.Drawing.Size(536, 405);
            lsvEmployees.SmallImageList = imgListSmall;
            lsvEmployees.TabIndex = 0;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // imgListSmall
            // 
            imgListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imgListSmall.ImageSize = new System.Drawing.Size(16, 16);
            imgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListLarge
            // 
            imgListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imgListLarge.ImageSize = new System.Drawing.Size(32, 32);
            imgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmQuanLyNhanVien
            // 
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panelTop);
            Name = "FrmQuanLyNhanVien";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.4 - Trình quản lý nhân viên (TreeView & ListView)";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblViewMode;
        private System.Windows.Forms.ComboBox cboViewMode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ImageList imgListSmall;
        private System.Windows.Forms.ImageList imgListLarge;
    }
}