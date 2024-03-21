namespace RpgCharaterCreation
{
    partial class AppearanceForm
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
            label1 = new Label();
            hairBtn = new Button();
            attireBtn = new Button();
            facialBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 38);
            label1.Name = "label1";
            label1.Size = new Size(478, 50);
            label1.TabIndex = 0;
            label1.Text = "Choose your appearance:";
            // 
            // hairBtn
            // 
            hairBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hairBtn.Location = new Point(203, 138);
            hairBtn.Name = "hairBtn";
            hairBtn.Size = new Size(368, 82);
            hairBtn.TabIndex = 1;
            hairBtn.Text = "Hair style";
            hairBtn.UseVisualStyleBackColor = true;
            hairBtn.Click += hairBtn_Click;
            // 
            // attireBtn
            // 
            attireBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attireBtn.Location = new Point(203, 246);
            attireBtn.Name = "attireBtn";
            attireBtn.Size = new Size(368, 82);
            attireBtn.TabIndex = 2;
            attireBtn.Text = "Attire";
            attireBtn.UseVisualStyleBackColor = true;
            attireBtn.Click += attireBtn_Click;
            // 
            // facialBtn
            // 
            facialBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            facialBtn.Location = new Point(203, 356);
            facialBtn.Name = "facialBtn";
            facialBtn.Size = new Size(368, 82);
            facialBtn.TabIndex = 3;
            facialBtn.Text = "Facial features";
            facialBtn.UseVisualStyleBackColor = true;
            facialBtn.Click += facialBtn_Click;
            // 
            // AppearanceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(facialBtn);
            Controls.Add(attireBtn);
            Controls.Add(hairBtn);
            Controls.Add(label1);
            Name = "AppearanceForm";
            Text = "AppearanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button hairBtn;
        private Button attireBtn;
        private Button facialBtn;
    }
}