using BankSystem.Controller;
using BankSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BankSystem.View
{
    public partial class BranchForm : Form, IView
    {
        private BranchController controller;
        private Branch currentBranch;
        private BankSystemContext db;
        public BranchForm()
        {
            InitializeComponent();
            controller = new BranchController();
            InitializeDataGridView();
            LoadBranchesFromDatabase();
            db = new BankSystemContext(new DbContextOptions<BankSystemContext>());
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewBranches.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn branchIdColumn = new DataGridViewTextBoxColumn();
            branchIdColumn.HeaderText = "Mã chi nhánh";
            branchIdColumn.DataPropertyName = "Id";
            branchIdColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(branchIdColumn);

            DataGridViewTextBoxColumn branchNameColumn = new DataGridViewTextBoxColumn();
            branchNameColumn.HeaderText = "Chi nhánh";
            branchNameColumn.DataPropertyName = "Name";
            branchNameColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(branchNameColumn);

            DataGridViewTextBoxColumn houseNoColumn = new DataGridViewTextBoxColumn();
            houseNoColumn.HeaderText = "Số nhà";
            houseNoColumn.DataPropertyName = "HouseNo";
            houseNoColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(houseNoColumn);

            DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn();
            cityColumn.HeaderText = "Thành phố";
            cityColumn.DataPropertyName = "City";
            cityColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(cityColumn);
        }

        // Load danh sách chi nhánh từ cơ sở dữ liệu
        private void LoadBranchesFromDatabase()
        {
            controller.Load();
            var branchs = controller.Items.Cast<Branch>().ToList();
            dataGridViewBranches.DataSource = branchs;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentBranch == null) currentBranch = new Branch();

            currentBranch.Id = textBoxBranchId.Text;
            currentBranch.Name = textBoxBranchName.Text;
            currentBranch.HouseNo = textBoxBranchHouseNo.Text;
            currentBranch.City = textBoxBranchCity.Text;
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var branch = item as Branch;
            if (branch != null)
            {
                textBoxBranchId.Text = branch.Id;
                textBoxBranchName.Text = branch.Name;
                textBoxBranchHouseNo.Text = branch.HouseNo;
                textBoxBranchCity.Text = branch.City;
            }
        }

        // Thêm chi nhánh
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBranchId.Text) || string.IsNullOrEmpty(textBoxBranchName.Text))
            {
                MessageBox.Show("Cần nhập Mã chi nhánh và Tên chi nhánh.");
                return;
            }

            GetDataFromText();

            // Ensure currentBranch is initialized
            if (currentBranch == null)
            {
                MessageBox.Show("Không thể thêm Chi nhánh. Dữ liệu không hợp lệ.");
                return;
            }

            // Create the branch
            if (!controller.Create(new currentBranch)) // Remove redundant dbBranch parameters if not needed
            {
                MessageBox.Show("Không thể thêm Chi nhánh.");
            }
            else
            {
                LoadBranchesFromDatabase();
                MessageBox.Show("Đã thêm Chi nhánh thành công.");
            }
        }

        // Cập nhật chi nhánh
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewBranches.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow == null)
            {
                MessageBox.Show("Chưa chọn Chi nhánh để cập nhật.");
                return;
            }

            GetDataFromText();

            // Ensure currentBranch is initialized
            if (currentBranch == null)
            {
                MessageBox.Show("Không thể cập nhật Chi nhánh. Dữ liệu không hợp lệ.");
                return;
            }

            // Update the branch
            if (controller.Update(currentBranch))
            {
                LoadBranchesFromDatabase();
                MessageBox.Show("Cập nhật Chi nhánh thành công.");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật Chi nhánh.");
            }
        }


        // Hiển thị xác nhận trước khi xoá
        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá chi nhánh?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadBranchesFromDatabase();
                MessageBox.Show("Đã xoá chi nhánh thành công.");
            }
        }

        // Thêm hoặc cập nhật chi nhánh
        private void buttonSave_Click(object sender, EventArgs e)
        {
            GetDataFromText();
            if (controller.IsExist(currentBranch.Id))
            {
                // Corrected Update call
                if (controller.Update(currentBranch))
                {
                    MessageBox.Show("Cập nhật chi nhánh thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật chi nhánh.");
                }
            }
            else
            {
                // Corrected Create call with no redundant parameters
                if (controller.Create(currentBranch))
                {
                    MessageBox.Show("Đã thêm chi nhánh thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể thêm chi nhánh.");
                }
            }
            LoadBranchesFromDatabase();
            ClearForm();
        }

        // Xóa chi nhánh
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewBranches.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                Branch branch = selectedRow.DataBoundItem as Branch;

                if (branch != null)
                {
                    // Confirm delete before calling the delete method
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá chi nhánh?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (controller.Delete(branch.Id))
                        {
                            LoadBranchesFromDatabase();
                            MessageBox.Show("Đã xoá chi nhánh thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá chi nhánh.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn chi nhánh để xoá.");
            }
        }


        // Hiển thị thông tin chi nhánh khi chọn trong DataGridView
        private void dataGridViewBranches_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewBranches.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var branch = (Branch)selectedRow.DataBoundItem;
                SetDataToText(branch);
            }
        }

        // Xoá dữ liệu form
        private void ClearForm()
        {
            textBoxBranchId.Clear();
            textBoxBranchName.Clear();
            textBoxBranchHouseNo.Clear();
            textBoxBranchCity.Clear();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}