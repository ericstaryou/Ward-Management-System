using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ward_Management
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientMenu pm = new PatientMenu();
            pm.Show();
        }

        private void Nurse_Click(object sender, EventArgs e)
        {
            NurseMenu nm = new NurseMenu();
            nm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ward_Click(object sender, EventArgs e)
        {
            WardMenu wm = new WardMenu();
            wm.Show();
        }
    }
}
