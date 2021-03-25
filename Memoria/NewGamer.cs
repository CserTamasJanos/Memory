using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operations;

namespace Memoria
{
    public partial class NewGamer : Form
    {
        private const string TextBoxIsEmpty = "A beviteli mező üres. Írjon be egy nevet!";
        private const string NameIsAlreadyExixts = "Ez a név már létezik. Írjon be másik nevet!";
        private const string NameHasBeenRegistered = "A név regisztrálásra került.";
        private readonly Color ErrorColor = Color.Red;
        private const int MaxBorderDistance = 400;
        private const int NewGamerPositionX = 350;

        public GamerData NewGamerToSet
        {
            get; set;
        }

        public NewGamer(int gameStartSelectionLocationX, int gameStartSelectionLocationY)
        {
            InitializeComponent();

            if(gameStartSelectionLocationX < MaxBorderDistance )
            {
                this.Location = new Point(gameStartSelectionLocationX + NewGamerPositionX, gameStartSelectionLocationY);
            }
            else
            {
                this.Location = new Point(gameStartSelectionLocationX - NewGamerPositionX, gameStartSelectionLocationY);
            }
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        /// <summary>
        /// Small inspection for NAme input.
        /// </summary>
        /// <param name="labelErrorText"></param>
        /// <returns></returns>
        private bool ErrorHappened(string labelErrorText)
        {
            labelError.Text = labelErrorText;
            textBoxNewGamerName.BackColor = ErrorColor;
            return true;
        }

        /// <summary>
        /// Save the a new gamer name, checks the Input and the Database wether the name has already exists r not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            textBoxNewGamerName.BackColor = SystemColors.Window;
            labelError.Text = String.Empty;
            bool errorHappened = false;

            GamerData aGamername = Operations.DataAndMethodsForMemory.GamerNameList.FirstOrDefault
                                    (x => x.GamerName.Trim().ToLower() == textBoxNewGamerName.Text.Trim().ToLower());

            if (String.IsNullOrEmpty(textBoxNewGamerName.Text))
            {
                errorHappened = ErrorHappened(TextBoxIsEmpty);
            }
            else if(aGamername != null)
            {
                errorHappened = ErrorHappened(NameIsAlreadyExixts);
            }
            if(!errorHappened) 
            {
                int newGamerID;

                if(Operations.DataAndMethodsForMemory.SaveNewGamerName(textBoxNewGamerName.Text.Trim(), out newGamerID))
                {
                    if(Operations.DataAndMethodsForMemory.GamerNameDataDownload())
                    {
                        NewGamerToSet = Operations.DataAndMethodsForMemory.GamerNameList.FirstOrDefault(x => x.GamerID == newGamerID);

                        if (NewGamerToSet != null)
                        {
                            MessageBox.Show(NameHasBeenRegistered);
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
        }

        private void NewGamer_Load(object sender, EventArgs e)
        {
            if(!Operations.DataAndMethodsForMemory.GamerNameDataDownload())
            {
                this.Close();
            }
        }
    }
}
