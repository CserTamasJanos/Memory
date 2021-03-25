namespace Memoria
{
    partial class BestResults
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
            this.labelMainText = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listViewRecords = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTurnedTilesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGameTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelMainText
            // 
            this.labelMainText.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMainText.Location = new System.Drawing.Point(0, 0);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.Size = new System.Drawing.Size(484, 13);
            this.labelMainText.TabIndex = 1;
            this.labelMainText.Text = "Legnagyobb pontszámok";
            this.labelMainText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 259);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listViewRecords
            // 
            this.listViewRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnTurnedTilesCount,
            this.columnGameTime,
            this.columnScore});
            this.listViewRecords.Location = new System.Drawing.Point(12, 23);
            this.listViewRecords.MultiSelect = false;
            this.listViewRecords.Name = "listViewRecords";
            this.listViewRecords.Size = new System.Drawing.Size(460, 226);
            this.listViewRecords.TabIndex = 1;
            this.listViewRecords.UseCompatibleStateImageBehavior = false;
            this.listViewRecords.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Név";
            this.columnName.Width = 98;
            // 
            // columnTurnedTilesCount
            // 
            this.columnTurnedTilesCount.Text = "Megfordított lapok száma";
            this.columnTurnedTilesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTurnedTilesCount.Width = 140;
            // 
            // columnGameTime
            // 
            this.columnGameTime.Text = "Játékidő (mp)";
            this.columnGameTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnGameTime.Width = 80;
            // 
            // columnScore
            // 
            this.columnScore.Text = "Pontszám";
            this.columnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnScore.Width = 120;
            // 
            // BestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 293);
            this.Controls.Add(this.listViewRecords);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelMainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BestResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rekordok";
            this.Load += new System.EventHandler(this.BestResults_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMainText;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewRecords;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnTurnedTilesCount;
        private System.Windows.Forms.ColumnHeader columnGameTime;
        private System.Windows.Forms.ColumnHeader columnScore;
    }
}