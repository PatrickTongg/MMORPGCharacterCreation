using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgCharaterCreation.Builder;
using WinFormsApp1;

namespace RpgCharaterCreation
{
    public partial class AppearanceForm : Form
    {
        private readonly IBuilder builder;
        public AppearanceForm(IBuilder builder)
        {
            this.builder = builder;
            InitializeComponent();
        }

        private void hairBtn_Click(object sender, EventArgs e)
        {
            builder.SetAppearance("HAIR");
            openForm();
        }

        private void attireBtn_Click(object sender, EventArgs e)
        {
            builder.SetAppearance("ATTIRE");
            openForm(); 
        }

        private void facialBtn_Click(object sender, EventArgs e)
        {
            builder.SetAppearance("FACE");
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
