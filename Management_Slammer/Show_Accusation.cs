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
    public partial class Show_Accusation : Form
    {
        management_dbEntities db = new management_dbEntities();
        public Show_Accusation()
        {
            InitializeComponent();
            dataGridView1.DataSource = (from cat in db.Accusation
                                        select new
                                        {
                                            cat.Id,
                                            cat.Name,
                                        }).ToList();
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
                    var ss = db.Accusation.FirstOrDefault(x => x.Id == id);
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
                Accusation accusation = new Accusation();


                if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    int id = int.Parse(txtId.Text);
                    accusation = db.Accusation.FirstOrDefault(x => x.Id == id);
                    accusation.Name = txtName.Text;
                    db.Entry(accusation).State = System.Data.Entity.EntityState.Modified;
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
                    Accusation accusation = new Accusation();
                    accusation = db.Accusation.Find(id);
                    db.Accusation.Remove(accusation);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = txtName.Text = null;
            txtId.Focus();
        }

        private void Show_Accusation_Load(object sender, EventArgs e)
        {

        }
    }
}
