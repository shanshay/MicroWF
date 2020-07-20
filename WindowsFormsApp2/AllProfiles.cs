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
    public partial class AllProfiles : Form
    {
        MicroContext microDb;
        public AllProfiles()
        {
            InitializeComponent();
            microDb = new MicroContext();
            microDb.ProfileServices.Load();
            gridProfiles.DataSource = microDb.ProfileServices.Local.ToBindingList();
        }

        private void addProfileButton_Click(object sender, EventArgs e)
        {
            AddProfiles addProfile = new AddProfiles();

            // из команд в бд формируем список
            List<Department> departments = microDb.Departments.ToList();
            addProfile.chooseProfileDepartment.DataSource = departments;
            addProfile.chooseProfileDepartment.ValueMember = "Id";
            addProfile.chooseProfileDepartment.DisplayMember = "Title";

            DialogResult result = addProfile.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            ProfileService profile = new ProfileService();            
            profile.FirstName = addProfile.addProfileFirstName.Text;
            profile.LastName = addProfile.addProfileLastName.Text;
            profile.Department = (Department)addProfile.chooseProfileDepartment.SelectedItem;

            microDb.ProfileServices.Add(profile);
            microDb.SaveChanges();

            MessageBox.Show("New object was added");
        }

        // редактирование
        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            if (gridProfiles.SelectedRows.Count > 0)
            {
                int index = gridProfiles.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(gridProfiles[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                ProfileService profile = microDb.ProfileServices.Find(id);

                AddProfiles addProfile = new AddProfiles();                
                addProfile.addProfileLastName.Text = profile.FirstName;
                addProfile.addProfileFirstName.Text = profile.LastName;

                List<Department> departments = microDb.Departments.ToList();
                addProfile.chooseProfileDepartment.DataSource = departments;
                addProfile.chooseProfileDepartment.ValueMember = "Id";
                addProfile.chooseProfileDepartment.DisplayMember = "Title";

                if (profile.Department != null)
                    addProfile.chooseProfileDepartment.SelectedValue = profile.Department.Id;

                DialogResult result = addProfile.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;
                
                profile.FirstName = addProfile.addProfileFirstName.Text;
                profile.LastName = addProfile.addProfileLastName.Text;
                profile.Department = (Department)addProfile.chooseProfileDepartment.SelectedItem;

                microDb.Entry(profile).State = EntityState.Modified;
                microDb.SaveChanges();

                MessageBox.Show("Object was updated");
            }
        }
        // удаление
        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            if (gridProfiles.SelectedRows.Count > 0)
            {
                int index = gridProfiles.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(gridProfiles[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                ProfileService profile = microDb.ProfileServices.Find(id);
                microDb.ProfileServices.Remove(profile);
                microDb.SaveChanges();

                MessageBox.Show("Object was deleted");
            }
        }
        // открываем форму с командами
        private void button4_Click(object sender, EventArgs e)
        {
            AllDepartments departments = new AllDepartments();
            departments.Show();
        }
    }
}
