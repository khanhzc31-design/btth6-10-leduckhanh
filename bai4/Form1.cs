namespace THB4_6_10_
{
    public partial class Form1 : Form
    {
            private List<Employee> _employees = new();

            public Form1()
            {
                InitializeComponent();
                InitListViewColumns();
                InitData();
                InitTreeView();
                InitViewComboBox();
            }

            private void InitListViewColumns()
            {
                lsvEmployees.View = View.Details;
                lsvEmployees.FullRowSelect = true;
                lsvEmployees.GridLines = true;

                lsvEmployees.Columns.Add("Mã NV", 100);
                lsvEmployees.Columns.Add("Họ Tên", 180);
                lsvEmployees.Columns.Add("Chức vụ", 150);
                lsvEmployees.Columns.Add("Ngày vào làm", 120);
            }

            private void InitData()
            {
                _employees = new List<Employee>
            {
                new Employee { EmployeeId = "NV001", FullName = "Nguyễn Văn A", Position = "Trưởng nhóm", StartDate = new DateTime(2020, 1, 15), GroupTag = "DEV_NET" },
                new Employee { EmployeeId = "NV002", FullName = "Trần Thị B", Position = "Lập trình viên", StartDate = new DateTime(2021, 5, 20), GroupTag = "DEV_NET" },
                new Employee { EmployeeId = "NV003", FullName = "Lê Văn C", Position = "Tester", StartDate = new DateTime(2022, 3, 10), GroupTag = "DEV_TEST" },
                new Employee { EmployeeId = "NV004", FullName = "Phạm Hoàng D", Position = "Chuyên viên HR", StartDate = new DateTime(2019, 8, 1), GroupTag = "HR_RECRUIT" }
            };
            }

            private void InitTreeView()
            {
                tvDepartments.Nodes.Clear();

                TreeNode rootNode = new TreeNode("Công ty ABC") { Tag = "COMPANY" };

                TreeNode devDept = new TreeNode("Phòng Công nghệ Thông tin") { Tag = "DEPT_IT" };
                TreeNode netGroup = new TreeNode("Nhóm .NET") { Tag = "DEV_NET" };
                TreeNode testGroup = new TreeNode("Nhóm Kiểm thử") { Tag = "DEV_TEST" };
                devDept.Nodes.Add(netGroup);
                devDept.Nodes.Add(testGroup);

                TreeNode hrDept = new TreeNode("Phòng Nhân sự") { Tag = "DEPT_HR" };
                TreeNode recruitGroup = new TreeNode("Nhóm Tuyển dụng") { Tag = "HR_RECRUIT" };
                hrDept.Nodes.Add(recruitGroup);

                rootNode.Nodes.Add(devDept);
                rootNode.Nodes.Add(hrDept);

                tvDepartments.Nodes.Add(rootNode);
                tvDepartments.ExpandAll();

                tvDepartments.AfterSelect += TvDepartments_AfterSelect;
            }

            private void InitViewComboBox()
            {
                cboViewMode.DataSource = Enum.GetValues(typeof(View));
                cboViewMode.SelectedIndexChanged += (s, e) =>
                {
                    if (cboViewMode.SelectedItem is View selectedView)
                    {
                        lsvEmployees.View = selectedView;
                    }
                };
            }

            private void TvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
            {
                if (e.Node == null) return;

                string selectedTag = e.Node.Tag?.ToString() ?? string.Empty;
                lsvEmployees.Items.Clear();

                var filteredEmployees = _employees.Where(emp =>
                    emp.GroupTag == selectedTag || selectedTag == "COMPANY" || selectedTag.StartsWith("DEPT_")
                );

                foreach (var emp in filteredEmployees)
                {
                    ListViewItem item = new ListViewItem(emp.EmployeeId)
                    {
                        ImageIndex = 0
                    };
                    item.SubItems.Add(emp.FullName);
                    item.SubItems.Add(emp.Position);
                    item.SubItems.Add(emp.StartDate.ToString("dd/MM/yyyy"));

                    lsvEmployees.Items.Add(item);
                }
            }
        }
    }