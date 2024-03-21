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
    public partial class RaceForm : Form
    {
        public RaceForm()
        {
            InitializeComponent();
        }

        private void humanBtn_Click(object sender, EventArgs e)
        {
            openForm("race: human");
        }

        private void dwarvenBtn_Click(object sender, EventArgs e)
        {
            openForm("race: dwarf");
        }

        private void elvenBtn_Click(object sender, EventArgs e)
        {
            openForm("race: elf");
        }

        private void orcishBtn_Click(object sender, EventArgs e)
        {
            openForm("race: orc");
        }

        private void openForm(string race)
        {
            Form1 form = new Form1(race);
            form.Show();
            Hide();
        }
    }
}
