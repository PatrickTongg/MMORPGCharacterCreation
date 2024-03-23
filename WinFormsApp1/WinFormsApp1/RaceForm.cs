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
        private readonly IBuilder builder;
        public RaceForm(IBuilder builder)
        {
            this.builder = builder;
            InitializeComponent();
        }

        private void humanBtn_Click(object sender, EventArgs e)
        {
            builder.setRace("HUM");
            openForm();
        }

        private void dwarvenBtn_Click(object sender, EventArgs e)
        {
            builder.setRace("DWA");
            openForm();
        }

        private void elvenBtn_Click(object sender, EventArgs e)
        {
            builder.setRace("ELV");
            openForm();
        }

        private void orcishBtn_Click(object sender, EventArgs e)
        {
            builder.setRace("ORC");
            openForm();
        }

        private void openForm()
        {
            Form1 form = new Form1(builder);
            form.Show();
            Hide();
        }
    }
}
