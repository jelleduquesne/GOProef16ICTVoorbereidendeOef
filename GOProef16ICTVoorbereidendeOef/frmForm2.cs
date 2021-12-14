using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GOProef16ICTVoorbereidendeOef
{
    public partial class frmForm2 : Form
    {
        Form1 frmForm1;
        public frmForm2(Form1 frm)
        {
            InitializeComponent();
            frmForm1 = frm;
        }

        private void frmForm2_Load(object sender, EventArgs e)
        {
            this.Text = frmForm1.tekstje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmForm1.tekstje = textBox1.Text;//aanpassen tekstje uit form1 vanuit form2
            
        }
    }
}
