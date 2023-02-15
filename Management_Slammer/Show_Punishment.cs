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
    public partial class Show_Punishment : Form
    {
        management_dbEntities db = new management_dbEntities();
        public void show()
        {
            dataGridView1.DataSource = (from cat in db.Punishment
                                        select new
                                        {
                                            cat.Id,
                                            cat.Name,
                                        }).ToList();
        }
        public Show_Punishment()
        {
            InitializeComponent();
            show();
        }

        private void Show_Punishment_Load(object sender, EventArgs e)
        {

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
                    var ss = db.Punishment.FirstOrDefault(x => x.Id == id);
                    txtName.Text = ss.Name;
                }
            }
            catch
            {

                MessageBox.Show("لاتوجد بيانات الإجراء العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Punishment punishment = new Punishment();


                if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    int id = int.Parse(txtId.Text);
                    punishment = db.Punishment.FirstOrDefault(x => x.Id == id);
                    punishment.Name = txtName.Text;
                    db.Entry(punishment).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show();

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
                    Punishment punishment = new Punishment();
                    punishment = db.Punishment.Find(id);
                    db.Punishment.Remove(punishment);
                    db.SaveChanges();
                    MessageBox.Show("تمت الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = txtId.Text = null;
            txtId.Focus();
        }
    }
}
