namespace Memoria
{
    partial class GameForm
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
            this.buttonSaveGame = new System.Windows.Forms.Button();
            this.labelGameTime = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Label();
            this.labelRecordText = new System.Windows.Forms.Label();
            this.labelRecorderNameText = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.labelRecorderName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerClickInterval
            // 
            this.timerClickInterval.Interval = 3000;
            this.timerClickInterval.Tick += new System.EventHandler(this.timer1_Tlick);
            // 
            // timer2GameInterval
            // 
            this.timer2GameInterval.Interval = 1000;
            this.timer2GameInterval.Tick += new System.EventHandler(this.timer2GameInterval_Tick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(10, 281);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveGame
            // 
            this.buttonSaveGame.Location = new System.Drawing.Point(249, 280);
            this.buttonSaveGame.Name = "buttonSaveGame";
            this.buttonSaveGame.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGame.TabIndex = 1;
            this.buttonSaveGame.Text = "Mentés";
            this.buttonSaveGame.UseVisualStyleBackColor = true;
            this.buttonSaveGame.Click += new System.EventHandler(this.buttonSaveGame_Click);
            // 
            // labelGameTime
            // 
            this.labelGameTime.AutoSize = true;
            this.labelGameTime.Location = new System.Drawing.Point(262, 7);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(50, 13);
            this.labelGameTime.TabIndex = 2;
            this.labelGameTime.Text = "Játék idő";
            // 
            // gameTime
            // 
            this.gameTime.AutoSize = true;
            this.gameTime.Location = new System.Drawing.Point(263, 30);
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(0, 13);
            this.gameTime.TabIndex = 3;
            // 
            // labelRecordText
            // 
            this.labelRecordText.AutoSize = true;
            this.labelRecordText.Location = new System.Drawing.Point(10, 7);
            this.labelRecordText.Name = "labelRecordText";
            this.labelRecordText.Size = new System.Drawing.Size(45, 13);
            this.labelRecordText.TabIndex = 4;
            this.labelRecordText.Text = "Rekord:";
            // 
            // labelRecorderNameText
            // 
            this.labelRecorderNameText.AutoSize = true;
            this.labelRecorderNameText.Location = new System.Drawing.Point(114, 7);
            this.labelRecorderNameText.Name = "labelRecorderNameText";
            this.labelRecorderNameText.Size = new System.Drawing.Size(30, 13);
            this.labelRecorderNameText.TabIndex = 5;
            this.labelRecorderNameText.Text = "Név:";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Location = new System.Drawing.Point(53, 7);
            this.labelRecord.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(0, 13);
            this.labelRecord.TabIndex = 6;
            // 
            // labelRecorderName
            // 
            this.labelRecorderName.AutoSize = true;
            this.labelRecorderName.Location = new System.Drawing.Point(144, 7);
            this.labelRecorderName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelRecorderName.Name = "labelRecorderName";
            this.labelRecorderName.Size = new System.Drawing.Size(0, 13);
            this.labelRecorderName.TabIndex = 7;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 315);
            this.Controls.Add(this.labelRecorderName);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelRecorderNameText);
            this.Controls.Add(this.labelRecordText);
            this.Controls.Add(this.gameTime);
            this.Controls.Add(this.labelGameTime);
            this.Controls.Add(this.buttonSaveGame);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerClickInterval;
        private System.Windows.Forms.Timer timer2GameInterval;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveGame;
        private System.Windows.Forms.Label labelGameTime;
        private System.Windows.Forms.Label gameTime;
        private System.Windows.Forms.Label labelRecordText;
        private System.Windows.Forms.Label labelRecorderNameText;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label labelRecorderName;
    }
}