using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// THIS FILE GETS CALLED WITHIN THE PROGRAM.CS FILE
namespace ChimerasCauldron
{
    internal class DatabaseInitializer
    {

        /*--INITIALIZATION CODE FOR THE DATABASE-------------------------------------------------------------------------------------------------------INITIALIZATION--*/
        public static void Initialize()
        {
            using SqliteConnection connection = new SqliteConnection("Data Source=chimeras.db");
            connection.Open();

            /*--CREATE RACES---------------------------------------------------------------------------------------------------------CREATE RACES--*/
            SqliteCommand createRacesCommand = connection.CreateCommand();
            createRacesCommand.CommandText =
                @"
                    CREATE TABLE IF NOT EXISTS Races (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Description TEXT,
                        AbilityScoreIncrease TEXT,
                        Traits TEXT
                    );
                    CREATE TABLE IF NOT EXISTS Classes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Description TEXT,
                        HitDie INTEGER,
                        PrimaryAbility TEXT,
                        SavingThrows TEXT,
                        Skills TEXT
                    );
                ";
            createRacesCommand.ExecuteNonQuery();
        }

    }
}
