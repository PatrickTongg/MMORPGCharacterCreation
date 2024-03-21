namespace RpgCharaterCreation
{
    partial class ClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clericBtn = new Button();
            rogueBtn = new Button();
            mageBtn = new Button();
            warriorBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // clericBtn
            // 
            clericBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clericBtn.Location = new Point(205, 471);
            clericBtn.Name = "clericBtn";
            clericBtn.Size = new Size(368, 82);
            clericBtn.TabIndex = 13;
            clericBtn.Text = "Cleric";
            clericBtn.UseVisualStyleBackColor = true;
            clericBtn.Click += clericBtn_Click;
            // 
            // rogueBtn
            // 
            rogueBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rogueBtn.Location = new Point(205, 359);
            rogueBtn.Name = "rogueBtn";
            rogueBtn.Size = new Size(368, 82);
            rogueBtn.TabIndex = 12;
            rogueBtn.Text = "Rogue";
            rogueBtn.UseVisualStyleBackColor = true;
            rogueBtn.Click += rogueBtn_Click;
            // 
            // mageBtn
            // 
            mageBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mageBtn.Location = new Point(205, 249);
            mageBtn.Name = "mageBtn";
            mageBtn.Size = new Size(368, 82);
            mageBtn.TabIndex = 11;
            mageBtn.Text = "Mage";
            mageBtn.UseVisualStyleBackColor = true;
            mageBtn.Click += mageBtn_Click;
            // 
            // warriorBtn
            // 
            warriorBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            warriorBtn.Location = new Point(205, 141);
            warriorBtn.Name = "warriorBtn";
            warriorBtn.Size = new Size(368, 82);
            warriorBtn.TabIndex = 10;
            warriorBtn.Text = "Warrior";
            warriorBtn.UseVisualStyleBackColor = true;
            warriorBtn.Click += warriorBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 45);
            label1.Name = "label1";
            label1.Size = new Size(354, 50);
            label1.TabIndex = 9;
            label1.Text = "Choose your class:";
            // 
            // ClassForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 626);
            Controls.Add(clericBtn);
            Controls.Add(rogueBtn);
            Controls.Add(mageBtn);
            Controls.Add(warriorBtn);
            Controls.Add(label1);
            Name = "ClassForm";
            Text = "ClassForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clericBtn;
        private Button rogueBtn;
        private Button mageBtn;
        private Button warriorBtn;
        private Label label1;
    }
}