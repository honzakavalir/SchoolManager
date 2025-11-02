namespace SchoolManager
{
    partial class MainForm
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
            studentsButton = new Button();
            teachersButton = new Button();
            schoolClassesButton = new Button();
            schoolSubjectsButton = new Button();
            SuspendLayout();
            // 
            // studentsButton
            // 
            studentsButton.Location = new Point(24, 17);
            studentsButton.Name = "studentsButton";
            studentsButton.Size = new Size(118, 45);
            studentsButton.TabIndex = 0;
            studentsButton.Text = "Studenti";
            studentsButton.UseVisualStyleBackColor = true;
            studentsButton.Click += button_students_Click;
            // 
            // teachersButton
            // 
            teachersButton.Location = new Point(24, 88);
            teachersButton.Name = "teachersButton";
            teachersButton.Size = new Size(118, 45);
            teachersButton.TabIndex = 1;
            teachersButton.Text = "Učitelé";
            teachersButton.UseVisualStyleBackColor = true;
            teachersButton.Click += teachersButton_Click;
            // 
            // schoolClassesButton
            // 
            schoolClassesButton.Location = new Point(162, 17);
            schoolClassesButton.Name = "schoolClassesButton";
            schoolClassesButton.Size = new Size(118, 45);
            schoolClassesButton.TabIndex = 2;
            schoolClassesButton.Text = "Třídy";
            schoolClassesButton.UseVisualStyleBackColor = true;
            // 
            // schoolSubjectsButton
            // 
            schoolSubjectsButton.Location = new Point(162, 88);
            schoolSubjectsButton.Name = "schoolSubjectsButton";
            schoolSubjectsButton.Size = new Size(118, 45);
            schoolSubjectsButton.TabIndex = 3;
            schoolSubjectsButton.Text = "Předměty";
            schoolSubjectsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 145);
            Controls.Add(schoolSubjectsButton);
            Controls.Add(schoolClassesButton);
            Controls.Add(teachersButton);
            Controls.Add(studentsButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolManager";
            ResumeLayout(false);
        }

        #endregion

        private Button studentsButton;
        private Button teachersButton;
        private Button schoolClassesButton;
        private Button schoolSubjectsButton;
    }
}
