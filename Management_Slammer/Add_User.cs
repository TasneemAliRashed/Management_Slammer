using Management_Slammer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Slammer
{
    public partial class Add_User : Form
    {
        management_dbEntities db = new management_dbEntities();
        
        public Add_User()
        {
            InitializeComponent();
           
            
        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                User user = new User();
                user.Name = txtName.Text;
                user.Phone = int.Parse( txtPhone.Text);
                user.PassWord = txtPassword.Text;
                user.LoginName = txtUser_Name.Text;
                db.User.Add(user);
                db.SaveChanges();
                MessageBox.Show("تمت الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("لاتوجد بيانات الإجراء العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPassword.Text = txtPhone.Text = txtUser_Name.Text = null;
            txtName.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
