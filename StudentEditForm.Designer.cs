namespace SchoolManager
{
    partial class StudentEditForm
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            birthDateLabel = new Label();
            birthDateDateTimePicker = new DateTimePicker();
            saveButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(42, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Jméno";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 27);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(294, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(12, 81);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(294, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 63);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(51, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Příjmení";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(12, 119);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(91, 15);
            birthDateLabel.TabIndex = 4;
            birthDateLabel.Text = "Datum narození";
            // 
            // birthDateDateTimePicker
            // 
            birthDateDateTimePicker.Location = new Point(12, 137);
            birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            birthDateDateTimePicker.Size = new Size(294, 23);
            birthDateDateTimePicker.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(114, 180);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 23);
            saveButton.TabIndex = 6;
            saveButton.Text = "Vytvořit";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(211, 180);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(95, 23);
            closeButton.TabIndex = 7;
            closeButton.Text = "Zavřít";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // StudentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 215);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(birthDateDateTimePicker);
            Controls.Add(birthDateLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Name = "StudentEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vytvořit studenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Label birthDateLabel;
        private DateTimePicker birthDateDateTimePicker;
        private Button saveButton;
        private Button closeButton;
    }
}