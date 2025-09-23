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
                CREATE TABLE IF NOT EXISTS Classes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Hit_Dice INTEGER NOT NULL,
                    Proficiency TEXT NOT NULL,
                    Spellcasting_Ability TEXT,
                    Prepared_Spells TEXT,
                    Prepared_Spells_Change TEXT,
                    Cantrip_Progression TEXT
                );

                INSERT INTO Classes (
                    Id, 
                    Name, 
                    Description, 
                    Hit_Dice,
                    Proficiency, 
                    Spellcasting_Ability,
                    Prepared_Spells, 
                    Prepared_Spells_Change, 
                    Cantrip_Progression
                ) VALUES (
                    1,
                    ""Artificer"",
                    ""Artificer Description"",
                    8,
                    ""con,int"",
                    ""int"",
                    ""<level>/2+<intMod>"",
                    ""restlong"",
                    ""2,2,2,2,2,2,2,2,2,3,3,3,3,4,4,4,4,4,4,4""
                );                  
                ";
            createRacesCommand.ExecuteNonQuery();
        }

    }
}
