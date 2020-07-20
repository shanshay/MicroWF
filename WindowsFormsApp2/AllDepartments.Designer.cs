namespace WindowsFormsApp2
{
    partial class AllDepartments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridDepartments = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.updateDepartmentButton = new System.Windows.Forms.Button();
            this.deleteDepartmentButton = new System.Windows.Forms.Button();
            this.profilesShowButton = new System.Windows.Forms.Button();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDepartments
            // 
            this.gridDepartments.AllowUserToAddRows = false;
            this.gridDepartments.AutoGenerateColumns = false;
            this.gridDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Title});
            this.gridDepartments.DataSource = this.departmentBindingSource;
            this.gridDepartments.Location = new System.Drawing.Point(1, 36);
            this.gridDepartments.Name = "gridDepartments";
            this.gridDepartments.Size = new System.Drawing.Size(246, 170);
            this.gridDepartments.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(WindowsFormsApp2.Department);
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(1, -2);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(75, 23);
            this.addDepartmentButton.TabIndex = 1;
            this.addDepartmentButton.Text = "Add";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // updateDepartmentButton
            // 
            this.updateDepartmentButton.Location = new System.Drawing.Point(82, -2);
            this.updateDepartmentButton.Name = "updateDepartmentButton";
            this.updateDepartmentButton.Size = new System.Drawing.Size(75, 23);
            this.updateDepartmentButton.TabIndex = 2;
            this.updateDepartmentButton.Text = "Update";
            this.updateDepartmentButton.UseVisualStyleBackColor = true;
            this.updateDepartmentButton.Click += new System.EventHandler(this.updateDepartmentButton_Click);
            // 
            // deleteDepartmentButton
            // 
            this.deleteDepartmentButton.Location = new System.Drawing.Point(172, -2);
            this.deleteDepartmentButton.Name = "deleteDepartmentButton";
            this.deleteDepartmentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDepartmentButton.TabIndex = 3;
            this.deleteDepartmentButton.Text = "Delete";
            this.deleteDepartmentButton.UseVisualStyleBackColor = true;
            this.deleteDepartmentButton.Click += new System.EventHandler(this.deleteDepartmentButton_Click);
            // 
            // profilesShowButton
            // 
            this.profilesShowButton.Location = new System.Drawing.Point(1, 212);
            this.profilesShowButton.Name = "profilesShowButton";
            this.profilesShowButton.Size = new System.Drawing.Size(75, 23);
            this.profilesShowButton.TabIndex = 4;
            this.profilesShowButton.Text = "Profiles";
            this.profilesShowButton.UseVisualStyleBackColor = true;
            this.profilesShowButton.Click += new System.EventHandler(this.showProfilesButton_Click);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(WindowsFormsApp2.Department);
            // 
            // AllDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profilesShowButton);
            this.Controls.Add(this.deleteDepartmentButton);
            this.Controls.Add(this.updateDepartmentButton);
            this.Controls.Add(this.addDepartmentButton);
            this.Controls.Add(this.gridDepartments);
            this.Name = "AllDepartments";
            this.Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDepartments;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Button updateDepartmentButton;
        private System.Windows.Forms.Button deleteDepartmentButton;
        private System.Windows.Forms.Button profilesShowButton;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}