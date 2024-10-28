using System.Windows.Forms;

namespace BankSystem.View
{
    partial class CustomerForm
    {
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelHouseNo;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxHouseNo;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelHouseNo = new System.Windows.Forms.Label();
            this.textBoxHouseNo = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.labelId);
            this.groupBoxDetails.Controls.Add(this.panelButtons);
            this.groupBoxDetails.Controls.Add(this.textBoxId);
            this.groupBoxDetails.Controls.Add(this.labelName);
            this.groupBoxDetails.Controls.Add(this.textBoxName);
            this.groupBoxDetails.Controls.Add(this.labelEmail);
            this.groupBoxDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxDetails.Controls.Add(this.labelPhone);
            this.groupBoxDetails.Controls.Add(this.textBoxPhone);
            this.groupBoxDetails.Controls.Add(this.labelHouseNo);
            this.groupBoxDetails.Controls.Add(this.textBoxHouseNo);
            this.groupBoxDetails.Controls.Add(this.labelCity);
            this.groupBoxDetails.Controls.Add(this.textBoxCity);
            this.groupBoxDetails.Controls.Add(this.labelPin);
            this.groupBoxDetails.Controls.Add(this.textBoxPin);
            this.groupBoxDetails.Location = new System.Drawing.Point(9, 56);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDetails.Size = new System.Drawing.Size(1110, 216);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Thông tin khách hàng";
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(30, 61);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(67, 15);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID khách hàng:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAddCustomer);
            this.panelButtons.Controls.Add(this.buttonUpdateCustomer);
            this.panelButtons.Controls.Add(this.buttonDeleteCustomer);
            this.panelButtons.Location = new System.Drawing.Point(668, 170);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(135, 46);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddCustomer.BackgroundImage")));
            this.buttonAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddCustomer.Location = new System.Drawing.Point(2, 2);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(42, 40);
            this.buttonAddCustomer.TabIndex = 0;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdateCustomer.BackgroundImage")));
            this.buttonUpdateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(91, 2);
            this.buttonUpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(42, 40);
            this.buttonUpdateCustomer.TabIndex = 1;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteCustomer.BackgroundImage")));
            this.buttonDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteCustomer.Image")));
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(48, 2);
            this.buttonDeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(42, 40);
            this.buttonDeleteCustomer.TabIndex = 2;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(116, 56);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(221, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(30, 96);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Tên khách hàng:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 96);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(221, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(30, 138);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(67, 15);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(116, 133);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(221, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(30, 176);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(81, 15);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Số điện thoại:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(116, 173);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(221, 20);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelHouseNo
            // 
            this.labelHouseNo.Location = new System.Drawing.Point(387, 61);
            this.labelHouseNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHouseNo.Name = "labelHouseNo";
            this.labelHouseNo.Size = new System.Drawing.Size(67, 15);
            this.labelHouseNo.TabIndex = 8;
            this.labelHouseNo.Text = "Số nhà:";
            // 
            // textBoxHouseNo
            // 
            this.textBoxHouseNo.Location = new System.Drawing.Point(458, 61);
            this.textBoxHouseNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHouseNo.Name = "textBoxHouseNo";
            this.textBoxHouseNo.Size = new System.Drawing.Size(345, 20);
            this.textBoxHouseNo.TabIndex = 9;
            // 
            // labelCity
            // 
            this.labelCity.Location = new System.Drawing.Point(387, 101);
            this.labelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(67, 15);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "Thành phố:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(458, 101);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(343, 20);
            this.textBoxCity.TabIndex = 11;
            // 
            // labelPin
            // 
            this.labelPin.Location = new System.Drawing.Point(387, 138);
            this.labelPin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(67, 15);
            this.labelPin.TabIndex = 12;
            this.labelPin.Text = "Pin:";
            // 
            // textBoxPin
            // 
            this.textBoxPin.Location = new System.Drawing.Point(458, 135);
            this.textBoxPin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(345, 20);
            this.textBoxPin.TabIndex = 13;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(11, 276);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1108, 620);
            this.dataGridViewCustomers.TabIndex = 2;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 907);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.groupBoxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
