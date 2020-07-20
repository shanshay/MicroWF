using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    public partial class AllDepartments : Form
    {
        MicroContext microDb;
        public AllDepartments()
        {
            InitializeComponent();

            microDb = new MicroContext();
            microDb.Departments.Load();
            gridDepartments.DataSource = microDb.Departments.Local.ToBindingList();
        }
        // добавление
        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            AddDepartments addDepartments = new AddDepartments();
            DialogResult result = addDepartments.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Department department = new Department();            
            department.Title = addDepartments.textBox1.Text;

            microDb.Departments.Add(department);
            microDb.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
        }          

        private void deleteDepartmentButton_Click(object sender, EventArgs e)
        {
            if (gridDepartments.SelectedRows.Count > 0)
            {
                int index = gridDepartments.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(gridDepartments[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Department department = microDb.Departments.Find(id);
                department.ProfileServices.Clear();
                microDb.Departments.Remove(department);
                microDb.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }
        // редактирование
        private void updateDepartmentButton_Click(object sender, EventArgs e)
        {
            if (gridDepartments.SelectedRows.Count > 0)
            {
                int index = gridDepartments.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(gridDepartments[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Department department = microDb.Departments.Find(id);

                AddDepartments addDepartment = new AddDepartments();
                addDepartment.textBox1.Text = department.Title;                

                DialogResult result = addDepartment.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                department.Title = addDepartment.textBox1.Text;                

                microDb.Entry(department).State = EntityState.Modified;
                microDb.SaveChanges();
                MessageBox.Show("Объект обновлен");
            }
        }
        private void showProfilesButton_Click(object sender, EventArgs e)
        {
            AllProfiles profiles = new AllProfiles();
            profiles.Show();
        }
    }
}
