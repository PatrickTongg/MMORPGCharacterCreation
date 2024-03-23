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
            builder.setClazz("WAR");
            openForm();
        }

        private void mageBtn_Click(object sender, EventArgs e)
        {
            builder.setClazz("MAG");
            openForm();
        }

        private void rogueBtn_Click(object sender, EventArgs e)
        {
            builder.setClazz("ROG");
            openForm();
        }

        private void clericBtn_Click(object sender, EventArgs e)
        {
            builder.setClazz("WAR");
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
