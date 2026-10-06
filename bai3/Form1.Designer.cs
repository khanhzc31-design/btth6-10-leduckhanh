using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace THB3_6_10_
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
                grpInfo = new System.Windows.Forms.GroupBox();
                cboCategory = new System.Windows.Forms.ComboBox();
                nudQuantity = new System.Windows.Forms.NumericUpDown();
                nudUnitPrice = new System.Windows.Forms.NumericUpDown();
                txtProductName = new System.Windows.Forms.TextBox();
                txtProductId = new System.Windows.Forms.TextBox();
                lblCategory = new System.Windows.Forms.Label();
                lblQuantity = new System.Windows.Forms.Label();
                lblUnitPrice = new System.Windows.Forms.Label();
                lblProductName = new System.Windows.Forms.Label();
                lblProductId = new System.Windows.Forms.Label();
                grpActions = new System.Windows.Forms.GroupBox();
                btnSearch = new System.Windows.Forms.Button();
                txtSearch = new System.Windows.Forms.TextBox();
                btnDelete = new System.Windows.Forms.Button();
                btnEdit = new System.Windows.Forms.Button();
                btnAdd = new System.Windows.Forms.Button();
                dgvProducts = new System.Windows.Forms.DataGridView();
                grpInfo.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
                ((System.ComponentModel.ISupportInitialize)nudUnitPrice).BeginInit();
                grpActions.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
                SuspendLayout();
                // 
                // grpInfo
                // 
                grpInfo.Controls.Add(cboCategory);
                grpInfo.Controls.Add(nudQuantity);
                grpInfo.Controls.Add(nudUnitPrice);
                grpInfo.Controls.Add(txtProductName);
                grpInfo.Controls.Add(txtProductId);
                grpInfo.Controls.Add(lblCategory);
                grpInfo.Controls.Add(lblQuantity);
                grpInfo.Controls.Add(lblUnitPrice);
                grpInfo.Controls.Add(lblProductName);
                grpInfo.Controls.Add(lblProductId);
                grpInfo.Location = new System.Drawing.Point(12, 12);
                grpInfo.Name = "grpInfo";
                grpInfo.Size = new System.Drawing.Size(760, 120);
                grpInfo.TabIndex = 0;
                grpInfo.TabStop = false;
                grpInfo.Text = "Thông tin sản phẩm";
                // 
                // txtProductId
                // 
                txtProductId.Location = new System.Drawing.Point(90, 30);
                txtProductId.Name = "txtProductId";
                txtProductId.Size = new System.Drawing.Size(250, 27);
                txtProductId.TabIndex = 1;
                // 
                // txtProductName
                // 
                txtProductName.Location = new System.Drawing.Point(470, 30);
                txtProductName.Name = "txtProductName";
                txtProductName.Size = new System.Drawing.Size(260, 27);
                txtProductName.TabIndex = 3;
                // 
                // nudUnitPrice
                // 
                nudUnitPrice.Location = new System.Drawing.Point(90, 70);
                nudUnitPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
                nudUnitPrice.Name = "nudUnitPrice";
                nudUnitPrice.Size = new System.Drawing.Size(120, 27);
                nudUnitPrice.TabIndex = 5;
                // 
                // nudQuantity
                // 
                nudQuantity.Location = new System.Drawing.Point(300, 70);
                nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
                nudQuantity.Name = "nudQuantity";
                nudQuantity.Size = new System.Drawing.Size(80, 27);
                nudQuantity.TabIndex = 7;
                // 
                // cboCategory
                // 
                cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                cboCategory.FormattingEnabled = true;
                cboCategory.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Linh kiện", "Gia dụng" });
                cboCategory.Location = new System.Drawing.Point(470, 70);
                cboCategory.Name = "cboCategory";
                cboCategory.Size = new System.Drawing.Size(260, 28);
                cboCategory.TabIndex = 9;
                // 
                // lblProductId
                // 
                lblProductId.AutoSize = true;
                lblProductId.Location = new System.Drawing.Point(20, 33);
                lblProductId.Name = "lblProductId";
                lblProductId.Size = new System.Drawing.Size(53, 20);
                lblProductId.TabIndex = 0;
                lblProductId.Text = "Mã SP:";
                // 
                // lblProductName
                // 
                lblProductName.AutoSize = true;
                lblProductName.Location = new System.Drawing.Point(390, 33);
                lblProductName.Name = "lblProductName";
                lblProductName.Size = new System.Drawing.Size(55, 20);
                lblProductName.TabIndex = 2;
                lblProductName.Text = "Tên SP:";
                // 
                // lblUnitPrice
                // 
                lblUnitPrice.AutoSize = true;
                lblUnitPrice.Location = new System.Drawing.Point(20, 73);
                lblUnitPrice.Name = "lblUnitPrice";
                lblUnitPrice.Size = new System.Drawing.Size(65, 20);
                lblUnitPrice.TabIndex = 4;
                lblUnitPrice.Text = "Đơn giá:";
                // 
                // lblQuantity
                // 
                lblQuantity.AutoSize = true;
                lblQuantity.Location = new System.Drawing.Point(225, 73);
                lblQuantity.Name = "lblQuantity";
                lblQuantity.Size = new System.Drawing.Size(72, 20);
                lblQuantity.TabIndex = 6;
                lblQuantity.Text = "Số lượng:";
                // 
                // lblCategory
                // 
                lblCategory.AutoSize = true;
                lblCategory.Location = new System.Drawing.Point(390, 73);
                lblCategory.Name = "lblCategory";
                lblCategory.Size = new System.Drawing.Size(79, 20);
                lblCategory.TabIndex = 8;
                lblCategory.Text = "Danh mục:";
                // 
                // grpActions
                // 
                grpActions.Controls.Add(btnSearch);
                grpActions.Controls.Add(txtSearch);
                grpActions.Controls.Add(btnDelete);
                grpActions.Controls.Add(btnEdit);
                grpActions.Controls.Add(btnAdd);
                grpActions.Location = new System.Drawing.Point(12, 140);
                grpActions.Name = "grpActions";
                grpActions.Size = new System.Drawing.Size(760, 70);
                grpActions.TabIndex = 1;
                grpActions.TabStop = false;
                grpActions.Text = "Chức năng";
                // 
                // btnAdd
                // 
                btnAdd.Location = new System.Drawing.Point(20, 25);
                btnAdd.Name = "btnAdd";
                btnAdd.Size = new System.Drawing.Size(90, 30);
                btnAdd.TabIndex = 0;
                btnAdd.Text = "Thêm";
                btnAdd.UseVisualStyleBackColor = true;
                // 
                // btnEdit
                // 
                btnEdit.Location = new System.Drawing.Point(125, 25);
                btnEdit.Name = "btnEdit";
                btnEdit.Size = new System.Drawing.Size(90, 30);
                btnEdit.TabIndex = 1;
                btnEdit.Text = "Sửa";
                btnEdit.UseVisualStyleBackColor = true;
                // 
                // btnDelete
                // 
                btnDelete.Location = new System.Drawing.Point(230, 25);
                btnDelete.Name = "btnDelete";
                btnDelete.Size = new System.Drawing.Size(90, 30);
                btnDelete.TabIndex = 2;
                btnDelete.Text = "Xóa";
                btnDelete.UseVisualStyleBackColor = true;
                // 
                // txtSearch
                // 
                txtSearch.Location = new System.Drawing.Point(430, 26);
                txtSearch.Name = "txtSearch";
                txtSearch.PlaceholderText = "Nhập tên SP...";
                txtSearch.Size = new System.Drawing.Size(200, 27);
                txtSearch.TabIndex = 3;
                // 
                // btnSearch
                // 
                btnSearch.Location = new System.Drawing.Point(640, 25);
                btnSearch.Name = "btnSearch";
                btnSearch.Size = new System.Drawing.Size(90, 30);
                btnSearch.TabIndex = 4;
                btnSearch.Text = "Tìm kiếm";
                btnSearch.UseVisualStyleBackColor = true;
                // 
                // dgvProducts
                // 
                dgvProducts.AllowUserToAddRows = false;
                dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvProducts.Location = new System.Drawing.Point(12, 220);
                dgvProducts.MultiSelect = false;
                dgvProducts.Name = "dgvProducts";
                dgvProducts.ReadOnly = true;
                dgvProducts.RowHeadersWidth = 51;
                dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                dgvProducts.Size = new System.Drawing.Size(760, 220);
                dgvProducts.TabIndex = 2;
                // 
                // FrmQuanLySanPham
                // 
                ClientSize = new System.Drawing.Size(784, 450);
                Controls.Add(dgvProducts);
                Controls.Add(grpActions);
                Controls.Add(grpInfo);
                Name = "FrmQuanLySanPham";
                StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                Text = "Bài 5.3 - Form Quản lý Sản phẩm";
                grpInfo.ResumeLayout(false);
                grpInfo.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
                ((System.ComponentModel.ISupportInitialize)nudUnitPrice).EndInit();
                grpActions.ResumeLayout(false);
                grpActions.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
                ResumeLayout(false);
            }

            #endregion

            private System.Windows.Forms.GroupBox grpInfo;
            private System.Windows.Forms.GroupBox grpActions;
            private System.Windows.Forms.TextBox txtProductId;
            private System.Windows.Forms.TextBox txtProductName;
            private System.Windows.Forms.NumericUpDown nudUnitPrice;
            private System.Windows.Forms.NumericUpDown nudQuantity;
            private System.Windows.Forms.ComboBox cboCategory;
            private System.Windows.Forms.Label lblProductId;
            private System.Windows.Forms.Label lblProductName;
            private System.Windows.Forms.Label lblUnitPrice;
            private System.Windows.Forms.Label lblQuantity;
            private System.Windows.Forms.Label lblCategory;
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Button btnEdit;
            private System.Windows.Forms.Button btnDelete;
            private System.Windows.Forms.TextBox txtSearch;
            private System.Windows.Forms.Button btnSearch;
            private System.Windows.Forms.DataGridView dgvProducts;
        }
    }