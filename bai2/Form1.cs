using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace THB2_6_10_
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<ServiceItem>> _categoryData = new();
        public Form1()
        {
            InitializeComponent();
            InitData();
            RegisterEvents();
        }
        private void InitData()
        {
            _categoryData = new Dictionary<string, List<ServiceItem>>
            {
                ["Khám bệnh"] = new()
                {
                    new ServiceItem("Khám tổng quát", 150000),
                    new ServiceItem("Khám chuyên khoa", 250000),
                    new ServiceItem("Khám cấp cứu", 300000)
                },
                ["Xét nghiệm"] = new()
                {
                    new ServiceItem("Xét nghiệm máu", 120000),
                    new ServiceItem("Xét nghiệm nước tiểu", 80000),
                    new ServiceItem("Xét nghiệm đường huyết", 50000)
                },
                ["Chụp X-Quang"] = new()
                {
                    new ServiceItem("X-Quang Phổi", 200000),
                    new ServiceItem("X-Quang Cột sống", 250000),
                    new ServiceItem("X-Quang Tay/Chân", 180000)
                },
                ["Vắc-xin"] = new()
                {
                    new ServiceItem("Tiêm Cúm mùa", 350000),
                    new ServiceItem("Tiêm Viêm gan B", 280000),
                    new ServiceItem("Tiêm Quai bị - Sởi - Rubella", 420000)
                }
            };

            cboCategory.DataSource = _categoryData.Keys.ToList();
            nudDiscount.ValueChanged += (s, e) => CalculateTotal();
        }

        private void RegisterEvents()
        {
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
            lstAvailableServices.DoubleClick += (s, e) => MoveSelectedService();
            btnSelect.Click += (s, e) => MoveSelectedService();
            btnRemove.Click += BtnRemove_Click;
            btnClearAll.Click += BtnClearAll_Click;
        }

        private void CboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboCategory.SelectedItem is string selectedCategory && _categoryData.ContainsKey(selectedCategory))
            {
                lstAvailableServices.DataSource = null;
                lstAvailableServices.DataSource = _categoryData[selectedCategory];
            }
        }

        private void MoveSelectedService()
        {
            if (lstAvailableServices.SelectedItem is ServiceItem item)
            {
                bool exists = lstSelectedServices.Items.Cast<ServiceItem>().Any(x => x.Name == item.Name);
                if (!exists)
                {
                    lstSelectedServices.Items.Add(item);
                    CalculateTotal();
                }
            }
        }

        private void BtnRemove_Click(object? sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                CalculateTotal();
            }
        }

        private void BtnClearAll_Click(object? sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = lstSelectedServices.Items.Cast<ServiceItem>().Sum(item => item.Price);
            decimal discountPercent = nudDiscount.Value;
            decimal finalTotal = total * (1 - (discountPercent / 100));

            txtTotalAmount.Text = total.ToString("N0") + " VNĐ";
            txtFinalTotal.Text = finalTotal.ToString("N0") + " VNĐ";
        }
    }
}
