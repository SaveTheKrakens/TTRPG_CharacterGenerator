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
            SqliteCommand createClassesCommand = connection.CreateCommand();
            createClassesCommand.CommandText =
                @"
                -- Drop table first
                DROP TABLE IF EXISTS Classes;

                -- CREATE TABLE
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

                -- ADDING ARTIFICER ------------------------------------------------------------
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

                -- ADDING BARBARIAN ------------------------------------------------------------
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
                    2,
                    ""Barbarian"",
                    ""Barbarian Description"",
                    12,
                    ""str,con"",
                    NULL,
                    NULL,
                    NULL,
                    NULL
                );

                -- BARD ------------------------------------------------------------------------
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
                    3,
                    ""Bard"",
                    ""Bard Description"",
                    8,
                    ""dex,cha"",
                    ""cha"",
                    ""4,5,6,7,8,9,10,11,12,14,15,15,16,18,19,19,20,22,22,22"",
                    NULL,
                    ""2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4""
                );   

                -- ADDING CLERIC --------------------------------------------------------------
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
                    4,
                    ""Cleric"",
                    ""Cleric Description"",
                    8,
                    ""wis,cha"",
                    ""wis"",
                    ""<level>+<wisMod>"",
                    ""restlong"",
                    ""3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5""
                );

                -- ADDING DRUID ----------------------------------------------------------------
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
                    5,
                    ""Druid"",
                    ""Druid Description"",
                    8,
                    ""int,wis"",
                    ""wis"",
                    ""<level>+<wisMod>"",
                    ""restlong"",
                    ""2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4""
                );

                -- ADDING FIGHTER --------------------------------------------------------------
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
                    6,
                    ""Fighter"",
                    ""Fighter Description"",
                    10,
                    ""str,con"",
                    NULL,
                    NULL,
                    NULL,
                    NULL
                );

                -- ADDING MONK -----------------------------------------------------------------
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
                    7,
                    ""Monk"",
                    ""Monk Description"",
                    8,
                    ""str, dex"",
                    NULL,
                    NULL,
                    NULL,
                    NULL
                );

                -- ADDING PALADIN --------------------------------------------------------------
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
                    8,
                    ""Paladin"",
                    ""Paladin Description"",
                    10,
                    ""wis, cha"",
                    ""cha"",
                    ""<level> / 2 + <cha_mod>"",
                    ""restlong"",
                    NULL
                );

                -- ADDING RANGER ---------------------------------------------------------------
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
                    9,
                    ""Ranger"",
                    ""Ranger Description"",
                    10,
                    ""str, dex"",
                    ""wis"",
                    NULL,
                    NULL,
                    NULL
                );

                -- ADDING ROGUE ----------------------------------------------------------------
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
                    10,
                    ""Rogue"",
                    ""Rogue Description"",
                    8,
                    ""dex,int"",
                    NULL,
                    Null,
                    NULL,
                    NULL
                );

                -- ADDING SORCERER -------------------------------------------------------------
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
                    11,
                    ""Sorcerer"",
                    ""Sorcerer Description"",
                    6,
                    ""con,cha"",
                    ""cha"",
                    ""<level> / 2 + <cha_mod>"",
                    ""restlong"",
                    ""4,4,4,5,5,5,5,5,5,6,6,6,6,6,6,6,6,6,6,6""
                );

                -- ADDING WARLOCK --------------------------------------------------------------
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
                    12,
                    ""Warlock"",
                    ""Warlock Description"",
                    6,
                    ""wis,cha"",
                    ""cha"",
                    NULL,
                    ""restlong"",
                    ""2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4""
                );

                -- ADDING WIZARD ---------------------------------------------------------------
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
                    13,
                    ""Wizard"",
                    ""Wizard Description"",
                    6,
                    ""int,wis"",
                    ""int"",
                    ""<level> + <int_mod>"",
                    ""restlong"",
                    ""3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5""
                );
                ";
            createClassesCommand.ExecuteNonQuery();
        }

    }
}
