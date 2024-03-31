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
            DisplayCharacter();
        }

        private void DisplayCharacter()
        {
            storage = DataStorage.Instance;
            listBox1.Items.Clear();
            if (storage.CharacterList != null)
            {
                foreach (Character character in storage.CharacterList)
                {
                    listBox1.Items.Add(character.DisplayInfo());
                }
            }
        }

        private void CreateCharacterBtn_Click(object sender, EventArgs e)
        {
            CharacterCreationFomr characterCreationFomr = new CharacterCreationFomr();
            characterCreationFomr.Show();
            this.Hide();
        }

        private void ViewCharacterBtn_Click(object sender, EventArgs e)
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImportCSVBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                CSVParser parser = new CSVParser(filePath);
                parser.ConverterToCharacter();
            }

            DisplayCharacter();
        }

        private void ExportCSVBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    string filePath = saveFileDialog1.FileName;
                    CSVExporter exporter = new CSVExporter(filePath);
                    exporter.ExportCSV();

            }
        }
    }
}
