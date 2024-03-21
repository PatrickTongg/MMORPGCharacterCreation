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
    public partial class AbilityForm : Form
    {
        public AbilityForm()
        {
            InitializeComponent();
        }

        private void humanBtn_Click(object sender, EventArgs e)
        {
            openForm("ability: human abilities");
        }

        private void dwarvenBtn_Click(object sender, EventArgs e)
        {
            openForm("ability: dwarven abilities");
        }

        private void elvenBtn_Click(object sender, EventArgs e)
        {
            openForm("ability: elven abilities");
        }

        private void orcishBtn_Click(object sender, EventArgs e)
        {
            openForm("ability: orcish abilities");
        }

        private void openForm(string ability)
        {
            Form1 form = new Form1(ability);
            form.Show();
            Hide();
        }
    }
}
