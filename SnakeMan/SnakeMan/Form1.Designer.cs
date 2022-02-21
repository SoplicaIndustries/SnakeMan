namespace SnakeMan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.board = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.snake = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.lbCurrentFruit = new System.Windows.Forms.Label();
            this.lbFruitDescription = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbBestScore = new System.Windows.Forms.Label();
            this.BestScoreContainer = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.lbCurrentFruitContainer = new System.Windows.Forms.Label();
            this.lbFruitType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.board.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.board.ColumnCount = 20;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.board.Controls.Add(this.label1, 0, 0);
            this.board.Controls.Add(this.snake, 9, 9);
            this.board.Location = new System.Drawing.Point(340, 105);
            this.board.Margin = new System.Windows.Forms.Padding(4);
            this.board.Name = "board";
            this.board.RowCount = 20;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.board.Size = new System.Drawing.Size(533, 492);
            this.board.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.Black;
            this.snake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snake.Location = new System.Drawing.Point(239, 221);
            this.snake.Margin = new System.Windows.Forms.Padding(4);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(19, 17);
            this.snake.TabIndex = 2;
            this.snake.Paint += new System.Windows.Forms.PaintEventHandler(this.snake_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(91, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1);
            this.panel1.TabIndex = 1;
            // 
            // ticker
            // 
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDifficulty.Location = new System.Drawing.Point(-6, 0);
            this.lbDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDifficulty.MinimumSize = new System.Drawing.Size(267, 62);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(267, 62);
            this.lbDifficulty.TabIndex = 4;
            this.lbDifficulty.Text = "Difficulty: ";
            // 
            // lbCurrentFruit
            // 
            this.lbCurrentFruit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCurrentFruit.AutoSize = true;
            this.lbCurrentFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentFruit.Location = new System.Drawing.Point(-6, 0);
            this.lbCurrentFruit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrentFruit.MinimumSize = new System.Drawing.Size(180, 30);
            this.lbCurrentFruit.Name = "lbCurrentFruit";
            this.lbCurrentFruit.Size = new System.Drawing.Size(182, 31);
            this.lbCurrentFruit.TabIndex = 5;
            this.lbCurrentFruit.Text = "Current Fruit: ";
            // 
            // lbFruitDescription
            // 
            this.lbFruitDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFruitDescription.AutoSize = true;
            this.lbFruitDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruitDescription.Location = new System.Drawing.Point(-6, 102);
            this.lbFruitDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFruitDescription.MinimumSize = new System.Drawing.Size(267, 62);
            this.lbFruitDescription.Name = "lbFruitDescription";
            this.lbFruitDescription.Size = new System.Drawing.Size(267, 62);
            this.lbFruitDescription.TabIndex = 6;
            this.lbFruitDescription.Text = "Fruit Description";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(528, 15);
            this.lbScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScore.MinimumSize = new System.Drawing.Size(133, 62);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(133, 62);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "Score: ";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBestScore
            // 
            this.lbBestScore.AutoSize = true;
            this.lbBestScore.Location = new System.Drawing.Point(-3, 62);
            this.lbBestScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBestScore.MinimumSize = new System.Drawing.Size(133, 62);
            this.lbBestScore.Name = "lbBestScore";
            this.lbBestScore.Size = new System.Drawing.Size(133, 62);
            this.lbBestScore.TabIndex = 9;
            this.lbBestScore.Text = "Best score:";
            this.lbBestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BestScoreContainer
            // 
            this.BestScoreContainer.AutoSize = true;
            this.BestScoreContainer.Location = new System.Drawing.Point(150, 85);
            this.BestScoreContainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BestScoreContainer.Name = "BestScoreContainer";
            this.BestScoreContainer.Size = new System.Drawing.Size(14, 16);
            this.BestScoreContainer.TabIndex = 10;
            this.BestScoreContainer.Text = "0";
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Location = new System.Drawing.Point(625, 38);
            this.CurrentScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(14, 16);
            this.CurrentScore.TabIndex = 11;
            this.CurrentScore.Text = "0";
            // 
            // lbCurrentFruitContainer
            // 
            this.lbCurrentFruitContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCurrentFruitContainer.AutoSize = true;
            this.lbCurrentFruitContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentFruitContainer.Location = new System.Drawing.Point(167, 0);
            this.lbCurrentFruitContainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrentFruitContainer.MaximumSize = new System.Drawing.Size(150, 40);
            this.lbCurrentFruitContainer.MinimumSize = new System.Drawing.Size(150, 40);
            this.lbCurrentFruitContainer.Name = "lbCurrentFruitContainer";
            this.lbCurrentFruitContainer.Size = new System.Drawing.Size(150, 40);
            this.lbCurrentFruitContainer.TabIndex = 12;
            this.lbCurrentFruitContainer.Click += new System.EventHandler(this.lbCurrentFruitContainer_Click);
            // 
            // lbFruitType
            // 
            this.lbFruitType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFruitType.AutoSize = true;
            this.lbFruitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruitType.Location = new System.Drawing.Point(-6, 40);
            this.lbFruitType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFruitType.MinimumSize = new System.Drawing.Size(267, 62);
            this.lbFruitType.Name = "lbFruitType";
            this.lbFruitType.Size = new System.Drawing.Size(267, 62);
            this.lbFruitType.TabIndex = 13;
            this.lbFruitType.Text = "Type: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lbDifficulty);
            this.panel2.Controls.Add(this.BestScoreContainer);
            this.panel2.Controls.Add(this.lbBestScore);
            this.panel2.Location = new System.Drawing.Point(27, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 307);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.lbCurrentFruitContainer);
            this.panel3.Controls.Add(this.lbCurrentFruit);
            this.panel3.Controls.Add(this.lbFruitType);
            this.panel3.Controls.Add(this.lbFruitDescription);
            this.panel3.Location = new System.Drawing.Point(27, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 276);
            this.panel3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 854);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CurrentScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.board);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.board.ResumeLayout(false);
            this.board.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel snake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Label lbCurrentFruit;
        private System.Windows.Forms.Label lbFruitDescription;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbBestScore;
        private System.Windows.Forms.Label BestScoreContainer;
        private System.Windows.Forms.Label CurrentScore;
        private System.Windows.Forms.Label lbCurrentFruitContainer;
        private System.Windows.Forms.Label lbFruitType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

