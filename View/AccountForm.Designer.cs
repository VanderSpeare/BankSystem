using System.Windows.Forms;

namespace BankSystem.View
{
    partial class AccountForm
    {
        private System.Windows.Forms.GroupBox groupBoxAccountDetails;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelDateOpened;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox textBoxAccountId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOpened;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Button buttonUpdateAccount;
        private System.Windows.Forms.Button buttonDeleteAccount;

        private void InitializeComponent()
        {
            this.groupBoxAccountDetails = new System.Windows.Forms.GroupBox();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.textBoxAccountId = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelDateOpened = new System.Windows.Forms.Label();
            this.dateTimePickerDateOpened = new System.Windows.Forms.DateTimePicker();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.buttonUpdateAccount = new System.Windows.Forms.Button();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.groupBoxAccountDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAccountDetails
            // 
            this.groupBoxAccountDetails.Controls.Add(this.labelAccountId);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxAccountId);
            this.groupBoxAccountDetails.Controls.Add(this.panelButtons);
            this.groupBoxAccountDetails.Controls.Add(this.labelCustomerId);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxCustomerId);
            this.groupBoxAccountDetails.Controls.Add(this.labelDateOpened);
            this.groupBoxAccountDetails.Controls.Add(this.dateTimePickerDateOpened);
            this.groupBoxAccountDetails.Controls.Add(this.labelBalance);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxBalance);
            this.groupBoxAccountDetails.Location = new System.Drawing.Point(41, 7);
            this.groupBoxAccountDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAccountDetails.Name = "groupBoxAccountDetails";
            this.groupBoxAccountDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAccountDetails.Size = new System.Drawing.Size(1076, 189);
            this.groupBoxAccountDetails.TabIndex = 0;
            this.groupBoxAccountDetails.TabStop = false;
            this.groupBoxAccountDetails.Text = "Thông tin tài khoản";
            // 
            // labelAccountId
            // 
            this.labelAccountId.Location = new System.Drawing.Point(56, 26);
            this.labelAccountId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(83, 18);
            this.labelAccountId.TabIndex = 0;
            this.labelAccountId.Text = "Mã tài khoản:";
            // 
            // textBoxAccountId
            // 
            this.textBoxAccountId.Location = new System.Drawing.Point(144, 26);
            this.textBoxAccountId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAccountId.Name = "textBoxAccountId";
            this.textBoxAccountId.Size = new System.Drawing.Size(161, 20);
            this.textBoxAccountId.TabIndex = 1;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.Location = new System.Drawing.Point(56, 50);
            this.labelCustomerId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(83, 18);
            this.labelCustomerId.TabIndex = 2;
            this.labelCustomerId.Text = "Mã khách hàng:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(144, 50);
            this.textBoxCustomerId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(161, 20);
            this.textBoxCustomerId.TabIndex = 3;
            // 
            // labelDateOpened
            // 
            this.labelDateOpened.Location = new System.Drawing.Point(56, 74);
            this.labelDateOpened.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOpened.Name = "labelDateOpened";
            this.labelDateOpened.Size = new System.Drawing.Size(83, 18);
            this.labelDateOpened.TabIndex = 4;
            this.labelDateOpened.Text = "Ngày mở:";
            // 
            // dateTimePickerDateOpened
            // 
            this.dateTimePickerDateOpened.Location = new System.Drawing.Point(144, 74);
            this.dateTimePickerDateOpened.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDateOpened.Name = "dateTimePickerDateOpened";
            this.dateTimePickerDateOpened.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerDateOpened.TabIndex = 5;
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(56, 98);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(83, 18);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "Số dư:";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(144, 98);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(161, 20);
            this.textBoxBalance.TabIndex = 7;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAddAccount);
            this.panelButtons.Controls.Add(this.buttonUpdateAccount);
            this.panelButtons.Controls.Add(this.buttonDeleteAccount);
            this.panelButtons.Location = new System.Drawing.Point(706, 50);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(353, 40);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Location = new System.Drawing.Point(12, 8);
            this.buttonAddAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(80, 24);
            this.buttonAddAccount.TabIndex = 0;
            this.buttonAddAccount.Text = "Thêm";
            // 
            // buttonUpdateAccount
            // 
            this.buttonUpdateAccount.Location = new System.Drawing.Point(136, 8);
            this.buttonUpdateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateAccount.Name = "buttonUpdateAccount";
            this.buttonUpdateAccount.Size = new System.Drawing.Size(80, 24);
            this.buttonUpdateAccount.TabIndex = 0;
            this.buttonUpdateAccount.Text = "Cập nhật";
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Location = new System.Drawing.Point(261, 8);
            this.buttonDeleteAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(80, 24);
            this.buttonDeleteAccount.TabIndex = 2;
            this.buttonDeleteAccount.Text = "Xoá";
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(70, 7);
            this.titleMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(0, 29);
            this.titleMain.TabIndex = 0;
            this.titleMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(41, 201);
            this.dataGridViewAccounts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.RowHeadersWidth = 51;
            this.dataGridViewAccounts.RowTemplate.Height = 24;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(1076, 670);
            this.dataGridViewAccounts.TabIndex = 2;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 882);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.groupBoxAccountDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.groupBoxAccountDetails.ResumeLayout(false);
            this.groupBoxAccountDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}