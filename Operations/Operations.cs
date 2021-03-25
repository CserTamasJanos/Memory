using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;


namespace Operations
{
    public enum ErrorMessage
    {
        GamerNameDownload = 1,
        GamerNameSave = 2,
        GamesDataDownload = 3,
        NewGameSave = 4,
        SelectedFormerGameUpdate = 5,
        ButtonSaveForANewGame = 6,
        SelectedFormerGameButtonsQuery = 7,
        SelectedFormerGameButtonsUpload = 8,
        GameRecordSave = 9,
        RecordDataDownload = 10,
    }

    public static class DataAndMethodsForMemory
    {
        public delegate void DelegatePractice(string messageBoxErrorText);
        public static event DelegatePractice ErrorHandle;

        /// <summary>
        /// GamerNameDataDownload fills this list up with gamer data.
        /// </summary>
        private static List<GamerData> gamerNameList = new List<GamerData>();

        /// <summary>
        /// GamesDataDownload fills this list up with games data.
        /// </summary>
        private static List<GameData> gameDataList = new List<GameData>();

        /// <summary>
        /// This list contains a group of buttons belonge to a saved game.
        /// </summary>
        private static List<ButtonData> buttonListForFormerGame = new List<ButtonData>();

        /// <summary>
        /// RecordsDataDownload presents recorddata to this list.
        /// </summary>
        private static List<RecordData> recordDataList = new List<RecordData>();

        public static List<GamerData> GamerNameList
        {
            get
            {
                return gamerNameList.OrderBy(x => x.GamerName).ToList();
            }
        }

        public static List<GameData> GameDataList
        {
            get
            {
                return gameDataList.OrderByDescending(x => x.SaveDateTime).ToList();
            }
        }

        public static List<ButtonData> ButtonListForFOrmerGame
        {
            get
            {
                return buttonListForFormerGame;
            }
        }

        public static List<RecordData> RecordDataList
        {
            get
            {
                return recordDataList.OrderByDescending(x => x.Score).ToList();
            }
        }

        public static string errorMessageText(ErrorMessage errorCode, string exceptionMessage)
        {
            string errorMessage = String.Empty;

            switch(errorCode)
            {
                case ErrorMessage.GamerNameDownload:
                    errorMessage = Operations.ErrorQueryStringData.GamerNameDownloadErrorText;
                    break;
                case ErrorMessage.GamerNameSave:
                    errorMessage = Operations.ErrorQueryStringData.GamerNameSaveErrorText;
                    break;
                case ErrorMessage.GamesDataDownload:
                    errorMessage = Operations.ErrorQueryStringData.GamesDataDownloadErrorText;
                    break;
                case ErrorMessage.NewGameSave:
                    errorMessage = Operations.ErrorQueryStringData.NewGameSaveErrorText;
                    break;
                case ErrorMessage.SelectedFormerGameUpdate:
                    errorMessage = Operations.ErrorQueryStringData.SelectedFormerGameUpdateErrorText;
                    break;
                case ErrorMessage.ButtonSaveForANewGame:
                    errorMessage = Operations.ErrorQueryStringData.ButtonSaveForANewGameErrorText;
                    break;
                case ErrorMessage.SelectedFormerGameButtonsQuery:
                    errorMessage = Operations.ErrorQueryStringData.SelectedFormerGameButtonsQueryErrorText;
                    break;
                case ErrorMessage.SelectedFormerGameButtonsUpload:
                    errorMessage = Operations.ErrorQueryStringData.SelectedFormerGameButtonsUploadErrorText;
                    break;
                case ErrorMessage.GameRecordSave:
                    errorMessage = Operations.ErrorQueryStringData.GameRecordSaveErrorText;
                    break;
                case ErrorMessage.RecordDataDownload:
                    errorMessage = Operations.ErrorQueryStringData.RecordDataDownloadErrorText;
                    break;
            }
            return errorMessage + Environment.NewLine + exceptionMessage;
        }

        /// <summary>
        /// This void download the gamers's data for gamerNameList.
        /// </summary>
        /// <param name="gamerNameDataDownloadError"></param>
        public static bool GamerNameDataDownload ()
        {
            gamerNameList.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    SqlCommand command = new SqlCommand(Operations.QueryStringData.GamerNameDownload, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        gamerNameList.Add(new GamerData(Convert.ToInt32(reader[0]),reader[1].ToString()));
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.GamerNameDownload, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tis void fills up the gameDataList with game data based on GameData class.
        /// </summary>
        /// <param name="gamesDataDownloadException"></param>
        public static bool GamesDataDownload ()
        {
            gameDataList.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    SqlCommand command = new SqlCommand(Operations.QueryStringData.GamesDownload, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        gameDataList.Add(new GameData(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                            Convert.ToDateTime(reader[2]), Convert.ToInt32(reader[3]),Convert.ToInt32(reader[4])));
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.GamesDataDownload, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// This void saves a new record of a new game using GameData.
        /// </summary>
        /// <param name="newGameData"></param>
        /// <param name="saveNewGameDataError"></param>
        public static bool SaveNewGameData (GameData newGameData, out int newGameID)
        {
            newGameID = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    SqlCommand command = new SqlCommand(Operations.QueryStringData.NewGameSave, connection);

                    command.Parameters.Add("@SaveGameTime", SqlDbType.Int);
                    command.Parameters["@SaveGameTime"].Value = newGameData.SaveGameTime;

                    command.Parameters.Add("@SaveDateTime", SqlDbType.DateTime);
                    command.Parameters["@SaveDateTime"].Value = newGameData.SaveDateTime;

                    command.Parameters.Add("@GamerID", SqlDbType.Int);
                    command.Parameters["@GamerID"].Value = newGameData.GamerID;

                    command.Parameters.Add("@GamerClickCount", SqlDbType.Int);
                    command.Parameters["@GamerClickCount"].Value = newGameData.GamerClickCount;

                    connection.Open();

                    newGameID = (int)command.ExecuteScalar();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.NewGameSave, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// This void updates a former game.
        /// </summary>
        /// <param name="selectedGameData"></param>
        /// <param name="selectedFormerGameDataUpdateException"></param>
        public static bool SelectedFormerGameDataUpdate (GameData selectedGameData)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    SqlCommand command = new SqlCommand(Operations.QueryStringData.SelectedFormerGameUpdate, connection);

                    command.Parameters.Add("@GameID", SqlDbType.Int);
                    command.Parameters["@GameID"].Value = selectedGameData.GameID;

                    connection.Open();

                    command.Parameters.Add("@SaveGameTime", SqlDbType.Int);
                    command.Parameters["@SaveGameTime"].Value = selectedGameData.SaveGameTime;

                    command.Parameters.Add("@SaveDateTime", SqlDbType.DateTime);
                    command.Parameters["@SaveDateTime"].Value = selectedGameData.SaveDateTime;

                    command.Parameters.Add("@GamerID", SqlDbType.Int);
                    command.Parameters["@GamerID"].Value = selectedGameData.GamerID;

                    command.Parameters.Add("@GamerClickCount", SqlDbType.Int);
                    command.Parameters["@GamerClickCount"].Value = selectedGameData.GamerClickCount;

                    command.ExecuteNonQuery();
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.SelectedFormerGameUpdate, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Download the Buttons data about a game selection (GameID).
        /// </summary>
        /// <param name="selectedGameID"></param>
        /// <returns></returns>
        public static bool SelectedFormerGameButtonsDownload (int selectedGameID, out List<ButtonData> selectedSavedGameButtonList)
        {
            selectedSavedGameButtonList = new List<ButtonData>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    SqlCommand command = new SqlCommand(Operations.QueryStringData.SelectedFormerGameButtonsQuery, connection);

                    command.Parameters.Add("@SelectedGameID", SqlDbType.Int);
                    command.Parameters["@SelectedGameID"].Value = selectedGameID;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        selectedSavedGameButtonList.Add(new ButtonData(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                            Convert.ToInt32(reader[2]), Convert.ToInt32(reader[3])));
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.SelectedFormerGameButtonsQuery, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Save the buttons data belong to the game was started.
        /// </summary>
        /// <param name="aNewButtonList"></param>
        /// <param name="saveNewButtonsException"></param>
        public static bool SaveNewGameButtons(List<ButtonData> aNewButtonList)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    connection.Open();

                    foreach (ButtonData aButtonData in aNewButtonList)
                    {
                        SqlCommand command = new SqlCommand(Operations.QueryStringData.ButtonsSaveForANewGame, connection);

                        command.Parameters.Add("@GameID", SqlDbType.Int);
                        command.Parameters["@GameID"].Value = aButtonData.GameID;

                        command.Parameters.Add("@ButtonNumber", SqlDbType.Int);
                        command.Parameters["@ButtonNumber"].Value = aButtonData.ButtonNumber;

                        command.Parameters.Add("@ButtonColor", SqlDbType.Int);
                        command.Parameters["@ButtonColor"].Value = aButtonData.ButtonColor;

                        command.Parameters.Add("@ButtonVisible", SqlDbType.Int);
                        command.Parameters["@ButtonVisible"].Value = aButtonData.ButtonVisible;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.ButtonSaveForANewGame, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// This void saves the buttons belongst to a former game. 
        /// </summary>
        /// <param name="aSelectedFormerGameButton"></param>
        public static bool SaveASelectedFormerGameButtons (List<ButtonData> selectedGameButtons)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    connection.Open();

                    foreach (ButtonData aButtonData in selectedGameButtons)
                    {
                        SqlCommand command = new SqlCommand(Operations.QueryStringData.SelectedFormerGameButtonsUpload, connection);

                        command.Parameters.Add("@SelectedGameButtonVisible", SqlDbType.Int);
                        command.Parameters["@SelectedGameButtonVisible"].Value = aButtonData.ButtonVisible;

                        command.Parameters.Add("@SelectedGameID", SqlDbType.Int);
                        command.Parameters["@SelectedGameID"].Value = aButtonData.GameID;

                        command.Parameters.Add("@SelectedGameButtonNumber", SqlDbType.Int);
                        command.Parameters["@SelectedGameButtonNumber"].Value = aButtonData.ButtonNumber;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.SelectedFormerGameButtonsUpload, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// This void saves a new gamer name.
        /// </summary>
        /// <param name="aNewGamerName"></param>
        public static bool SaveNewGamerName (string aNewGamerName, out int newGamerID)
        {
            newGamerID = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    SqlCommand command = new SqlCommand(Operations.QueryStringData.GamerNameSave, connection);

                    command.Parameters.Add("@NewGamerName", SqlDbType.NChar);
                    command.Parameters["@NewGamerName"].Value = aNewGamerName;

                    connection.Open();

                    newGamerID = (int)command.ExecuteScalar();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.GamerNameSave, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Download the record data from database.
        /// </summary>
        /// <param name="recordDownloadException"></param>
        /// <returns></returns>
        public static bool RecordsDataDownload ()
        {
            recordDataList.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {

                    SqlCommand command = new SqlCommand(Operations.QueryStringData.RecordDataDownload, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        recordDataList.Add(new RecordData(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToDateTime(reader[2])
                                        , Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5])));
                    }
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.RecordDataDownload, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Save the gamescor presented by TimeBonus and GameClickScoreMaker
        /// </summary>
        /// <param name="finishedGameRecord"></param>
        /// <param name="recordSaveException"></param>
        public static bool RecordSave(RecordData finishedGameRecord)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Operations.QueryStringData.ServerAddress))
                {
                    SqlCommand command = new SqlCommand(Operations.QueryStringData.GameRecordSave, connection);

                    connection.Open();

                    command.Parameters.Add("@GamerID",SqlDbType.Int);
                    command.Parameters["@GamerID"].Value = finishedGameRecord.GamerID;

                    command.Parameters.Add("@RecordDateTime",SqlDbType.DateTime);
                    command.Parameters["@RecordDateTime"].Value = finishedGameRecord.RecordDateTime;

                    command.Parameters.Add("@ClickNumber", SqlDbType.Int);
                    command.Parameters["@ClickNumber"].Value = finishedGameRecord.ClickNumber;

                    command.Parameters.Add("@GameTime", SqlDbType.Int);
                    command.Parameters["@GameTime"].Value = finishedGameRecord.GameTime;

                    command.Parameters.Add("@Score", SqlDbType.Int);
                    command.Parameters["@Score"].Value = finishedGameRecord.Score;

                    command.ExecuteNonQuery();
                }
            }
            catch(Exception anException)
            {
                if (ErrorHandle != null)
                    ErrorHandle.Invoke(errorMessageText(ErrorMessage.GameRecordSave, anException.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// According to the name of the gamer this property gives back the games(GameData class)
        /// </summary>
        /// <param name="aSelectedGamerData"></param>
        /// <returns></returns>
        public static List<GameData> GameDataReFillByGamerName(GamerData aSelectedGamerData)
        {
            return GameDataList.Where(x => x.GamerID == aSelectedGamerData.GamerID).ToList();
        }

        /// <summary>
        /// Presents a score based on the game time, the smaller time is better (bigger score).
        /// </summary>
        /// <param name="gameTimeValue"></param>
        /// <returns></returns>
        public static int TimeBonus (int gameTimeValue)
        {
            const int maxTimeScore = 150000;
            const int bestGameTime = 50;
            const int worstGameTimeScore = 6000;
            const int balanceNumber = 5;

            if (gameTimeValue <= bestGameTime)
            {
                return maxTimeScore;
            }
            else if (gameTimeValue > bestGameTime && gameTimeValue < worstGameTimeScore)
            {
                return (worstGameTimeScore / gameTimeValue) * (worstGameTimeScore - gameTimeValue) / balanceNumber;
            }
            else if (gameTimeValue > worstGameTimeScore)
            {
                return worstGameTimeScore;
            }
            else
                return 0;        
        }
        /// <summary>
        /// Presents a score based on the click number of the game. The less clicknumber is the better. 
        /// </summary>
        /// <param name="gameClickValue"></param>
        /// <returns></returns>
        public static int GameClickScoreMaker (int gameClickValue)
        {
            const int aButtonScore = 2000;
            const int buttonnumber = 16;
            double klickScoreDouble = 0;

            if(gameClickValue != 0)
            {        
                klickScoreDouble = Convert.ToDouble((Convert.ToDouble(buttonnumber) / Convert.ToDouble(gameClickValue)) *
                                        Convert.ToDouble(buttonnumber) * Convert.ToDouble(aButtonScore));

                return Convert.ToInt32(klickScoreDouble);
            }
            else
                return 0;
        }
    }
}
