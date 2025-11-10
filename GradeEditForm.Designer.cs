namespace SchoolManager
{
    partial class GradeEditForm
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
            studentLabel = new Label();
            studentTextBox = new TextBox();
            schoolSubjectLabel = new Label();
            schoolSubjectComboBox = new ComboBox();
            gradeComboBox = new ComboBox();
            gradeLabel = new Label();
            noteLabel = new Label();
            noteTextBox = new TextBox();
            closeButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(12, 9);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(48, 15);
            studentLabel.TabIndex = 0;
            studentLabel.Text = "Student";
            // 
            // studentTextBox
            // 
            studentTextBox.Location = new Point(12, 27);
            studentTextBox.Name = "studentTextBox";
            studentTextBox.ReadOnly = true;
            studentTextBox.Size = new Size(297, 23);
            studentTextBox.TabIndex = 1;
            // 
            // schoolSubjectLabel
            // 
            schoolSubjectLabel.AutoSize = true;
            schoolSubjectLabel.Location = new Point(12, 78);
            schoolSubjectLabel.Name = "schoolSubjectLabel";
            schoolSubjectLabel.Size = new Size(52, 15);
            schoolSubjectLabel.TabIndex = 2;
            schoolSubjectLabel.Text = "Předmět";
            // 
            // schoolSubjectComboBox
            // 
            schoolSubjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            schoolSubjectComboBox.FormattingEnabled = true;
            schoolSubjectComboBox.Location = new Point(12, 96);
            schoolSubjectComboBox.Name = "schoolSubjectComboBox";
            schoolSubjectComboBox.Size = new Size(297, 23);
            schoolSubjectComboBox.TabIndex = 3;
            // 
            // gradeComboBox
            // 
            gradeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gradeComboBox.FormattingEnabled = true;
            gradeComboBox.Location = new Point(12, 162);
            gradeComboBox.Name = "gradeComboBox";
            gradeComboBox.Size = new Size(297, 23);
            gradeComboBox.TabIndex = 5;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new Point(12, 144);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(50, 15);
            gradeLabel.TabIndex = 4;
            gradeLabel.Text = "Známka";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(12, 207);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(62, 15);
            noteLabel.TabIndex = 6;
            noteLabel.Text = "Poznámka";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(12, 225);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(297, 102);
            noteTextBox.TabIndex = 8;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(214, 352);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(95, 23);
            closeButton.TabIndex = 10;
            closeButton.Text = "Zavřít";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(117, 352);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 23);
            saveButton.TabIndex = 9;
            saveButton.Text = "Vytvořit";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // GradeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 387);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(noteTextBox);
            Controls.Add(noteLabel);
            Controls.Add(gradeComboBox);
            Controls.Add(gradeLabel);
            Controls.Add(schoolSubjectComboBox);
            Controls.Add(schoolSubjectLabel);
            Controls.Add(studentTextBox);
            Controls.Add(studentLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GradeEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nová známka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentLabel;
        private TextBox studentTextBox;
        private Label schoolSubjectLabel;
        private ComboBox schoolSubjectComboBox;
        private ComboBox gradeComboBox;
        private Label gradeLabel;
        private Label noteLabel;
        private TextBox noteTextBox;
        private Button closeButton;
        private Button saveButton;
    }
}