namespace cw.TryToGuess
{
    partial class TryToGuess_GameScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameController = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimeRem = new System.Windows.Forms.Label();
            this.firstCategory = new System.Windows.Forms.Label();
            this.secondCategory = new System.Windows.Forms.Label();
            this.minusPlus = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.difficultyTextBox = new System.Windows.Forms.TextBox();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recordsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameController)).BeginInit();
            this.SuspendLayout();
            // 
            // GameController
            // 
            this.GameController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameController.Location = new System.Drawing.Point(110, 52);
            this.GameController.Name = "GameController";
            this.GameController.Size = new System.Drawing.Size(100, 100);
            this.GameController.TabIndex = 0;
            this.GameController.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(147, 21);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "label1";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimeRem
            // 
            this.TimeRem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeRem.AutoSize = true;
            this.TimeRem.Location = new System.Drawing.Point(140, 169);
            this.TimeRem.Name = "TimeRem";
            this.TimeRem.Size = new System.Drawing.Size(35, 13);
            this.TimeRem.TabIndex = 2;
            this.TimeRem.Text = "label1";
            // 
            // firstCategory
            // 
            this.firstCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.firstCategory.AutoSize = true;
            this.firstCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstCategory.Location = new System.Drawing.Point(276, 52);
            this.firstCategory.Name = "firstCategory";
            this.firstCategory.Size = new System.Drawing.Size(41, 13);
            this.firstCategory.TabIndex = 3;
            this.firstCategory.Text = "label1";
            // 
            // secondCategory
            // 
            this.secondCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondCategory.AutoSize = true;
            this.secondCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondCategory.Location = new System.Drawing.Point(22, 52);
            this.secondCategory.Name = "secondCategory";
            this.secondCategory.Size = new System.Drawing.Size(41, 13);
            this.secondCategory.TabIndex = 4;
            this.secondCategory.Text = "label1";
            // 
            // minusPlus
            // 
            this.minusPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.minusPlus.AutoSize = true;
            this.minusPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusPlus.Location = new System.Drawing.Point(119, 207);
            this.minusPlus.Name = "minusPlus";
            this.minusPlus.Size = new System.Drawing.Size(38, 25);
            this.minusPlus.TabIndex = 5;
            this.minusPlus.Text = "+1";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(59, 93);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 59);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(246, 207);
            this.settingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(77, 25);
            this.settingButton.TabIndex = 7;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // difficultyTextBox
            // 
            this.difficultyTextBox.Location = new System.Drawing.Point(246, 184);
            this.difficultyTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.difficultyTextBox.Name = "difficultyTextBox";
            this.difficultyTextBox.Size = new System.Drawing.Size(78, 20);
            this.difficultyTextBox.TabIndex = 8;
            this.difficultyTextBox.UseWaitCursor = true;
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlsLabel.Location = new System.Drawing.Point(93, 169);
            this.controlsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(22, 24);
            this.controlsLabel.TabIndex = 9;
            this.controlsLabel.Text = "<";
            this.controlsLabel.Click += new System.EventHandler(this.controlsLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(205, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = ">";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // recordsButton
            // 
            this.recordsButton.Location = new System.Drawing.Point(11, 207);
            this.recordsButton.Margin = new System.Windows.Forms.Padding(2);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.Size = new System.Drawing.Size(77, 25);
            this.recordsButton.TabIndex = 11;
            this.recordsButton.Text = "Records";
            this.recordsButton.UseVisualStyleBackColor = true;
            this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
            // 
            // TryToGuess_GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 253);
            this.Controls.Add(this.recordsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.difficultyTextBox);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.minusPlus);
            this.Controls.Add(this.secondCategory);
            this.Controls.Add(this.firstCategory);
            this.Controls.Add(this.TimeRem);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameController);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 292);
            this.MinimumSize = new System.Drawing.Size(350, 292);
            this.Name = "TryToGuess_GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Try To Guess";
            this.Load += new System.EventHandler(this.TryToGuess_GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TryToGuess_GameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GameController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameController;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeRem;
        private System.Windows.Forms.Label firstCategory;
        private System.Windows.Forms.Label secondCategory;
        private System.Windows.Forms.Label minusPlus;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.TextBox difficultyTextBox;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recordsButton;
    }
}

