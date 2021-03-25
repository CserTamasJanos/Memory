namespace Memoria
{
    partial class GameStartSelection
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
            this.buttonFormerGameStart = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonNewGamerName = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxRegisteredGamers = new System.Windows.Forms.ComboBox();
            this.labelChoseAGamer = new System.Windows.Forms.Label();
            this.listViewFormerGames = new System.Windows.Forms.ListView();
            this.columnSaveDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClickCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonFormerGameStart
            // 
            this.buttonFormerGameStart.Location = new System.Drawing.Point(99, 207);
            this.buttonFormerGameStart.Name = "buttonFormerGameStart";
            this.buttonFormerGameStart.Size = new System.Drawing.Size(208, 23);
            this.buttonFormerGameStart.TabIndex = 5;
            this.buttonFormerGameStart.Text = "Korábbi játék indítása";
            this.buttonFormerGameStart.UseVisualStyleBackColor = true;
            this.buttonFormerGameStart.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(8, 63);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 3;
            this.buttonNewGame.Text = "Új játék";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonNewGamerName
            // 
            this.buttonNewGamerName.Location = new System.Drawing.Point(8, 30);
            this.buttonNewGamerName.Name = "buttonNewGamerName";
            this.buttonNewGamerName.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGamerName.TabIndex = 1;
            this.buttonNewGamerName.Text = "Új játékos";
            this.buttonNewGamerName.UseVisualStyleBackColor = true;
            this.buttonNewGamerName.Click += new System.EventHandler(this.buttonNewGamer_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(8, 207);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxRegisteredGamers
            // 
            this.comboBoxRegisteredGamers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegisteredGamers.FormattingEnabled = true;
            this.comboBoxRegisteredGamers.Location = new System.Drawing.Point(99, 32);
            this.comboBoxRegisteredGamers.Name = "comboBoxRegisteredGamers";
            this.comboBoxRegisteredGamers.Size = new System.Drawing.Size(208, 21);
            this.comboBoxRegisteredGamers.TabIndex = 2;
            this.comboBoxRegisteredGamers.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegisteredGamers_SelectedIndexChanged);
            // 
            // labelChoseAGamer
            // 
            this.labelChoseAGamer.AutoSize = true;
            this.labelChoseAGamer.Location = new System.Drawing.Point(7, 7);
            this.labelChoseAGamer.Name = "labelChoseAGamer";
            this.labelChoseAGamer.Size = new System.Drawing.Size(98, 13);
            this.labelChoseAGamer.TabIndex = 6;
            this.labelChoseAGamer.Text = "Válasszon játékost!";
            // 
            // listViewFormerGames
            // 
            this.listViewFormerGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSaveDateTime,
            this.columnClickCount});
            this.listViewFormerGames.Location = new System.Drawing.Point(99, 63);
            this.listViewFormerGames.MultiSelect = false;
            this.listViewFormerGames.Name = "listViewFormerGames";
            this.listViewFormerGames.Size = new System.Drawing.Size(208, 138);
            this.listViewFormerGames.TabIndex = 4;
            this.listViewFormerGames.UseCompatibleStateImageBehavior = false;
            this.listViewFormerGames.View = System.Windows.Forms.View.Details;
            this.listViewFormerGames.SelectedIndexChanged += new System.EventHandler(this.listViewFormerGames_SelectedIndexChanged);
            // 
            // columnSaveDateTime
            // 
            this.columnSaveDateTime.Text = "Mentés időpontja";
            this.columnSaveDateTime.Width = 120;
            // 
            // columnClickCount
            // 
            this.columnClickCount.Text = "Kattintásszám";
            this.columnClickCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnClickCount.Width = 80;
            // 
            // GameStartSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 242);
            this.Controls.Add(this.listViewFormerGames);
            this.Controls.Add(this.labelChoseAGamer);
            this.Controls.Add(this.comboBoxRegisteredGamers);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNewGamerName);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonFormerGameStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameStartSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Játékmenü";
            this.Load += new System.EventHandler(this.GameStartSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFormerGameStart;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonNewGamerName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxRegisteredGamers;
        private System.Windows.Forms.Label labelChoseAGamer;
        private System.Windows.Forms.ListView listViewFormerGames;
        private System.Windows.Forms.ColumnHeader columnSaveDateTime;
        private System.Windows.Forms.ColumnHeader columnClickCount;
    }
}