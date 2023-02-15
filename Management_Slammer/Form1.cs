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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            skinEngine1.SkinFile= "GlassBrown.ssk";
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void بياناتالسجناءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void التقاريرToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void إضافةمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Accusation add_Accusation = new Add_Accusation();
            add_Accusation.ShowDialog();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void إنشاءنسخةإحطياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Backup create_Backup = new Create_Backup();
            create_Backup.ShowDialog();
        }

        private void إستعادةنسخهإحطياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore_Backup restore_Backup = new Restore_Backup();
            restore_Backup.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
         MessageBox.Show("هل أنت متاكد من تسجيل الخروج","تحذير", MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1) ;
        }

        private void إضافةسجينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Slammer add_Slammer = new Add_Slammer();
            add_Slammer.ShowDialog();
        }

        private void عرضبياناتالسجناءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Slammer show_Slammer = new Show_Slammer();
            show_Slammer.ShowDialog();
        }

        private void إضافةمنطقةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Erea add_Erea = new Add_Erea();
            add_Erea.ShowDialog();
        }

        private void عرضبياناتالمناطقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Erea show_Erea = new Show_Erea();
            show_Erea.ShowDialog();
        }

        private void إضافةعقوبهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Punishment add_Punishment = new Add_Punishment();
            add_Punishment.ShowDialog();
        }

        private void إضافةمستخدمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_User add_User = new Add_User();
            add_User.ShowDialog();
        }

        private void عرضبياناتالمستخدمينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show_User show_User = new Show_User();
            show_User.ShowDialog();
        }

        private void عرضبياناتالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Accusation show_Accusation = new Show_Accusation();
            show_Accusation.ShowDialog();
        }

        private void عرضبياناتالعقوباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Punishment show_Punishment = new Show_Punishment();
            show_Punishment.ShowDialog();
        }
    }
}
