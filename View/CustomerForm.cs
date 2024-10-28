﻿using BankSystem.Controller;
using BankSystem.Model;
using BankSystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BankSystem.View
{
    public partial class CustomerForm : Form, IView
    {
        private CustomerController customerController = new CustomerController();
        private Customer currentCustomer;

        public CustomerForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadCustomersFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewCustomers.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn accountIdColumn = new DataGridViewTextBoxColumn();
            accountIdColumn.HeaderText = "ID";
            accountIdColumn.DataPropertyName = "Id";
            dataGridViewCustomers.Columns.Add(accountIdColumn);

            DataGridViewTextBoxColumn customerIdColumn = new DataGridViewTextBoxColumn();
            customerIdColumn.HeaderText = "Name";
            customerIdColumn.DataPropertyName = "Name";
            dataGridViewCustomers.Columns.Add(customerIdColumn);

            DataGridViewTextBoxColumn dateOpenedColumn = new DataGridViewTextBoxColumn();
            dateOpenedColumn.HeaderText = "Phone";
            dateOpenedColumn.DataPropertyName = "Phone";
            dataGridViewCustomers.Columns.Add(dateOpenedColumn);

            DataGridViewTextBoxColumn balanceColumn = new DataGridViewTextBoxColumn();
            balanceColumn.HeaderText = "Email";
            balanceColumn.DataPropertyName = "Email";
            dataGridViewCustomers.Columns.Add(balanceColumn);

            DataGridViewTextBoxColumn houseNoColumn = new DataGridViewTextBoxColumn();
            houseNoColumn.HeaderText = "House No";
            houseNoColumn.DataPropertyName = "HouseNo";
            dataGridViewCustomers.Columns.Add(houseNoColumn);

            DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn();
            cityColumn.HeaderText = "City";
            cityColumn.DataPropertyName = "City";
            dataGridViewCustomers.Columns.Add(cityColumn);

            DataGridViewTextBoxColumn pinColum = new DataGridViewTextBoxColumn();
            pinColum.HeaderText = "Pin";
            pinColum.DataPropertyName = "Pin";
            dataGridViewCustomers.Columns.Add(pinColum);
        }

        // Load danh sách khách hàng từ CSDL
        private void LoadCustomersFromDatabase()
        {
            customerController.Load();
            var customers = customerController.Items.Cast<Customer>().ToList();
            dataGridViewCustomers.DataSource = customers;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentCustomer == null) currentCustomer = new Customer();

            currentCustomer.Id = textBoxId.Text;
            currentCustomer.Name = textBoxName.Text;
            currentCustomer.Phone = textBoxPhone.Text;
            currentCustomer.Email = textBoxEmail.Text;
            currentCustomer.HouseNo = textBoxHouseNo.Text;
            currentCustomer.City = textBoxCity.Text;
            currentCustomer.Pin = textBoxPin.Text;
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var customer = item as Customer;
            if (customer != null)
            {
                textBoxId.Text = customer.Id;
                textBoxName.Text = customer.Name;
                textBoxPhone.Text = customer.Phone;
                textBoxEmail.Text = customer.Email;
                textBoxHouseNo.Text = customer.HouseNo;
                textBoxCity.Text = customer.City;
                textBoxPin.Text = customer.Pin;
            }
        }

        // Thêm khách hàng
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("nhập ID và Tên.");
                return;
            }

            GetDataFromText();
            if (customerController.Create(currentCustomer, dbEmployees, dbBranch))
            {
                LoadCustomersFromDatabase();
                MessageBox.Show("Đã thêm Khách hàng thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Khách hàng.");
            }
        }

        // Cập nhật khách hàng
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewCustomers.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                GetDataFromText();
                if (customerController.Update(currentCustomer))
                {
                    LoadCustomersFromDatabase();
                    MessageBox.Show("Cập nhật Khách hàng thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật Khách hàng.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Khách hàng để cập nhật.");
            }
        }

        // Xóa khách hàng
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewCustomers.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                Customer customer = selectedRow.DataBoundItem as Customer;

                if (customerController.Delete(customer.Id))
                {
                    ConfirmDelete();
                }
                else
                {
                    MessageBox.Show("Không thể xoá Khách hàng.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Khách hàng để xoá.");
            }
        }

        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadCustomersFromDatabase();
                MessageBox.Show("Đã xoá Khách hàng thành công.");
            }
        }

        // Hiển thị thông tin khách hàng khi chọn trong DataGridView
        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewCustomers.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var customer = (Customer)selectedRow.DataBoundItem;
                SetDataToText(customer);
            }
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

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
