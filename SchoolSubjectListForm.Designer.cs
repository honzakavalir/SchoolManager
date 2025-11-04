namespace SchoolManager
{
    partial class SchoolSubjectListForm
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
            menuStrip = new MenuStrip();
            addSubjectToolStripMenuItem = new ToolStripMenuItem();
            upravitPředmětToolStripMenuItem = new ToolStripMenuItem();
            smazatPředmětToolStripMenuItem = new ToolStripMenuItem();
            schoolSubjectsDataGridView = new DataGridView();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schoolSubjectsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { addSubjectToolStripMenuItem, upravitPředmětToolStripMenuItem, smazatPředmětToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // addSubjectToolStripMenuItem
            // 
            addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            addSubjectToolStripMenuItem.Size = new Size(98, 20);
            addSubjectToolStripMenuItem.Text = "Přidat předmět";
            // 
            // upravitPředmětToolStripMenuItem
            // 
            upravitPředmětToolStripMenuItem.Name = "upravitPředmětToolStripMenuItem";
            upravitPředmětToolStripMenuItem.Size = new Size(105, 20);
            upravitPředmětToolStripMenuItem.Text = "Upravit předmět";
            // 
            // smazatPředmětToolStripMenuItem
            // 
            smazatPředmětToolStripMenuItem.Name = "smazatPředmětToolStripMenuItem";
            smazatPředmětToolStripMenuItem.Size = new Size(105, 20);
            smazatPředmětToolStripMenuItem.Text = "Smazat předmět";
            // 
            // schoolSubjectsDataGridView
            // 
            schoolSubjectsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            schoolSubjectsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            schoolSubjectsDataGridView.Dock = DockStyle.Fill;
            schoolSubjectsDataGridView.Location = new Point(0, 24);
            schoolSubjectsDataGridView.Name = "schoolSubjectsDataGridView";
            schoolSubjectsDataGridView.ReadOnly = true;
            schoolSubjectsDataGridView.Size = new Size(800, 426);
            schoolSubjectsDataGridView.TabIndex = 1;
            // 
            // SchoolSubjectListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(schoolSubjectsDataGridView);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "SchoolSubjectListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Seznam předmětů";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)schoolSubjectsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem addSubjectToolStripMenuItem;
        private ToolStripMenuItem upravitPředmětToolStripMenuItem;
        private ToolStripMenuItem smazatPředmětToolStripMenuItem;
        private DataGridView schoolSubjectsDataGridView;
    }
}