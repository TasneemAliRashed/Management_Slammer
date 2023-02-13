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
    public partial class Show_Slammer : Form
    {
        management_dbEntities db = new management_dbEntities();
        public Show_Slammer()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    int id = int.Parse(txtId.Text);
                    Prisoner prisoner = new Prisoner();
                    prisoner = db.Prisoner.Find(id);
                    db.Prisoner.Remove(prisoner);
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
           txtAge.Text=txtId.Text= txtName.Text = txtPhone.Text = comErea.Text = comPunshment.Text = conAccusation.Text = Date_Of_Enter.Text = Date_Of_Out.Text = null;
        }
    }
}
