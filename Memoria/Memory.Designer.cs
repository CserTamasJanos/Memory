namespace Memoria
{
    partial class Memory
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
            this.timerClickInterval = new System.Windows.Forms.Timer(this.components);
            this.timer2GameInterval = new System.Windows.Forms.Timer(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelGamerName = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.buttonRecords = new System.Windows.Forms.Button();
            this.buttonStartAGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerClickInterval
            // 
            this.timerClickInterval.Interval = 3000;
            // 
            // timer2GameInterval
            // 
            this.timer2GameInterval.Interval = 1000;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(60, 69);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Kilépés";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelGamerName
            // 
            this.labelGamerName.AutoSize = true;
            this.labelGamerName.Location = new System.Drawing.Point(301, 12);
            this.labelGamerName.Name = "labelGamerName";
            this.labelGamerName.Size = new System.Drawing.Size(0, 13);
            this.labelGamerName.TabIndex = 11;
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(379, 28);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(0, 13);
            this.labelHighScore.TabIndex = 12;
            // 
            // buttonRecords
            // 
            this.buttonRecords.Location = new System.Drawing.Point(60, 41);
            this.buttonRecords.Name = "buttonRecords";
            this.buttonRecords.Size = new System.Drawing.Size(160, 23);
            this.buttonRecords.TabIndex = 2;
            this.buttonRecords.Text = "Ranglista";
            this.buttonRecords.UseVisualStyleBackColor = true;
            this.buttonRecords.Click += new System.EventHandler(this.buttonRecords_Click);
            // 
            // buttonStartAGame
            // 
            this.buttonStartAGame.Location = new System.Drawing.Point(60, 12);
            this.buttonStartAGame.Name = "buttonStartAGame";
            this.buttonStartAGame.Size = new System.Drawing.Size(160, 23);
            this.buttonStartAGame.TabIndex = 1;
            this.buttonStartAGame.Text = "Játék";
            this.buttonStartAGame.UseVisualStyleBackColor = true;
            this.buttonStartAGame.Click += new System.EventHandler(this.buttonStartAGame_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.buttonStartAGame);
            this.Controls.Add(this.buttonRecords);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.labelGamerName);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memória";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerClickInterval;
        private System.Windows.Forms.Timer timer2GameInterval;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelGamerName;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Button buttonRecords;
        private System.Windows.Forms.Button buttonStartAGame;
    }
}

