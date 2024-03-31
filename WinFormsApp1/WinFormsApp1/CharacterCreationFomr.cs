using RpgCharaterCreation;
using RpgCharaterCreation.Builder;

namespace WinFormsApp1
{
    public partial class CharacterCreationFomr : Form
    {
        private readonly IBuilder builder;

        public CharacterCreationFomr()
        {
            InitializeComponent();
            builder = new Builder();
        }

        public CharacterCreationFomr(IBuilder builder) : this()
        {
            this.builder = builder;
            if (builder.Build().appearances != null)
            {
                appearanceLabel.Text += builder.Build().appearances.Description;
                appearanceRadioBtn.Enabled = false;
            }
            if (builder.Build().clazz != null)
            {
                classLabel.Text += builder.Build().clazz.ClazzName;
                classRadioBtn.Enabled = false;
            }
            if(builder.Build().ability != null)
            {
                abilitiesLabel.Text += builder.Build().ability.AbilityType;
                abilitiesRadioBtn.Enabled = false;
            }
            if(builder.Build().race != null)
            {
                raceLabel.Text += builder.Build().race.Name;
                raceRadioBtn.Enabled = false; 
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
                ClassForm form = new ClassForm(builder);
                form.Show();
                Hide();
            } else if (raceRadioBtn.Checked)
            {
                RaceForm form = new RaceForm(builder);
                form.Show();
                Hide();
            } else if (appearanceRadioBtn.Checked)
            {
                AppearanceForm form = new AppearanceForm(builder);
                form.Show();
                Hide();
            } else
            {
                AbilityForm form = new AbilityForm(builder);
                form.Show();
                Hide();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            ViewPlayer viewPlayer = new ViewPlayer(builder.Build(), false);
            viewPlayer.Show();
            this.Hide();
        }
    }
}
