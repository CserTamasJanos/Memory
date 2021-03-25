using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class GamerData
    {
        public int GamerID { get; set; }
        public string GamerName { get; set; }

        public GamerData (int gamerID, string gamerName)
        {
            GamerID = gamerID;
            GamerName = gamerName;
        }

        public override string ToString()
        {
            return GamerName.Trim();
        }
    }

    public class GameData
    {
        public int GameID { get; set; }
        public int SaveGameTime { get; set; }
        public DateTime SaveDateTime { get; set; }
        public int GamerID { get; set; }
        public int GamerClickCount { get; set; }

        public GameData (int gameID, int saveGameTime, DateTime saveDateTime, int gamerId, int gamerClickCount)
        {
            GameID = gameID;
            SaveGameTime = saveGameTime;
            SaveDateTime = saveDateTime;
            GamerID = gamerId;
            GamerClickCount = gamerClickCount;
        }

        public GameData(int saveGameTime, DateTime saveDateTime, int gamerId, int gamerClickCount)
        {
            SaveGameTime = saveGameTime;
            SaveDateTime = saveDateTime;
            GamerID = gamerId;
            GamerClickCount = gamerClickCount;
        }

        public override string ToString()
        {
            return SaveDateTime + " -- " + SaveGameTime;
        }
    }

    public class ButtonData
    {
        public int GameID { get; set; }
        public int ButtonNumber { get; set; }
        public int ButtonColor { get; set; }
        public int ButtonVisible { get; set; }

        public ButtonData(int gameID, int buttonNumber, int buttonColor, int buttonVisible)
        {
            GameID = gameID;
            ButtonNumber = buttonNumber;
            ButtonColor = buttonColor;
            ButtonVisible = buttonVisible;
        }

        public ButtonData(int buttonColor)//????2020.07.28
        {
            ButtonColor = buttonColor;
        }
    }

    public class RecordData
    {
        public int RecordID { get; set; }
        public int GamerID { get; set; }
        public DateTime RecordDateTime { get; set; }
        public int ClickNumber { get; set; }
        public int GameTime { get; set; }
        public int Score { get; set; }

        public RecordData (int recordID, int gamerID, DateTime recordDateTime, int clickNumber, int gameTime, int score)
        {
            RecordID = recordID;
            GamerID = gamerID;
            RecordDateTime = recordDateTime;
            ClickNumber = clickNumber;
            GameTime = gameTime;
            Score = score;
        }

        public RecordData (int gamerID, DateTime recordDateTime,int clickNumber, int gameTime, int score)
        {
            GamerID = gamerID;
            RecordDateTime = recordDateTime;
            ClickNumber = clickNumber;
            GameTime = gameTime;
            Score = score;
        }

        public override string ToString()
        {
            return ClickNumber + " -- " + TimeSpan.FromSeconds(GameTime) + " -- " + Score; 
        }
    }
    /// <summary>
    /// Text for the error messages queries produce in relation with the database.
    /// </summary>
    public class ErrorQueryStringData
    {
        public const string GamerNameDownloadErrorText = "A játékosadatok betöltése során hiba történt.";
        public const string GamerNameSaveErrorText = "Az új játékos nevének mentése során hiba történt.";
        public const string GamesDataDownloadErrorText = "A játékadatok betöltése során hiba történt.";
        public const string NewGameSaveErrorText = "Az új játék mentése során hiba történt.";
        public const string SelectedFormerGameUpdateErrorText = "A játék mentése során hiba történt.";
        public const string SelectedGamerNameGameDownloadErrorText = "A kiválasztott játékoshoz tartozó játékadatok letöltése során hiba történt.";
        public const string ButtonSaveForANewGameErrorText = "Az új játékhoz tartozó játékmező adatainak mentése közben hiba történt.";
        public const string SelectedFormerGameButtonsQueryErrorText = "A korábbi játékhoz tartozó játékmező adatok letöltése közben hiba történt.";
        public const string SelectedFormerGameButtonsUploadErrorText = "A korábbi játékhoz tartozó játékmező adatok mentése során hiba történt.";
        public const string GameRecordSaveErrorText = "A rekord adatok mentése során hiba történt.";
        public const string RecordDataDownloadErrorText = "A rekord adatok letöltése közben hiba történt.";
    }
    /// <summary>
    /// Querystrings for queries.
    /// </summary>
    public class QueryStringData
    {
        public const string ServerAddress = @"Data Source=DESKTOP-HHV34GN\SQLEXPRESS; Initial Catalog=Practice; Integrated Security=true";

        public const string GamerNameDownload = @" SELECT GamerID
                                                 ,GamerName
                                                  FROM GamerData ";

        public const string GamerNameSave = @" INSERT INTO GamerData(GamerName) OUTPUT INSERTED.GamerID
                                              VALUES (@NewGamerName) ";

        public const string GamesDownload = @" SELECT GameID
	                                         ,SaveGameTime
	                                         ,SaveDateTime
	                                         ,GamerID
                                             ,GamerClickCount
	                                         FROM GameSave ";

        public const string NewGameSave = @" INSERT INTO GameSave(SaveGameTime
				                                      ,SaveDateTime
				                                      ,GamerID
                                                      ,GamerClickCount) OUTPUT INSERTED.GameID
				                                	  VALUES(@SaveGameTime
                                                            ,@SaveDateTime
                                                            ,@GamerID
                                                            ,@GamerClickCount) ";

        public const string SelectedFormerGameUpdate = @" UPDATE GameSave
                                               SET SaveGameTime = @SaveGameTime
                                               ,SaveDateTime = @SaveDateTime
                                               ,GamerID= @GamerID
                                               ,GamerClickCount = @GamerClickCount
                                               WHERE GameID = @GameID ";

        public const string ButtonsSaveForANewGame = @" INSERT INTO ButtonData(GameID
                                            ,ButtonNumber
                                            ,ButtonColor
                                            ,ButtonVisible)
                                            VALUES(@GameID
                                                   ,@ButtonNumber
                                                   ,@ButtonColor
                                                   ,@ButtonVisible) ";

        public const string SelectedFormerGameButtonsQuery = @" SELECT GameID
	                                                  ,ButtonNumber
	                                                  ,ButtonColor
	                                                  ,ButtonVisible
	                                                  FROM ButtonData
	                                                  WHERE GameID = @SelectedGameID ";

        public const string SelectedFormerGameButtonsUpload = @" UPDATE ButtonData
                                                       SET ButtonVisible = @SelectedGameButtonVisible
                                                       WHERE GameID = @SelectedGameID AND ButtonNumber = @SelectedGameButtonNumber ";

        public const string GameRecordSave = @" INSERT INTO RecordsData(GamerID
                                                           ,RecordDateTime
                                                           ,ClickNumber
                                                           ,GameTime
                                                           ,Score)
                                                    VALUES (@GamerID
                                                           ,@RecordDateTime
                                                           ,@ClickNumber
                                                           ,@GameTime
                                                           ,@Score) ";

        public const string RecordDataDownload = @" SELECT RecordID, GamerID, RecordDateTime, ClickNumber, GameTime, Score
                                                FROM RecordsData
                                                ORDER BY Score DESC ";
    }
}
