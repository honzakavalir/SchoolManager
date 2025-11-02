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
            button_students = new Button();
            teachers_button = new Button();
            schoolClasses_button = new Button();
            schoolSubjects_button = new Button();
            SuspendLayout();
            // 
            // button_students
            // 
            button_students.Location = new Point(24, 17);
            button_students.Name = "button_students";
            button_students.Size = new Size(118, 45);
            button_students.TabIndex = 0;
            button_students.Text = "Studenti";
            button_students.UseVisualStyleBackColor = true;
            button_students.Click += button_students_Click;
            // 
            // teachers_button
            // 
            teachers_button.Location = new Point(24, 88);
            teachers_button.Name = "teachers_button";
            teachers_button.Size = new Size(118, 45);
            teachers_button.TabIndex = 1;
            teachers_button.Text = "Učitelé";
            teachers_button.UseVisualStyleBackColor = true;
            // 
            // schoolClasses_button
            // 
            schoolClasses_button.Location = new Point(162, 17);
            schoolClasses_button.Name = "schoolClasses_button";
            schoolClasses_button.Size = new Size(118, 45);
            schoolClasses_button.TabIndex = 2;
            schoolClasses_button.Text = "Třídy";
            schoolClasses_button.UseVisualStyleBackColor = true;
            // 
            // schoolSubjects_button
            // 
            schoolSubjects_button.Location = new Point(162, 88);
            schoolSubjects_button.Name = "schoolSubjects_button";
            schoolSubjects_button.Size = new Size(118, 45);
            schoolSubjects_button.TabIndex = 3;
            schoolSubjects_button.Text = "Předměty";
            schoolSubjects_button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 145);
            Controls.Add(schoolSubjects_button);
            Controls.Add(schoolClasses_button);
            Controls.Add(teachers_button);
            Controls.Add(button_students);
            Name = "MainForm";
            Text = "SchoolManager";
            ResumeLayout(false);
        }

        #endregion

        private Button button_students;
        private Button teachers_button;
        private Button schoolClasses_button;
        private Button schoolSubjects_button;
    }
}
