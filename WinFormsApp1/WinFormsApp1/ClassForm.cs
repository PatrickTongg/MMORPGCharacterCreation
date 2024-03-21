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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }

        private void warriorBtn_Click(object sender, EventArgs e)
        {
            openForm("class: warrior");
        }

        private void mageBtn_Click(object sender, EventArgs e)
        {
            openForm("class: mage");
        }

        private void rogueBtn_Click(object sender, EventArgs e)
        {
            openForm("class: rogue");
        }

        private void clericBtn_Click(object sender, EventArgs e)
        {
            openForm("class: cleric");
        }

        private void openForm(string clazz)
        {
            Form1 form = new Form1(clazz);
            form.Show();
            Hide();
        }
    }
}
