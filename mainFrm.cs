using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Iron_Store
{
    public partial class mainFrm : Form
    {
        DbUtil Util;
        public mainFrm()
        {
            Util = new DbUtil(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=IronStore.mdb;Persist Security Info=False");
            InitializeComponent();
        }

        public bool opened(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == f.GetType())
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
        private void btnAddSanf_Click(object sender, EventArgs e)
        {

          

            frmSanf fs = new frmSanf();
            if (opened( fs)) return;
            fs.MdiParent = this;
            fs.StartPosition = FormStartPosition.Manual;
            fs.Location = new Point((this.ClientSize.Width - fs.Width) / 2,
                                   (this.ClientSize.Height - fs.Height) / 2);


            fs.dbutil = Util;
            fs.Show();
        }


        private void btnExpenses_Click(object sender, EventArgs e)
        {
            frmexpense fs = new frmexpense();
            if (opened(fs)) return;
            fs.MdiParent = this;
            fs.StartPosition = FormStartPosition.Manual;
            fs.Location = new Point((this.ClientSize.Width - fs.Width) / 2,
                                   (this.ClientSize.Height - fs.Height) / 2);
            //  fs.StartPosition = FormStartPosition.CenterParent;
            fs.dbutil = Util;
            fs.Show();
        }

        private void btnAddexpence_Click(object sender, EventArgs e)
        {
            frmExpenseTrans fs = new frmExpenseTrans();
            if (opened(fs)) return;
            fs.MdiParent = this;
            fs.StartPosition = FormStartPosition.Manual;
            fs.Location = new Point((this.ClientSize.Width - fs.Width) / 2,
                                   (this.ClientSize.Height - fs.Height) / 2);
            //fs.StartPosition = FormStartPosition.CenterParent;
            fs.dbutil = Util;
            fs.Show();
        }

        private void btnAddpaytrans_Click(object sender, EventArgs e)
        {
            Form1 fs = new Form1();
            if (opened(fs)) return;
            fs.MdiParent = this;
            fs.StartPosition = FormStartPosition.Manual;
            fs.Location = new Point((this.ClientSize.Width - fs.Width) / 2,
                                   (this.ClientSize.Height - fs.Height) / 2);
            //fs.StartPosition = FormStartPosition.CenterParent;
            fs.dbutil = Util;
            fs.Show();
        }

        private void btnAddsellTrans_Click(object sender, EventArgs e)
        {
            Form2 fs = new Form2();
            if (opened(fs)) return;
            fs.MdiParent = this;
            fs.StartPosition = FormStartPosition.Manual;
            fs.Location = new Point((this.ClientSize.Width - fs.Width) / 2,
                                   (this.ClientSize.Height - fs.Height) / 2);
            //fs.StartPosition = FormStartPosition.CenterParent;
            fs.dbutil = Util;
            fs.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            frmSats fs = new frmSats();
            if (opened(fs)) return;
            fs.MdiParent = this;
            fs.StartPosition = FormStartPosition.Manual;
            fs.Location = new Point((this.ClientSize.Width - fs.Width) / 2,
                                   (this.ClientSize.Height - fs.Height) / 2);
            //fs.StartPosition = FormStartPosition.CenterParent;
            fs.dbutil = Util;
            fs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            //new Log().ShowDialog(this);
        }
    }
}
