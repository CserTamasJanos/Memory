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
    public partial class GameStartSelection : Form
    {
        private GameData temporaryGameDataForSelectedGame;

        public GameStartSelection()
        {
            InitializeComponent();
        }

        private void GameStartSelection_Load(object sender, EventArgs e)
        {
            listViewFormerGames.FullRowSelect = true;
            GamerDataDownloadAndRefresh();

            if(!Operations.DataAndMethodsForMemory.GamesDataDownload())
            {
                this.Close();
            }
            ButtonsEnable();
        }

        /// <summary>
        /// This property presents the actual selected gamer.
        /// </summary>
        private GamerData SelectedGamer
        {
            get
            {
                return (GamerData)comboBoxRegisteredGamers.SelectedItem;
            }
        }

        /// <summary>
        /// This property presents the actual played gamedata.
        /// </summary>
        private GameData SelectedGameData
        {
            get
            {
                return temporaryGameDataForSelectedGame;
            }
        }

        /// <summary>
        /// Make a fresh GamerData for GamerNameDataDownload property
        /// </summary>
        private void GamerDataDownloadAndRefresh()
        {
            if(Operations.DataAndMethodsForMemory.GamerNameDataDownload())
            {
                comboBoxRegisteredGamers.Items.Clear();

                foreach (GamerData aGamerData in Operations.DataAndMethodsForMemory.GamerNameList)
                {
                    comboBoxRegisteredGamers.Items.Add(aGamerData);
                }
            }
        }

        /// <summary>
        /// This void make a gamedata refresh belong to the selected player name
        /// </summary>
        private void GameDataUpdateBelongsToTheSelectedName()
        {
            temporaryGameDataForSelectedGame = null;
            listViewFormerGames.SelectedItems.Clear();
            listViewFormerGames.Items.Clear();

            ////I use tags to be able to identify the GameData
            if(Operations.DataAndMethodsForMemory.GamesDataDownload())
            {
                foreach(GameData aGameData in Operations.DataAndMethodsForMemory.GameDataReFillByGamerName(SelectedGamer))
                {
                    ListViewItem aSelectedGamerData = new ListViewItem(aGameData.SaveDateTime.ToString());
                    aSelectedGamerData.SubItems.Add(aGameData.GamerClickCount.ToString());

                    aSelectedGamerData.Tag = aGameData.GameID;

                    listViewFormerGames.Items.Add(aSelectedGamerData);
                }
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Opens a small form to register new players.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGamer_Click(object sender, EventArgs e)
        {
            NewGamer newGamer = new NewGamer(this.Location.X, this.Location.Y);

            newGamer.ShowDialog();

            if (newGamer.DialogResult == DialogResult.OK)
            {
                GamerDataDownloadAndRefresh();

                GamerData newRegisteredGamer = (comboBoxRegisteredGamers.Items.Cast<GamerData>().FirstOrDefault(x => x.GamerID == newGamer.NewGamerToSet.GamerID));

                if(newRegisteredGamer != null)
                {
                    comboBoxRegisteredGamers.SelectedItem = newRegisteredGamer;
                }
            }
        }

        /// <summary>
        /// Back to main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonsEnable ()
        {
            buttonNewGame.Enabled =
            buttonFormerGameStart.Enabled =
            listViewFormerGames.Enabled = true;

            if (SelectedGamer == null)
            {
                buttonNewGame.Enabled =
                listViewFormerGames.Enabled = false;
            }
            if (SelectedGameData == null)
            {
                buttonFormerGameStart.Enabled = false;
            }
        }
        /// <summary>
        /// Generate the specific Form (new game or a former game) based on the sender Button Tag.
        /// </summary>
        /// <param name="sender"></param>
        private void NewGameForm (object sender)
        {
            bool itWasANewGame;

            if(sender is Button)
            {
                itWasANewGame = (sender == buttonNewGame); //megkérdezni, hogyha van kettő egyenlőségjel akkor azmár kiírtékelés....   //? true : false;

                GameForm gameForm = new GameForm(SelectedGameData, SelectedGamer, itWasANewGame);

                DialogResult gameFormDialogresult = gameForm.ShowDialog();

                if (gameForm.DialogResult == DialogResult.Cancel)
                {
                    GameDataUpdateBelongsToTheSelectedName();
                    ButtonsEnable();
                }
            }
        }

        /// <summary>
        /// Opens a form with new game default settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGameForm(sender);
        }

        private void comboBoxRegisteredGamers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameDataUpdateBelongsToTheSelectedName();
            ButtonsEnable();
        }
        /// <summary>
        /// Set the selected Item of the ListView when listViewItem is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFormerGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewFormerGames.SelectedItems.Count > 0)
            {
                GameData temporaryGameData = Operations.DataAndMethodsForMemory.GameDataReFillByGamerName(SelectedGamer).FirstOrDefault(x => x.GameID ==
                                        Convert.ToInt32(listViewFormerGames.SelectedItems[0].Tag));

                if (temporaryGameData != null)
                {
                    temporaryGameDataForSelectedGame = temporaryGameData;
                }
            }
            ButtonsEnable();
            listViewFormerGames.Focus();
        }
    }
}
