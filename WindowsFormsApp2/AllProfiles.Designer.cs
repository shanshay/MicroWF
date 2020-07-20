namespace WindowsFormsApp2
{
    partial class AllProfiles
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridProfiles = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProfileButton = new System.Windows.Forms.Button();
            this.updateProfileButton = new System.Windows.Forms.Button();
            this.deleteProfileButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfiles
            // 
            this.gridProfiles.AllowUserToAddRows = false;
            this.gridProfiles.AutoGenerateColumns = false;
            this.gridProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.FirstName,
            this.LastName,
            this.Department});
            this.gridProfiles.DataSource = this.profileServiceBindingSource;
            this.gridProfiles.Location = new System.Drawing.Point(2, 28);
            this.gridProfiles.Name = "gridProfiles";
            this.gridProfiles.Size = new System.Drawing.Size(446, 150);
            this.gridProfiles.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // addProfileButton
            // 
            this.addProfileButton.Location = new System.Drawing.Point(2, -1);
            this.addProfileButton.Name = "addProfileButton";
            this.addProfileButton.Size = new System.Drawing.Size(75, 23);
            this.addProfileButton.TabIndex = 1;
            this.addProfileButton.Text = "Add";
            this.addProfileButton.UseVisualStyleBackColor = true;
            this.addProfileButton.Click += new System.EventHandler(this.addProfileButton_Click);
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.Location = new System.Drawing.Point(83, -1);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Size = new System.Drawing.Size(75, 23);
            this.updateProfileButton.TabIndex = 2;
            this.updateProfileButton.Text = "Update";
            this.updateProfileButton.UseVisualStyleBackColor = true;
            this.updateProfileButton.Click += new System.EventHandler(this.updateProfileButton_Click);
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.Location = new System.Drawing.Point(164, -1);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProfileButton.TabIndex = 3;
            this.deleteProfileButton.Text = "Delete";
            this.deleteProfileButton.UseVisualStyleBackColor = true;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Departments";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // profileServiceBindingSource
            // 
            this.profileServiceBindingSource.DataSource = typeof(WindowsFormsApp2.ProfileService);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(WindowsFormsApp2.ProfileService);
            // 
            // AllProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.deleteProfileButton);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.addProfileButton);
            this.Controls.Add(this.gridProfiles);
            this.Name = "AllProfiles";
            this.Text = "Profiles";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProfiles;
        private System.Windows.Forms.Button addProfileButton;
        private System.Windows.Forms.Button updateProfileButton;
        private System.Windows.Forms.Button deleteProfileButton;
        private System.Windows.Forms.Button button4;        
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource profileServiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
    }
}

