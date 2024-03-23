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
    public partial class ViewPlayer : Form
    {
        Character character;
        bool isExisting;
        public ViewPlayer(Character ch, bool isExisting)
        {
            this.isExisting = isExisting;
            InitializeComponent();
            label5.Text = ch.race.Name;
            label6.Text = ch.clazz.ClazzName;
            label7.Text = ch.appearances.Description;
            label8.Text = ch.ability.AbilityType;
            HumanClazzPic.Visible = false;
            ElfClazzPic.Visible = false;
            DwafClassPic.Visible = false;
            OrchishClazzPic.Visible = false;
            if( ch.ability.AbilityType == "HumanAbility")
            {
                HumanClazzPic.Visible = true;
            }
            if (ch.ability.AbilityType == "DwarvenAbilities")
            {
                DwafClassPic.Visible = true;
            }
            if (ch.ability.AbilityType == "ElvenAbilities")
            {
                ElfClazzPic.Visible = true;
            }
            if (ch.ability.AbilityType == "OrcishAbilities")
            {
                OrchishClazzPic.Visible = true;
            }
            character = ch;
            if (isExisting)
            {
                redoBtn.Visible = false;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!isExisting)
            {
                DataStorage.Add(character);
            }
            ListForm form = new ListForm();
            form.show();
            this.Hide();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
