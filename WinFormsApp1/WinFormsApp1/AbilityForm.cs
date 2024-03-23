using RpgCharaterCreation;
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
        private readonly IBuilder builder;
        public AbilityForm(IBuilder builder)
        {
            InitializeComponent();
            this.builder = builder;
        }

        private void humanBtn_Click(object sender, EventArgs e)
        {
            builder.setAbility("HUMA");
            openForm();
        }   

        private void dwarvenBtn_Click(object sender, EventArgs e)
        {
            builder.setAbility("DWAA");
            openForm();
        }

        private void elvenBtn_Click(object sender, EventArgs e)
        {
            builder.setAbility("ELVA");
            openForm();
        }

        private void orcishBtn_Click(object sender, EventArgs e)
        {
            builder.setAbility("ORCA");
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
