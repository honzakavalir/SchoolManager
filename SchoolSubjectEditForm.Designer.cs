namespace SchoolManager
{
    partial class SchoolSubjectEditForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            abbrTextBox = new TextBox();
            abbrLabel = new Label();
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            closeButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Název předmětu";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(242, 23);
            nameTextBox.TabIndex = 1;
            // 
            // abbrTextBox
            // 
            abbrTextBox.Location = new Point(12, 90);
            abbrTextBox.Name = "abbrTextBox";
            abbrTextBox.Size = new Size(242, 23);
            abbrTextBox.TabIndex = 3;
            // 
            // abbrLabel
            // 
            abbrLabel.AutoSize = true;
            abbrLabel.Location = new Point(12, 72);
            abbrLabel.Name = "abbrLabel";
            abbrLabel.Size = new Size(101, 15);
            abbrLabel.TabIndex = 2;
            abbrLabel.Text = "Zkratka předmětu";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(36, 15);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Popis";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(13, 158);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(241, 109);
            descriptionTextBox.TabIndex = 5;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(157, 290);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(95, 23);
            closeButton.TabIndex = 9;
            closeButton.Text = "Zavřít";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(60, 290);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Vytvořit";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // SchoolSubjectEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 324);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(abbrTextBox);
            Controls.Add(abbrLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "SchoolSubjectEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vytvořit předmět";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox abbrTextBox;
        private Label abbrLabel;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Button closeButton;
        private Button saveButton;
    }
}