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
            classRadioBtn.Location = new Point(170, 184);
            classRadioBtn.Margin = new Padding(6);
            classRadioBtn.Name = "classRadioBtn";
            classRadioBtn.Size = new Size(415, 36);
            classRadioBtn.TabIndex = 0;
            classRadioBtn.TabStop = true;
            classRadioBtn.Text = "Great Library of Arcane Knowledge";
            classRadioBtn.UseVisualStyleBackColor = true;
            classRadioBtn.CheckedChanged += classRadioBtn_CheckedChanged;
            // 
            // abilitiesRadioBtn
            // 
            abilitiesRadioBtn.AutoSize = true;
            abilitiesRadioBtn.Location = new Point(724, 342);
            abilitiesRadioBtn.Margin = new Padding(6);
            abilitiesRadioBtn.Name = "abilitiesRadioBtn";
            abilitiesRadioBtn.Size = new Size(197, 36);
            abilitiesRadioBtn.TabIndex = 1;
            abilitiesRadioBtn.TabStop = true;
            abilitiesRadioBtn.Text = "Hall of Heroes";
            abilitiesRadioBtn.UseVisualStyleBackColor = true;
            abilitiesRadioBtn.CheckedChanged += abilitiesRadioBtn_CheckedChanged;
            // 
            // raceRadioBtn
            // 
            raceRadioBtn.AutoSize = true;
            raceRadioBtn.Location = new Point(158, 508);
            raceRadioBtn.Margin = new Padding(6);
            raceRadioBtn.Name = "raceRadioBtn";
            raceRadioBtn.Size = new Size(202, 36);
            raceRadioBtn.TabIndex = 2;
            raceRadioBtn.TabStop = true;
            raceRadioBtn.Text = "Tree of Origins";
            raceRadioBtn.UseVisualStyleBackColor = true;
            raceRadioBtn.CheckedChanged += raceRadioBtn_CheckedChanged;
            // 
            // appearanceRadioBtn
            // 
            appearanceRadioBtn.AutoSize = true;
            appearanceRadioBtn.Location = new Point(560, 672);
            appearanceRadioBtn.Margin = new Padding(6);
            appearanceRadioBtn.Name = "appearanceRadioBtn";
            appearanceRadioBtn.Size = new Size(372, 36);
            appearanceRadioBtn.TabIndex = 3;
            appearanceRadioBtn.TabStop = true;
            appearanceRadioBtn.Text = "Enchanted Mirror of Reflection";
            appearanceRadioBtn.UseVisualStyleBackColor = true;
            appearanceRadioBtn.CheckedChanged += appearanceRadioBtn_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1028, 808);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // goBtn
            // 
            goBtn.Location = new Point(1087, 96);
            goBtn.Name = "goBtn";
            goBtn.Size = new Size(190, 68);
            goBtn.TabIndex = 9;
            goBtn.Text = "Go!";
            goBtn.UseVisualStyleBackColor = true;
            goBtn.Click += goBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(1087, 200);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(190, 84);
            createBtn.TabIndex = 10;
            createBtn.Text = "Create character";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new Point(1075, 406);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(79, 32);
            classLabel.TabIndex = 11;
            classLabel.Text = "Class: ";
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Location = new Point(1075, 459);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(76, 32);
            raceLabel.TabIndex = 12;
            raceLabel.Text = "Race: ";
            // 
            // abilitiesLabel
            // 
            abilitiesLabel.AutoSize = true;
            abilitiesLabel.Location = new Point(1075, 563);
            abilitiesLabel.Name = "abilitiesLabel";
            abilitiesLabel.Size = new Size(103, 32);
            abilitiesLabel.TabIndex = 14;
            abilitiesLabel.Text = "Abilities:";
            // 
            // appearanceLabel
            // 
            appearanceLabel.AutoSize = true;
            appearanceLabel.Location = new Point(1075, 510);
            appearanceLabel.Name = "appearanceLabel";
            appearanceLabel.Size = new Size(145, 32);
            appearanceLabel.TabIndex = 13;
            appearanceLabel.Text = "Appearance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 847);
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
            Margin = new Padding(6);
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
