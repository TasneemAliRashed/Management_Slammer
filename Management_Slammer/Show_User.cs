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
    public partial class Show_User : Form
       
    {
        management_dbEntities db = new management_dbEntities();
        public Show_User()
        {
            InitializeComponent();
            dataGridView1.DataSource = (from cat in db.User
                                        select new
                                        {
                                            cat.Id,
                                            cat.Name,
                                            cat.Phone,
                                            cat.LoginName,
                                            cat.PassWord
                                        }).ToList();
        }

        private void Show_User_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();


                if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    int id = int.Parse(txtId.Text);
                    user = db.User.FirstOrDefault(x => x.Id == id);
                    user.Name = txtName.Text;
                    user.Phone = int.Parse(txtPhone.Text);
                    user.LoginName = txtUser_Name.Text;
                    user.PassWord = txtPassword.Text;
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("لاتوجد بيانات الإجراء العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    int id = int.Parse(txtId.Text);
                    User user = new User();
                    user = db.User.Find(id);
                    db.User.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("تمت الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم تتم العملية بنجاح  ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("لاتوجد بيانات الإجراء العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSereach_Click(object sender, EventArgs e)
        {

            try
            {
                txtId.Enabled = true;
                txtId.Focus();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    int id = int.Parse(txtId.Text);
                    var ss = db.User.FirstOrDefault(x => x.Id == id);
                    txtName.Text = ss.Name;
                    txtPhone.Text = ss.Phone.ToString();
                    txtUser_Name.Text = ss.LoginName;
                    txtPassword.Text = ss.PassWord;


                }
            }
            catch
            {

                MessageBox.Show("لاتوجد بيانات الإجراء العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPassword.Text = txtUser_Name.Text = txtId.Text = txtPhone.Text = null;
            txtId.Focus();
        }
    }

   
    
}
