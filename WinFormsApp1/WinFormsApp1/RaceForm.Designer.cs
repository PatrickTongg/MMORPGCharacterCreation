namespace RpgCharaterCreation
{
    partial class RaceForm
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
            orcishBtn = new Button();
            elvenBtn = new Button();
            dwarvenBtn = new Button();
            humanBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // orcishBtn
            // 
            orcishBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orcishBtn.Location = new Point(220, 465);
            orcishBtn.Name = "orcishBtn";
            orcishBtn.Size = new Size(368, 82);
            orcishBtn.TabIndex = 13;
            orcishBtn.Text = "Orc";
            orcishBtn.UseVisualStyleBackColor = true;
            orcishBtn.Click += orcishBtn_Click;
            // 
            // elvenBtn
            // 
            elvenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            elvenBtn.Location = new Point(220, 353);
            elvenBtn.Name = "elvenBtn";
            elvenBtn.Size = new Size(368, 82);
            elvenBtn.TabIndex = 12;
            elvenBtn.Text = "Elf";
            elvenBtn.UseVisualStyleBackColor = true;
            elvenBtn.Click += elvenBtn_Click;
            // 
            // dwarvenBtn
            // 
            dwarvenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dwarvenBtn.Location = new Point(220, 243);
            dwarvenBtn.Name = "dwarvenBtn";
            dwarvenBtn.Size = new Size(368, 82);
            dwarvenBtn.TabIndex = 11;
            dwarvenBtn.Text = "Dwarf";
            dwarvenBtn.UseVisualStyleBackColor = true;
            dwarvenBtn.Click += dwarvenBtn_Click;
            // 
            // humanBtn
            // 
            humanBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            humanBtn.Location = new Point(220, 135);
            humanBtn.Name = "humanBtn";
            humanBtn.Size = new Size(368, 82);
            humanBtn.TabIndex = 10;
            humanBtn.Text = "Human";
            humanBtn.UseVisualStyleBackColor = true;
            humanBtn.Click += humanBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 43);
            label1.Name = "label1";
            label1.Size = new Size(344, 50);
            label1.TabIndex = 9;
            label1.Text = "Choose your race:";
            // 
            // RaceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 588);
            Controls.Add(orcishBtn);
            Controls.Add(elvenBtn);
            Controls.Add(dwarvenBtn);
            Controls.Add(humanBtn);
            Controls.Add(label1);
            Name = "RaceForm";
            Text = "RaceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button orcishBtn;
        private Button elvenBtn;
        private Button dwarvenBtn;
        private Button humanBtn;
        private Label label1;
    }
}