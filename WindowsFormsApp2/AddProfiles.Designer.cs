namespace WindowsFormsApp2
{
    partial class AddProfiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addProfileFirstName = new System.Windows.Forms.TextBox();
            this.chooseProfileDepartment = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addProfileLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // addProfileFirstName
            // 
            this.addProfileFirstName.Location = new System.Drawing.Point(140, 63);
            this.addProfileFirstName.Name = "addProfileFirstName";
            this.addProfileFirstName.Size = new System.Drawing.Size(171, 20);
            this.addProfileFirstName.TabIndex = 4;
            // 
            // chooseProfileDepartment
            // 
            this.chooseProfileDepartment.FormattingEnabled = true;
            this.chooseProfileDepartment.Location = new System.Drawing.Point(140, 203);
            this.chooseProfileDepartment.Name = "chooseProfileDepartment";
            this.chooseProfileDepartment.Size = new System.Drawing.Size(171, 21);
            this.chooseProfileDepartment.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(91, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(236, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addProfileLastName
            // 
            this.addProfileLastName.Location = new System.Drawing.Point(140, 102);
            this.addProfileLastName.Name = "addProfileLastName";
            this.addProfileLastName.Size = new System.Drawing.Size(171, 20);
            this.addProfileLastName.TabIndex = 10;
            // 
            // AddProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addProfileLastName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseProfileDepartment);
            this.Controls.Add(this.addProfileFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProfiles";
            this.Text = "Add Or Update Profiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox addProfileFirstName;
        protected internal System.Windows.Forms.ComboBox chooseProfileDepartment;
        protected internal System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.TextBox addProfileLastName;
    }
}