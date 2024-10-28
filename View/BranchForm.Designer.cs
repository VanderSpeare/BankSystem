﻿using System.Drawing;
using System.Windows.Forms;

namespace BankSystem.View
{
    partial class BranchForm
    {
        private System.Windows.Forms.GroupBox groupBoxBranchDetails;
        private System.Windows.Forms.Label labelBranchId;
        private System.Windows.Forms.Label labelBranchName;
        private System.Windows.Forms.Label labelBranchHouseNo;
        private System.Windows.Forms.Label labelBranchCity;
        private System.Windows.Forms.TextBox textBoxBranchId;
        private System.Windows.Forms.TextBox textBoxBranchName;
        private System.Windows.Forms.TextBox textBoxBranchHouseNo;
        private System.Windows.Forms.TextBox textBoxBranchCity;
        private System.Windows.Forms.DataGridView dataGridViewBranches;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;

        private void InitializeComponent()
        {
            this.groupBoxBranchDetails = new System.Windows.Forms.GroupBox();
            this.labelBranchId = new System.Windows.Forms.Label();
            this.textBoxBranchId = new System.Windows.Forms.TextBox();
            this.labelBranchName = new System.Windows.Forms.Label();
            this.textBoxBranchName = new System.Windows.Forms.TextBox();
            this.labelBranchHouseNo = new System.Windows.Forms.Label();
            this.textBoxBranchHouseNo = new System.Windows.Forms.TextBox();
            this.labelBranchCity = new System.Windows.Forms.Label();
            this.textBoxBranchCity = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.dataGridViewBranches = new System.Windows.Forms.DataGridView();
            this.groupBoxBranchDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBranchDetails
            // 
            this.groupBoxBranchDetails.Controls.Add(this.labelBranchId);
            this.groupBoxBranchDetails.Controls.Add(this.textBoxBranchId);
            this.groupBoxBranchDetails.Controls.Add(this.labelBranchName);
            this.groupBoxBranchDetails.Controls.Add(this.textBoxBranchName);
            this.groupBoxBranchDetails.Controls.Add(this.labelBranchHouseNo);
            this.groupBoxBranchDetails.Controls.Add(this.textBoxBranchHouseNo);
            this.groupBoxBranchDetails.Controls.Add(this.labelBranchCity);
            this.groupBoxBranchDetails.Controls.Add(this.textBoxBranchCity);
            this.groupBoxBranchDetails.Location = new System.Drawing.Point(10, 76);
            this.groupBoxBranchDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBranchDetails.Name = "groupBoxBranchDetails";
            this.groupBoxBranchDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBranchDetails.Size = new System.Drawing.Size(537, 83);
            this.groupBoxBranchDetails.TabIndex = 0;
            this.groupBoxBranchDetails.TabStop = false;
            this.groupBoxBranchDetails.Text = "Thông tin chi nhánh";
            // 
            // labelBranchId
            // 
            this.labelBranchId.Location = new System.Drawing.Point(12, 24);
            this.labelBranchId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBranchId.Name = "labelBranchId";
            this.labelBranchId.Size = new System.Drawing.Size(64, 18);
            this.labelBranchId.TabIndex = 0;
            this.labelBranchId.Text = "ID:";
            // 
            // textBoxBranchId
            // 
            this.textBoxBranchId.Location = new System.Drawing.Point(81, 24);
            this.textBoxBranchId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBranchId.Name = "textBoxBranchId";
            this.textBoxBranchId.Size = new System.Drawing.Size(161, 20);
            this.textBoxBranchId.TabIndex = 1;
            // 
            // labelBranchName
            // 
            this.labelBranchName.Location = new System.Drawing.Point(12, 48);
            this.labelBranchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBranchName.Name = "labelBranchName";
            this.labelBranchName.Size = new System.Drawing.Size(64, 18);
            this.labelBranchName.TabIndex = 2;
            this.labelBranchName.Text = "Tên:";
            // 
            // textBoxBranchName
            // 
            this.textBoxBranchName.Location = new System.Drawing.Point(81, 48);
            this.textBoxBranchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBranchName.Name = "textBoxBranchName";
            this.textBoxBranchName.Size = new System.Drawing.Size(161, 20);
            this.textBoxBranchName.TabIndex = 3;
            // 
            // labelBranchHouseNo
            // 
            this.labelBranchHouseNo.Location = new System.Drawing.Point(280, 22);
            this.labelBranchHouseNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBranchHouseNo.Name = "labelBranchHouseNo";
            this.labelBranchHouseNo.Size = new System.Drawing.Size(80, 18);
            this.labelBranchHouseNo.TabIndex = 4;
            this.labelBranchHouseNo.Text = "Số nhà:";
            // 
            // textBoxBranchHouseNo
            // 
            this.textBoxBranchHouseNo.Location = new System.Drawing.Point(364, 22);
            this.textBoxBranchHouseNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBranchHouseNo.Name = "textBoxBranchHouseNo";
            this.textBoxBranchHouseNo.Size = new System.Drawing.Size(161, 20);
            this.textBoxBranchHouseNo.TabIndex = 5;
            // 
            // labelBranchCity
            // 
            this.labelBranchCity.Location = new System.Drawing.Point(280, 46);
            this.labelBranchCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBranchCity.Name = "labelBranchCity";
            this.labelBranchCity.Size = new System.Drawing.Size(80, 18);
            this.labelBranchCity.TabIndex = 6;
            this.labelBranchCity.Text = "Thành phố:";
            // 
            // textBoxBranchCity
            // 
            this.textBoxBranchCity.Location = new System.Drawing.Point(364, 46);
            this.textBoxBranchCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBranchCity.Name = "textBoxBranchCity";
            this.textBoxBranchCity.Size = new System.Drawing.Size(161, 20);
            this.textBoxBranchCity.TabIndex = 7;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Location = new System.Drawing.Point(10, 322);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(537, 40);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 8);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 24);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Thêm";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(228, 8);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 24);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Cập nhật";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(444, 8);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 24);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Xoá";
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(166, 12);
            this.titleMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(0, 29);
            this.titleMain.TabIndex = 0;
            // 
            // titleSub
            // 
            this.titleSub.AutoSize = true;
            this.titleSub.Font = new System.Drawing.Font("Arial", 11F);
            this.titleSub.ForeColor = System.Drawing.Color.Black;
            this.titleSub.Location = new System.Drawing.Point(142, 40);
            this.titleSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(0, 17);
            this.titleSub.TabIndex = 1;
            // 
            // dataGridViewBranches
            // 
            this.dataGridViewBranches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBranches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBranches.Location = new System.Drawing.Point(10, 164);
            this.dataGridViewBranches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBranches.Name = "dataGridViewBranches";
            this.dataGridViewBranches.RowHeadersWidth = 51;
            this.dataGridViewBranches.RowTemplate.Height = 24;
            this.dataGridViewBranches.Size = new System.Drawing.Size(537, 153);
            this.dataGridViewBranches.TabIndex = 2;
            this.dataGridViewBranches.SelectionChanged += new System.EventHandler(this.dataGridViewBranches_SelectionChanged);
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(555, 371);
            this.Controls.Add(this.dataGridViewBranches);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxBranchDetails);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BranchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi nhánh";
            this.groupBoxBranchDetails.ResumeLayout(false);
            this.groupBoxBranchDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}