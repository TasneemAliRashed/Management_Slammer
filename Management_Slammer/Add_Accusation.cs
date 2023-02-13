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
    public partial class Add_Accusation : Form
    {
        management_dbEntities db = new management_dbEntities();
        public Add_Accusation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Accusation accusation = new Accusation();
                accusation.Name = txtName.Text;
                db.Accusation.Add(accusation);
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
            txtName.Text = null;
            txtName.Focus();
        }
    }
}
