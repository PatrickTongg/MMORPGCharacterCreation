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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RpgCharaterCreation
{
    public partial class MainMenu : Form
    {
        DataStorage storage;
        public MainMenu()
        {
            InitializeComponent();
            DisplayCharater();
        }

        private void DisplayCharater()
        {
            storage = DataStorage.Instance;
            listBox1.Items.Clear();
            if (storage.CharacterList != null)
            {
                foreach (Character character in storage.CharacterList)
                {
                    listBox1.Items.Add(character.ToString());
                }
            }
        }

        private void createCharaterBtn_Click(object sender, EventArgs e)
        {
            CharacterCreationFomr characterCreationFomr = new CharacterCreationFomr();
            characterCreationFomr.Show();
            this.Hide();
        }

        private void viewCharaterBtn_Click(object sender, EventArgs e)
        {
            storage = DataStorage.Instance;
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select a character", "Warnign", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Character ch = storage.CharacterList[index];
                ViewPlayer form = new ViewPlayer(ch, true);
                form.Show();
                this.Hide();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importCSVBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                CSVParser parser = new CSVParser(filePath);
                parser.ConverterToCharacter();
            }

            DisplayCharater();
        }
    }
}
