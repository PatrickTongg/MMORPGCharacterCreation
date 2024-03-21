using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace RpgCharaterCreation
{
    public partial class AppearanceForm : Form
    {
        public AppearanceForm()
        {
            InitializeComponent();
        }

        private void hairBtn_Click(object sender, EventArgs e)
        {
            openForm("appearance: hair style");
        }

        private void attireBtn_Click(object sender, EventArgs e)
        {
            openForm("appearance: attire");
        }

        private void facialBtn_Click(object sender, EventArgs e)
        {
            openForm("appearance: facial features");
        }

        private void openForm(string appearance)
        {
            Form1 form = new Form1(appearance);
            form.Show();
            Hide();
        }
    }
}
