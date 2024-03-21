using RpgCharaterCreation;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string attribute) : this()
        {
            string[] elements = attribute.Split(' ', 2);
            switch (elements[0])
            {
                case "appearance:":
                    appearanceLabel.Text += elements[1];
                    appearanceRadioBtn.Enabled = false;
                    break;
                case "class:":
                    classLabel.Text += elements[1];
                    classRadioBtn.Enabled = false;
                    break;
                case "ability:":
                    abilitiesLabel.Text += elements[1];
                    abilitiesRadioBtn.Enabled = false;
                    break;
                case "race:":
                    raceLabel.Text += elements[1];
                    raceRadioBtn.Enabled = false;
                    break;
            }

            if (!(appearanceRadioBtn.Enabled || classRadioBtn.Enabled
                || abilitiesRadioBtn.Enabled || raceRadioBtn.Enabled))
            {
                goBtn.Enabled = false;
                createBtn.Enabled = true;
            }
        }

        private void classRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            abilitiesRadioBtn.Checked = false;
            raceRadioBtn.Checked = false;
            appearanceRadioBtn.Checked = false;
        }

        private void abilitiesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            classRadioBtn.Checked = false;
            raceRadioBtn.Checked = false;
            appearanceRadioBtn.Checked = false;
        }

        private void raceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            abilitiesRadioBtn.Checked = false;
            classRadioBtn.Checked = false;
            appearanceRadioBtn.Checked = false;
        }

        private void appearanceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            abilitiesRadioBtn.Checked = false;
            raceRadioBtn.Checked = false;
            classRadioBtn.Checked = false;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            if (classRadioBtn.Checked)
            {
                ClassForm form = new ClassForm();
                form.Show();
                Hide();
            } else if (raceRadioBtn.Checked)
            {
                RaceForm form = new RaceForm();
                form.Show();
                Hide();
            } else if (appearanceRadioBtn.Checked)
            {
                AppearanceForm form = new AppearanceForm();
                form.Show();
                Hide();
            } else
            {
                AbilityForm form = new AbilityForm();
                form.Show();
                Hide();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
