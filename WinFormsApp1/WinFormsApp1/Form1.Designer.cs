namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            classRadioBtn = new RadioButton();
            abilitiesRadioBtn = new RadioButton();
            raceRadioBtn = new RadioButton();
            appearanceRadioBtn = new RadioButton();
            pictureBox1 = new PictureBox();
            goBtn = new Button();
            createBtn = new Button();
            classLabel = new Label();
            raceLabel = new Label();
            abilitiesLabel = new Label();
            appearanceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // classRadioBtn
            // 
            classRadioBtn.AutoSize = true;
            classRadioBtn.Location = new Point(92, 86);
            classRadioBtn.Name = "classRadioBtn";
            classRadioBtn.Size = new Size(208, 19);
            classRadioBtn.TabIndex = 0;
            classRadioBtn.TabStop = true;
            classRadioBtn.Text = "Great Library of Arcane Knowledge";
            classRadioBtn.UseVisualStyleBackColor = true;
            classRadioBtn.CheckedChanged += classRadioBtn_CheckedChanged;
            // 
            // abilitiesRadioBtn
            // 
            abilitiesRadioBtn.AutoSize = true;
            abilitiesRadioBtn.Location = new Point(390, 160);
            abilitiesRadioBtn.Name = "abilitiesRadioBtn";
            abilitiesRadioBtn.Size = new Size(100, 19);
            abilitiesRadioBtn.TabIndex = 1;
            abilitiesRadioBtn.TabStop = true;
            abilitiesRadioBtn.Text = "Hall of Heroes";
            abilitiesRadioBtn.UseVisualStyleBackColor = true;
            abilitiesRadioBtn.CheckedChanged += abilitiesRadioBtn_CheckedChanged;
            // 
            // raceRadioBtn
            // 
            raceRadioBtn.AutoSize = true;
            raceRadioBtn.Location = new Point(85, 238);
            raceRadioBtn.Name = "raceRadioBtn";
            raceRadioBtn.Size = new Size(101, 19);
            raceRadioBtn.TabIndex = 2;
            raceRadioBtn.TabStop = true;
            raceRadioBtn.Text = "Tree of Origins";
            raceRadioBtn.UseVisualStyleBackColor = true;
            raceRadioBtn.CheckedChanged += raceRadioBtn_CheckedChanged;
            // 
            // appearanceRadioBtn
            // 
            appearanceRadioBtn.AutoSize = true;
            appearanceRadioBtn.Location = new Point(302, 315);
            appearanceRadioBtn.Name = "appearanceRadioBtn";
            appearanceRadioBtn.Size = new Size(187, 19);
            appearanceRadioBtn.TabIndex = 3;
            appearanceRadioBtn.TabStop = true;
            appearanceRadioBtn.Text = "Enchanted Mirror of Reflection";
            appearanceRadioBtn.UseVisualStyleBackColor = true;
            appearanceRadioBtn.CheckedChanged += appearanceRadioBtn_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 17);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 379);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // goBtn
            // 
            goBtn.Location = new Point(585, 45);
            goBtn.Margin = new Padding(2, 1, 2, 1);
            goBtn.Name = "goBtn";
            goBtn.Size = new Size(102, 32);
            goBtn.TabIndex = 9;
            goBtn.Text = "Go!";
            goBtn.UseVisualStyleBackColor = true;
            goBtn.Click += goBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Enabled = false;
            createBtn.Location = new Point(585, 94);
            createBtn.Margin = new Padding(2, 1, 2, 1);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(102, 39);
            createBtn.TabIndex = 10;
            createBtn.Text = "Create character";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new Point(579, 190);
            classLabel.Margin = new Padding(2, 0, 2, 0);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(40, 15);
            classLabel.TabIndex = 11;
            classLabel.Text = "Class: ";
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Location = new Point(579, 215);
            raceLabel.Margin = new Padding(2, 0, 2, 0);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(38, 15);
            raceLabel.TabIndex = 12;
            raceLabel.Text = "Race: ";
            // 
            // abilitiesLabel
            // 
            abilitiesLabel.AutoSize = true;
            abilitiesLabel.Location = new Point(579, 264);
            abilitiesLabel.Margin = new Padding(2, 0, 2, 0);
            abilitiesLabel.Name = "abilitiesLabel";
            abilitiesLabel.Size = new Size(52, 15);
            abilitiesLabel.TabIndex = 14;
            abilitiesLabel.Text = "Abilities:";
            // 
            // appearanceLabel
            // 
            appearanceLabel.AutoSize = true;
            appearanceLabel.Location = new Point(579, 239);
            appearanceLabel.Margin = new Padding(2, 0, 2, 0);
            appearanceLabel.Name = "appearanceLabel";
            appearanceLabel.Size = new Size(73, 15);
            appearanceLabel.TabIndex = 13;
            appearanceLabel.Text = "Appearance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 397);
            Controls.Add(abilitiesLabel);
            Controls.Add(appearanceLabel);
            Controls.Add(raceLabel);
            Controls.Add(classLabel);
            Controls.Add(createBtn);
            Controls.Add(goBtn);
            Controls.Add(raceRadioBtn);
            Controls.Add(appearanceRadioBtn);
            Controls.Add(classRadioBtn);
            Controls.Add(abilitiesRadioBtn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Realm of legends";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton classRadioBtn;
        private RadioButton abilitiesRadioBtn;
        private RadioButton raceRadioBtn;
        private RadioButton appearanceRadioBtn;
        private PictureBox pictureBox1;
        private Button goBtn;
        private Button createBtn;
        private Label classLabel;
        private Label raceLabel;
        private Label abilitiesLabel;
        private Label appearanceLabel;
    }
}
