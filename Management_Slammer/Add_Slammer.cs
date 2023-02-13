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
    }
}
