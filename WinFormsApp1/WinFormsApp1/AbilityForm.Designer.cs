namespace RpgCharaterCreation
{
    partial class AbilityForm
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
            elvenBtn = new Button();
            dwarvenBtn = new Button();
            humanBtn = new Button();
            label1 = new Label();
            orcishBtn = new Button();
            SuspendLayout();
            // 
            // elvenBtn
            // 
            elvenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            elvenBtn.Location = new Point(211, 343);
            elvenBtn.Name = "elvenBtn";
            elvenBtn.Size = new Size(368, 82);
            elvenBtn.TabIndex = 7;
            elvenBtn.Text = "Elven abilities";
            elvenBtn.UseVisualStyleBackColor = true;
            elvenBtn.Click += elvenBtn_Click;
            // 
            // dwarvenBtn
            // 
            dwarvenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dwarvenBtn.Location = new Point(211, 233);
            dwarvenBtn.Name = "dwarvenBtn";
            dwarvenBtn.Size = new Size(368, 82);
            dwarvenBtn.TabIndex = 6;
            dwarvenBtn.Text = "Dwarven abilities";
            dwarvenBtn.UseVisualStyleBackColor = true;
            dwarvenBtn.Click += dwarvenBtn_Click;
            // 
            // humanBtn
            // 
            humanBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            humanBtn.Location = new Point(211, 125);
            humanBtn.Name = "humanBtn";
            humanBtn.Size = new Size(368, 82);
            humanBtn.TabIndex = 5;
            humanBtn.Text = "Human abilities";
            humanBtn.UseVisualStyleBackColor = true;
            humanBtn.Click += humanBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 29);
            label1.Name = "label1";
            label1.Size = new Size(411, 50);
            label1.TabIndex = 4;
            label1.Text = "Choose your abilities:";
            // 
            // orcishBtn
            // 
            orcishBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orcishBtn.Location = new Point(211, 455);
            orcishBtn.Name = "orcishBtn";
            orcishBtn.Size = new Size(368, 82);
            orcishBtn.TabIndex = 8;
            orcishBtn.Text = "Orcish abilities";
            orcishBtn.UseVisualStyleBackColor = true;
            orcishBtn.Click += orcishBtn_Click;
            // 
            // AbilityForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(orcishBtn);
            Controls.Add(elvenBtn);
            Controls.Add(dwarvenBtn);
            Controls.Add(humanBtn);
            Controls.Add(label1);
            Name = "AbilityForm";
            Text = "AbilityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button elvenBtn;
        private Button dwarvenBtn;
        private Button humanBtn;
        private Label label1;
        private Button orcishBtn;
    }
}