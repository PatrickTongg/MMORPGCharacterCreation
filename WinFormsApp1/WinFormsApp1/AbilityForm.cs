using RpgCharaterCreation.Builder;
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
            builder.SetAbility("HUMA");
            openForm();
        }   

        private void dwarvenBtn_Click(object sender, EventArgs e)
        {
            builder.SetAbility("DWAA");
            openForm();
        }

        private void elvenBtn_Click(object sender, EventArgs e)
        {
            builder.SetAbility("ELVA");
            openForm();
        }

        private void orcishBtn_Click(object sender, EventArgs e)
        {
            builder.SetAbility("ORCA");
            openForm();
        }

        private void openForm()
        {

            CharacterCreationFomr form = new CharacterCreationFomr(builder);
            form.Show();
            Hide();
        }
    }
}
