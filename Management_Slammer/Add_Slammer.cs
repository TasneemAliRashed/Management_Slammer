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

    public partial class Add_Slammer : Form
    {
        management_dbEntities db = new management_dbEntities();
        public Add_Slammer()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAge.Text = txtName.Text = txtPhone.Text = comErea.Text = comPunshment.Text = conAccusation.Text = Date_Of_Enter.Text = Date_Of_Out.Text = null;
        }

        private void Add_Slammer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                Prisoner prisoner = new Prisoner();
                if (rFimale.Checked)
                {
                    prisoner.Sex = "انثى";
                }
                else
                {
                    prisoner.Sex = "ذكر";
                }

                if (rYes.Checked)
                {
                    prisoner.Judgement = "1";
                }
                else
                {
                    prisoner.Judgement = "0";
                }
                prisoner.Name = txtName.Text;
                prisoner.Age = int.Parse(txtAge.Text);
                prisoner.Phone = int.Parse(txtPhone.Text);
                prisoner.Punshment = int.Parse(comPunshment.Text);
                prisoner.Accusation = int.Parse(conAccusation.Text);
                prisoner.Erea = int.Parse(comErea.Text);
                prisoner.Date_Of_Enter = Date_Of_Enter.Value;
                prisoner.Date_Of_Out = Date_Of_Out.Value;

                db.Prisoner.Add(prisoner);
                db.SaveChanges();
                MessageBox.Show("تمت الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("لاتوجد بيانات الإجراء العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
