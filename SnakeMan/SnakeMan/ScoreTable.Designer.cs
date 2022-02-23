namespace SnakeMan
{
    partial class ScoreTable
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
            this.lvScores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvScores
            // 
            this.lvScores.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScores.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvScores.FullRowSelect = true;
            this.lvScores.GridLines = true;
            this.lvScores.HideSelection = false;
            this.lvScores.Location = new System.Drawing.Point(0, 0);
            this.lvScores.Name = "lvScores";
            this.lvScores.Size = new System.Drawing.Size(900, 450);
            this.lvScores.TabIndex = 0;
            this.lvScores.UseCompatibleStateImageBehavior = false;
            this.lvScores.View = System.Windows.Forms.View.Details;
            this.lvScores.SelectedIndexChanged += new System.EventHandler(this.lvScores_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Difficulty";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 395;
            // 
            // ScoreTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.lvScores);
            this.Name = "ScoreTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreTable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvScores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}