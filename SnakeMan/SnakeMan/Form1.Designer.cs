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
            this.button1 = new System.Windows.Forms.Button();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.lbCurrentFruit = new System.Windows.Forms.Label();
            this.lbFruitDescription = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbBestScore = new System.Windows.Forms.Label();
            this.BestScoreContainer = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.board.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.board.ColumnCount = 20;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.Controls.Add(this.label1, 0, 0);
            this.board.Controls.Add(this.snake, 9, 9);
            this.board.Location = new System.Drawing.Point(255, 85);
            this.board.Name = "board";
            this.board.RowCount = 20;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.board.Size = new System.Drawing.Size(400, 400);
            this.board.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.Black;
            this.snake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snake.Location = new System.Drawing.Point(183, 183);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(14, 14);
            this.snake.TabIndex = 2;
            this.snake.Paint += new System.Windows.Forms.PaintEventHandler(this.snake_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1);
            this.panel1.TabIndex = 1;
            // 
            // ticker
            // 
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDifficulty.Location = new System.Drawing.Point(3, 90);
            this.lbDifficulty.MinimumSize = new System.Drawing.Size(200, 50);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(200, 50);
            this.lbDifficulty.TabIndex = 4;
            this.lbDifficulty.Text = "Difficulty: ";
            // 
            // lbCurrentFruit
            // 
            this.lbCurrentFruit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCurrentFruit.AutoSize = true;
            this.lbCurrentFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentFruit.Location = new System.Drawing.Point(3, 140);
            this.lbCurrentFruit.MinimumSize = new System.Drawing.Size(200, 50);
            this.lbCurrentFruit.Name = "lbCurrentFruit";
            this.lbCurrentFruit.Size = new System.Drawing.Size(200, 50);
            this.lbCurrentFruit.TabIndex = 5;
            this.lbCurrentFruit.Text = "Current Fruit: ";
            // 
            // lbFruitDescription
            // 
            this.lbFruitDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFruitDescription.AutoSize = true;
            this.lbFruitDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruitDescription.Location = new System.Drawing.Point(3, 202);
            this.lbFruitDescription.MinimumSize = new System.Drawing.Size(200, 50);
            this.lbFruitDescription.Name = "lbFruitDescription";
            this.lbFruitDescription.Size = new System.Drawing.Size(200, 50);
            this.lbFruitDescription.TabIndex = 6;
            this.lbFruitDescription.Text = "Fruit Description";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(396, 12);
            this.lbScore.MinimumSize = new System.Drawing.Size(100, 50);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(100, 50);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "Score: ";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBestScore
            // 
            this.lbBestScore.AutoSize = true;
            this.lbBestScore.Location = new System.Drawing.Point(5, 290);
            this.lbBestScore.MinimumSize = new System.Drawing.Size(100, 50);
            this.lbBestScore.Name = "lbBestScore";
            this.lbBestScore.Size = new System.Drawing.Size(100, 50);
            this.lbBestScore.TabIndex = 9;
            this.lbBestScore.Text = "Best score:";
            this.lbBestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BestScoreContainer
            // 
            this.BestScoreContainer.AutoSize = true;
            this.BestScoreContainer.Location = new System.Drawing.Point(96, 309);
            this.BestScoreContainer.Name = "BestScoreContainer";
            this.BestScoreContainer.Size = new System.Drawing.Size(13, 13);
            this.BestScoreContainer.TabIndex = 10;
            this.BestScoreContainer.Text = "0";
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Location = new System.Drawing.Point(469, 31);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(13, 13);
            this.CurrentScore.TabIndex = 11;
            this.CurrentScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 694);
            this.Controls.Add(this.CurrentScore);
            this.Controls.Add(this.BestScoreContainer);
            this.Controls.Add(this.lbBestScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbFruitDescription);
            this.Controls.Add(this.lbCurrentFruit);
            this.Controls.Add(this.lbDifficulty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.board);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.board.ResumeLayout(false);
            this.board.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel snake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Label lbCurrentFruit;
        private System.Windows.Forms.Label lbFruitDescription;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbBestScore;
        private System.Windows.Forms.Label BestScoreContainer;
        private System.Windows.Forms.Label CurrentScore;
    }
}

