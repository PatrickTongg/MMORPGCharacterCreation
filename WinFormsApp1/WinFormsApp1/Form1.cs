using RpgCharaterCreation;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly IBuilder builder;

        public Form1()
        {
            InitializeComponent();
            builder = new Builder();
        }

        public Form1(IBuilder builder) : this()
        {
            this.builder = builder;
            if (builder.build().appearances != null)
            {
                appearanceLabel.Text += builder.build().appearances.Description;
                appearanceRadioBtn.Enabled = false;
            }
            if (builder.build().clazz != null)
            {
                classLabel.Text += builder.build().clazz.ClazzName;
                classRadioBtn.Enabled = false;
            }
            if(builder.build().ability != null)
            {
                abilitiesLabel.Text += builder.build().ability.AbilityType;
                abilitiesRadioBtn.Enabled = false;
            }
            if(builder.build().race != null)
            {
                raceLabel.Text += builder.build().race.Name;
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
            ViewPlayer viewPlayer = new ViewPlayer(builder.build());
            viewPlayer.Show();
            this.Hide();
        }
    }
}
