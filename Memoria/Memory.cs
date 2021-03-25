using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Operations;

namespace Memoria
{

    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Operations.DataAndMethodsForMemory.ErrorHandle += ErrorHappenedMessageBoxPopUp;

            if(!Operations.DataAndMethodsForMemory.GamerNameDataDownload())
            {
                this.Close();
            }
        }

        private void ErrorHappenedMessageBoxPopUp(string errorMessageForMessageBox)
        {
            MessageBox.Show(errorMessageForMessageBox);
        }
        /// <summary>
        /// Quit from the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens records form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecords_Click(object sender, EventArgs e)
        {
            BestResults bestresults = new BestResults();

            bestresults.ShowDialog();
        }

        /// <summary>
        /// Open form to start a game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartAGame_Click(object sender, EventArgs e)
        {
            GameStartSelection gameStartSelection = new GameStartSelection();

            gameStartSelection.ShowDialog();
        }
    }
}
