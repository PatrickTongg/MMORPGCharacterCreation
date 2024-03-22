namespace RpgCharaterCreation
{
    partial class ViewPlayer
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
            RaceIndex = new Label();
            ClassIndex = new Label();
            ApperanceIndex = new Label();
            abilitiesIndex = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            redoBtn = new Button();
            createBtn = new Button();
            SuspendLayout();
            // 
            // RaceIndex
            // 
            RaceIndex.AutoSize = true;
            RaceIndex.Location = new Point(99, 51);
            RaceIndex.Name = "RaceIndex";
            RaceIndex.Size = new Size(35, 15);
            RaceIndex.TabIndex = 0;
            RaceIndex.Text = "Race:";
            // 
            // ClassIndex
            // 
            ClassIndex.AutoSize = true;
            ClassIndex.Location = new Point(99, 79);
            ClassIndex.Name = "ClassIndex";
            ClassIndex.Size = new Size(37, 15);
            ClassIndex.TabIndex = 1;
            ClassIndex.Text = "Class:";
            // 
            // ApperanceIndex
            // 
            ApperanceIndex.AutoSize = true;
            ApperanceIndex.Location = new Point(61, 106);
            ApperanceIndex.Name = "ApperanceIndex";
            ApperanceIndex.Size = new Size(73, 15);
            ApperanceIndex.TabIndex = 2;
            ApperanceIndex.Text = "Appearence:";
            // 
            // abilitiesIndex
            // 
            abilitiesIndex.AutoSize = true;
            abilitiesIndex.Location = new Point(82, 136);
            abilitiesIndex.Name = "abilitiesIndex";
            abilitiesIndex.Size = new Size(52, 15);
            abilitiesIndex.TabIndex = 3;
            abilitiesIndex.Text = "Abilities:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 51);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 79);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 106);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(143, 136);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 327);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 8;
            // 
            // redoBtn
            // 
            redoBtn.Location = new Point(249, 169);
            redoBtn.Name = "redoBtn";
            redoBtn.Size = new Size(75, 23);
            redoBtn.TabIndex = 9;
            redoBtn.Text = "Redo";
            redoBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(99, 169);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(75, 23);
            createBtn.TabIndex = 10;
            createBtn.Text = "Confirm";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // ViewPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 226);
            Controls.Add(createBtn);
            Controls.Add(redoBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(abilitiesIndex);
            Controls.Add(ApperanceIndex);
            Controls.Add(ClassIndex);
            Controls.Add(RaceIndex);
            Name = "ViewPlayer";
            Text = "ViewPlayer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RaceIndex;
        private Label ClassIndex;
        private Label ApperanceIndex;
        private Label abilitiesIndex;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button redoBtn;
        private Button createBtn;
    }
}