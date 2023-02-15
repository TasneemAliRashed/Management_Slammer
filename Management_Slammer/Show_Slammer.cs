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
            //select  Prisoner's data  to DataGridView
            dataGridView1.DataSource = (from cat in db.Prisoner
                                        select new
                                        {
                                            cat.Id,
                                            cat.Name,
                                            cat.Phone,
                                            cat.Sex,
                                            cat.Erea,
                                            cat.Judgement,
                                            cat.Date_Of_Enter,
                                            cat.Accusation,
                                            cat.Punshment,
                                            cat.Date_Of_Out,
                                            cat.Age
                                        }).ToList();

            comErea.DataSource = (from cti in db.Erea
                                  select new
                                  {
                                      cti.Id,
                                      cti.Name
                                  }).ToList();
            comErea.DisplayMember = "Name";
            comErea.ValueMember = "Id";

            comPunshment.DataSource = (from cti in db.Punishment
                                       select new
                                       {
                                           cti.Id,
                                           cti.Name
                                       }).ToList();
            comPunshment.DisplayMember = "Name";
            comPunshment.ValueMember = "Id";

            conAccusation.DataSource = (from cti in db.Accusation
                                        select new
                                        {
                                            cti.Id,
                                            cti.Name
                                        }).ToList();
            conAccusation.DisplayMember = "Name";
            conAccusation.ValueMember = "Id";

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
            txtAge.Text = txtId.Text = txtName.Text = txtPhone.Text = comErea.Text = comPunshment.Text = conAccusation.Text = Date_Of_Enter.Text = Date_Of_Out.Text = null;

        }

        private void btnSereach_Enter(object sender, EventArgs e)
        {

        }

        private void Show_Slammer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                    var ss = db.Prisoner.FirstOrDefault(x => x.Id == id);
                    txtAge.Text = ss.Age.ToString();
                    txtName.Text = ss.Name;
                    txtPhone.Text = ss.Phone.ToString();
                    comErea.Text = ss.Erea.ToString();
                    comPunshment.Text = ss.Punshment.ToString();
                    conAccusation.Text = ss.Accusation.ToString();
                    Date_Of_Enter.Value = ss.Date_Of_Enter.Value;
                    Date_Of_Out.Value = ss.Date_Of_Out.Value;
                    if (ss.Sex == "انثى")
                    {

                        // rFimale.Checked;
                    }
                    else
                    {
                        //  rMale.Checked;
                    }

                    if (ss.Judgement == "1")
                    {

                        // rYes.Checked;
                    }
                    else
                    {

                        // rNo.Checked;
                    }
                }
            }
            catch
            {

                MessageBox.Show("لاتوجد بيانات الإجراء العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
