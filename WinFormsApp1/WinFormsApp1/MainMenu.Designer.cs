namespace RpgCharaterCreation
{
    partial class MainMenu
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
            createCharacterBtn = new Button();
            importCSVBtn = new Button();
            viewCharacterBtn = new Button();
            exportCSVBtn = new Button();
            exitBtn = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // createCharacterBtn
            // 
            createCharacterBtn.Location = new Point(12, 378);
            createCharacterBtn.Name = "createCharacterBtn";
            createCharacterBtn.Size = new Size(101, 43);
            createCharacterBtn.TabIndex = 0;
            createCharacterBtn.Text = "Create Charater";
            createCharacterBtn.UseVisualStyleBackColor = true;
            createCharacterBtn.Click += CreateCharacterBtn_Click;
            // 
            // importCSVBtn
            // 
            importCSVBtn.Location = new Point(368, 388);
            importCSVBtn.Name = "importCSVBtn";
            importCSVBtn.Size = new Size(75, 23);
            importCSVBtn.TabIndex = 1;
            importCSVBtn.Text = "Import CSV";
            importCSVBtn.UseVisualStyleBackColor = true;
            importCSVBtn.Click += ImportCSVBtn_Click;
            // 
            // viewCharacterBtn
            // 
            viewCharacterBtn.Location = new Point(449, 308);
            viewCharacterBtn.Name = "viewCharacterBtn";
            viewCharacterBtn.Size = new Size(75, 43);
            viewCharacterBtn.TabIndex = 3;
            viewCharacterBtn.Text = "View Charater";
            viewCharacterBtn.UseVisualStyleBackColor = true;
            viewCharacterBtn.Click += ViewCharacterBtn_Click;
            // 
            // exportCSVBtn
            // 
            exportCSVBtn.Location = new Point(559, 310);
            exportCSVBtn.Name = "exportCSVBtn";
            exportCSVBtn.Size = new Size(75, 41);
            exportCSVBtn.TabIndex = 4;
            exportCSVBtn.Text = "Export CSV";
            exportCSVBtn.UseVisualStyleBackColor = true;
            exportCSVBtn.Click += ExportCSVBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(559, 388);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += ExitBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(47, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 319);
            listBox1.TabIndex = 6;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 432);
            Controls.Add(listBox1);
            Controls.Add(exitBtn);
            Controls.Add(exportCSVBtn);
            Controls.Add(viewCharacterBtn);
            Controls.Add(importCSVBtn);
            Controls.Add(createCharacterBtn);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button createCharacterBtn;
        private Button importCSVBtn;
        private Button viewCharacterBtn;
        private Button exportCSVBtn;
        private Button exitBtn;
        private ListBox listBox1;
    }
}