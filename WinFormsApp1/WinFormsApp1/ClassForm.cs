using RpgCharaterCreation.Builder;
using RpgCharaterCreation.Prototype;
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
        private readonly IBuilder builder;
        public ClassForm(IBuilder builder)
        {
            InitializeComponent();
            this.builder = builder;
        }

        private void warriorBtn_Click(object sender, EventArgs e)
        {
            builder.SetClazz("WAR");
            openForm();
        }

        private void mageBtn_Click(object sender, EventArgs e)
        {
            builder.SetClazz("MAG");
            openForm();
        }

        private void rogueBtn_Click(object sender, EventArgs e)
        {
            builder.SetClazz("ROG");
            openForm();
        }

        private void clericBtn_Click(object sender, EventArgs e)
        {
            builder.SetClazz("WAR");
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
