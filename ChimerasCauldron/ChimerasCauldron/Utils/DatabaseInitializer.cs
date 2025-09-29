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
            using SqliteConnection connection = new SqliteConnection("Data Source=chimeras.db");
            connection.Open();

            /*--CREATE RACES---------------------------------------------------------------------------------------------------------CREATE RACES--*/
            SqliteCommand createClassesCommand = connection.CreateCommand();
            createClassesCommand.CommandText =
                @"
                -- Drop table first
                DROP TABLE IF EXISTS PLAYER_CHARACTER;
                DROP TABLE IF EXISTS Races;
                DROP TABLE IF EXISTS Backgrounds;
                DROP TABLE IF EXISTS Ability_Scores;
                DROP TABLE IF EXISTS Items;
                DROP TABLE IF EXISTS Equipment;
                DROP TABLE IF EXISTS Magic_Items;
                DROP TABLE IF EXISTS Classes;

                -- Create PLAYER_CHARACTER TABLE
                CREATE TABLE IF NOT EXISTS PLAYER_CHARACTER (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    LEVEL INTEGER NOT NULL,
                    RACE_ID TEXT NOT NULL,
                    CLASS_ID TEXT NOT NULL,
                    BACKGROUND_ID TEXT NOT NULL,
                    ABILITY_SCORES_ID INTEGER,
                    ITEMS_ID INTEGER,
                    Foreign KEY (RACE_ID) REFERENCES Races(Race_Id),
                    FOREIGN KEY (CLASS_ID) REFERENCES Classes(Class_Id),
                    FOREIGN KEY (BACKGROUND_ID) REFERENCES Backgrounds(Background_Id),
                    FOREIGN KEY (ABILITY_SCORES_ID) REFERENCES Ability_Scores(Ability_Score_Id),
                    FOREIGN KEY (ITEMS_ID) REFERENCES Items(Item_Id)
                );

                -- Create Races TABLE
                CREATE TABLE IF NOT Exists Races (
                    Race_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Speed INTEGER NOT NULL,
                    Size TEXT NOT NULL,
                    Ability_Score_Increase TEXT NOT NULL,
                    Languages TEXT NOT NULL,
                    Darkvision BOOLEAN,
                    Unique_Traits TEXT
                );

                -- Create Background TABLE
                CREATE TABLE IF NOT EXISTS Backgrounds (
                    Background_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Ability_Score_Modifier TEXT NOT NULL,
                    Skill_Proficiencies TEXT NOT NULL,
                    Tool_Proficiencies TEXT,
                    Languages TEXT,
                    Equipment TEXT NOT NULL,
                    Feature TEXT NOT NULL
                );

                -- Create Ability_Scores TABLE
                CREATE TABLE IF NOT EXISTS Ability_Scores (
                    Ability_Score_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Strength INTEGER NOT NULL,
                    Dexterity INTEGER NOT NULL,
                    Constitution INTEGER NOT NULL,
                    Intelligence INTEGER NOT NULL,
                    Wisdom INTEGER NOT NULL,
                    Charisma INTEGER NOT NULL
                );

                -- Create Items TABLE
                CREATE TABLE IF NOT EXISTS Items (
                    Item_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Equipment_Id INTEGER,
                    Magic_Item_Id INTEGER,
                    FOREIGN KEY (Equipment_Id) REFERENCES Equipment(Equipment_Id),
                    FOREIGN KEY (Magic_Item_Id) REFERENCES Magic_Items(Magic_Item_Id)
                );

                -- Create Equipment TABLE
                CREATE TABLE IF NOT EXISTS Equipment (
                    Equipment_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Type TEXT NOT NULL,
                    Cost INTEGER NOT NULL,
                    Weight REAL NOT NULL,
                    Properties TEXT
                );

                -- Create Magic Items TABLE
                CREATE TABLE IF NOT EXISTS Magic_Items (
                    Magic_Item_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Rarity TEXT NOT NULL,
                    Requires_Attunement BOOLEAN NOT NULL
                );

                -- CREATE Classes TABLE
                CREATE TABLE IF NOT EXISTS Classes (
                    Class_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Hit_Dice INTEGER NOT NULL,
                    Proficiency TEXT NOT NULL,
                    Spellcasting_Ability TEXT,
                    Prepared_Spells TEXT,
                    Prepared_Spells_Change TEXT,
                    Cantrip_Progression TEXT,
                    Equipment TEXT
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
                    ""2,2,2,2,2,2,2,2,2,3,3,3,3,4,4,4,4,4,4,4"",
                    ""2 Simple Weapons, Light Crossbow, 20 Bolts, Studded Leather Armor or Scale Mail, Thieves' Tools, Dungeoneer's Pack, A Tinker's Tools""
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
                    NULL,
                    ""Greataxe, 4 Handaxes, Explorer's Pack, 15GP""
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
                    ""2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4"",
                    ""Leather Armor, 2 Daggers, Musical Instrument, Entertainer's Pack, 19GP""
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
                    ""3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5"",
                    ""Chain Shirt, Shield, Mace, Holy Symbol, Priest's Pack, 7GP""
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
                    ""2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4"",
                    ""Leather Armor, Shield, Sickle, Druidic Focus/Quarter Staff, Explorer's Pack, Herbalism Kit, 9GP""
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
                    NULL,
                    ""Chain Mail, Greatsword, Flail, 8 Javalins, Dungeoneer's Pack, 4GP or Studded Leather Armor, Scimitar, Shortsword, Longbow, 20 Arrows, Quiver, Dungeoneer's Pack, 11GP""
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
                    NULL,
                    ""Spear, 5 Daggers, Artisan’s Tools or Musical Instrument, Explorer’s Pack, and 11 GP""       
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
                    NULL,
                    ""Chain Mail, Shield, Longsword, 6 Javelins, Holy Symbol, Priest’s Pack, and 9 GP""
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
                    NULL,
                    ""Studded Leather Armor, Scimitar, Shortsword, Longbow, 20 Arrows, Quiver, Druidic Focus, Explorer’s Pack, and 7 GP""
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
                    NULL,
                    ""Leather Armor, 2 Daggers, Shortsword, Shortbow, 20 Arrows, Quiver, Thieves’ Tools, Burglar’s Pack, and 8 GP""
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
                    ""4,4,4,5,5,5,5,5,5,6,6,6,6,6,6,6,6,6,6,6"",
                    ""Spear, 2 Daggers, Arcane Focus, Dungeoneer’s Pack, and 28 GP""
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
                    ""2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4"",
                    ""Leather Armor, Sickle, 2 Daggers, Arcane Focus, Occult Object/Book, Scholar’s Pack, and 15 GP""
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
                    ""3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5"",
                    ""2 Daggers, Arcane Focus, Robe, Spellbook, Scholar’s Pack, and 5 GP""
                );
                ";
            createClassesCommand.ExecuteNonQuery();
        }

    }
}
