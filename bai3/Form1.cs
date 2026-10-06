using System.ComponentModel;

namespace THB3_6_10_
{
    public partial class Form1 : Form
    {
        private BindingList<Product> _productList = new();

        public Form1()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = _productList;

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSearch.Click += BtnSearch_Click;
            dgvProducts.CellClick += DgvProducts_CellClick;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text) || string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_productList.Any(p => p.ProductId.Equals(txtProductId.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = nudUnitPrice.Value,
                Quantity = (int)nudQuantity.Value,
                Category = cboCategory.SelectedItem?.ToString() ?? "Chưa phân loại"
            };

            _productList.Add(product);
            ClearFields();
        }

        private void DgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].DataBoundItem is Product selectedProduct)
            {
                txtProductId.Text = selectedProduct.ProductId;
                txtProductName.Text = selectedProduct.ProductName;
                nudUnitPrice.Value = selectedProduct.UnitPrice;
                nudQuantity.Value = selectedProduct.Quantity;
                cboCategory.SelectedItem = selectedProduct.Category;
            }
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            var product = _productList.FirstOrDefault(p => p.ProductId == txtProductId.Text);
            if (product != null)
            {
                product.ProductName = txtProductName.Text.Trim();
                product.UnitPrice = nudUnitPrice.Value;
                product.Quantity = (int)nudQuantity.Value;
                product.Category = cboCategory.SelectedItem?.ToString() ?? "Chưa phân loại";
                _productList.ResetBindings();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var product = _productList.FirstOrDefault(p => p.ProductId == txtProductId.Text);
            if (product != null)
            {
                var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {product.ProductName}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    _productList.Remove(product);
                    ClearFields();
                }
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filtered = _productList.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
            dgvProducts.DataSource = new BindingList<Product>(filtered);
        }

        private void ClearFields()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            nudUnitPrice.Value = 0;
            nudQuantity.Value = 0;
            cboCategory.SelectedIndex = -1;
        }
    }
}