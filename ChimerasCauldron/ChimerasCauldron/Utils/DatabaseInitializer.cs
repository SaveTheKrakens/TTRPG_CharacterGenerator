using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// THIS FILE GETS CALLED WITHIN THE PROGRAM.CS FILE
namespace ChimerasCauldron.Utils
{
    internal class DatabaseInitializer
    {

        /*--INITIALIZATION CODE FOR THE DATABASE-------------------------------------------------------------------------------------------------------INITIALIZATION--*/
        public static void Initialize()
        {
            /*--FIND THE DND DATABASE CREATION SCRIPT AS TEXT FILE-----------------------------------------------------------------FIND SQL FILES--*/
            string[] candidates =
            {
                Path.Combine(AppContext.BaseDirectory, "DndDatabase.txt"),
                Path.Combine(AppContext.BaseDirectory, "Core", "DND", "DndDatabase.txt"),
                Path.Combine(Directory.GetCurrentDirectory(), "Core", "DND", "DndDatabase.txt"),
                Path.Combine(Directory.GetCurrentDirectory(), "DndDatabase.txt")
            };
            string? sqlFile = candidates.FirstOrDefault(File.Exists);
            if(sqlFile == null)
            {
                throw new FileNotFoundException("Cannot find sql text file for dnd creation.");
            }

            string sqlCommands = File.ReadAllText(sqlFile);

            using SqliteConnection connection = new SqliteConnection("Data Source=chimeras.db");
            connection.Open();

            /*--CREATE RACES---------------------------------------------------------------------------------------------------------CREATE RACES--*/
            SqliteCommand createDndDatabase = connection.CreateCommand();
            createDndDatabase.CommandText = sqlCommands;

            createDndDatabase.ExecuteNonQuery();
        }

    }
}
