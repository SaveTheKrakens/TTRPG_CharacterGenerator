using ChimerasCauldron.Core.DND;
using ChimerasCauldron.Forms;
using Microsoft.Data.Sqlite;
using System.ComponentModel;

namespace ChimerasCauldron
{
    public partial class FormDndCharacterCreation : Form
    {

        /*--CLASS LEVEL VARIABLES-----------------------------------------------------------------------------------------------------------------VARIABLES--*/
        DndCharacter newCharacter;

        public FormDndCharacterCreation()
        {
            InitializeComponent();

            /*--GET THE PANELS LAYOUT TO STAY IN THE CENTER------------------------------------------------------------------------------------------PANELS--*/
            ConfigurePanelWithMargin(pnlContentCreation, 80, 20);
            ConfigureContentCharacterPanelWithMargin();
            ConfigureButtons();
            //LoadComponents();
            UserControl ucBackground = new UCBackground();
            pnlClassSelection.Controls.Add(ucBackground);

            /*--CREATE A NEW PLAYER CHARACTER--------------------------------------------------------------------------------------------------------PLAYER--*/
            newCharacter = new DndCharacter();
        }

        /*--LOAD DATA AFTER THE FORM CONSTRUCTOR--------------------------------------------------------------------------------------------------FORM LOAD--*/
        private void FormDndCharacterCreation_Load(object sender, EventArgs e)
        {

        }

        /*--HELPER FUNCTIONS-------------------------------------------------------------------------------------------------------------------------HELPER FUNCTIONS--*/
        /*--GET THE PANELS LAYOUT TO STAY IN THE CENTER-----------------------------------------------------------------------------------------MAIN-PANELS--*/
        private void ConfigurePanelWithMargin(Panel panel, int sideMargin, int topBottomMargin)
        {
            // Set anchor on all sides so that the panel resizes on all sides
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Set initial location and size with margins
            panel.Location = new Point(sideMargin, topBottomMargin);
            panel.Size = new Size(
                this.ClientSize.Width - 2 * sideMargin,
                this.ClientSize.Height - 2 * topBottomMargin);

            // Handle resizing to maintain margins
            this.Resize += (s, e) =>
            {
                panel.Size = new Size(
                    this.ClientSize.Width - 2 * sideMargin,
                    this.ClientSize.Height - 2 * topBottomMargin);
            };
        }

        /*--GET THE CHARACTER PANEL TO STAY TO THE RIGHT THROUGHOUT CREATION----------------------------------------------------------------CHARACTER PANEL--*/
        private void ConfigureContentCharacterPanelWithMargin()
        {
            //Make sure the panels have the correct parent
            if(pnl_CurrentCharacter.Parent != pnlContentCreation)
            {
                if(pnl_CurrentCharacter.Parent == null)
                {
                    pnlContentCreation.Controls.Add(pnl_CurrentCharacter);
                }
                else
                {
                    var parent = pnl_CurrentCharacter.Parent;
                    parent.Controls.Remove(pnl_CurrentCharacter);
                    pnlContentCreation.Controls.Add(pnl_CurrentCharacter);
                }
            }
            //Make sure the panels have the correct parent
            if (pnl_Content.Parent != pnlContentCreation)
            {
                if (pnl_Content.Parent == null)
                {
                    pnlContentCreation.Controls.Add(pnl_Content);
                }
                else
                {
                    var parent = pnl_Content.Parent;
                    parent.Controls.Remove(pnl_Content);
                    pnlContentCreation.Controls.Add(pnl_Content);
                }
            }

            // Set anchor on top right and bottom to stick it to the side of the panel
            pnl_CurrentCharacter.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            pnl_Content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            // Set the initial location and margins
            int topBottomMargin = 20;
            int sideMargin = 20;

            // Size for the character panel, leftovers for content selection panel
            int minWidthCharacter = 200;
            int maxWidthCharacter = 500;

            pnl_CurrentCharacter.Location = new Point(pnl_CurrentCharacter.Parent.Width - minWidthCharacter - sideMargin, topBottomMargin * 2);
            pnl_CurrentCharacter.Size = new Size(minWidthCharacter, pnl_CurrentCharacter.Parent.Height - (3 * topBottomMargin));

            pnl_Content.Location = new Point(sideMargin, topBottomMargin * 2);
            pnl_Content.Size = new Size(pnl_Content.Parent.Width - pnl_CurrentCharacter.Width - (sideMargin*3), pnl_Content.Parent.Height - (3 * topBottomMargin));

            // Handle resizing to maintain margins
            this.Resize += (s, e) =>
            {
                int currentWidth = Math.Clamp(pnlContentCreation.Width / 5, minWidthCharacter, maxWidthCharacter);
                pnl_CurrentCharacter.Location = new Point(pnl_CurrentCharacter.Parent.Width - minWidthCharacter - sideMargin, topBottomMargin * 2);
                pnl_CurrentCharacter.Size = new Size(minWidthCharacter, pnl_CurrentCharacter.Parent.Height - (3 * topBottomMargin));
                pnl_Content.Location = new Point(sideMargin, topBottomMargin * 2);
                pnl_Content.Size = new Size(pnl_Content.Parent.Width - pnl_CurrentCharacter.Width - (sideMargin * 3), pnl_Content.Parent.Height - (3 * topBottomMargin));
            };
        }

        /*--SET UP THE BACK AND NEXT BUTTONS----------------------------------------------------------------------------------------------BACK NEXT BUTTONS--*/
        private void ConfigureButtons()
        {
            // Button sizes
            int btnHeight = 100;
            int btnWidth = 70;
            int vCenter = (this.ClientSize.Height - btnHeight) / 2;

            // Anchor buttons so that they stay on the sides
            btn_Back.Anchor = AnchorStyles.Left;
            btn_Next.Anchor = AnchorStyles.Right;

            // Set button sizes and initial positions
            btn_Back.Size = new Size(btnWidth, btnHeight);
            btn_Next.Size = new Size(btnWidth, btnHeight);
            btn_Back.Location = new Point(5, vCenter);
            btn_Next.Location = new Point(this.ClientSize.Width - btnWidth - 5, vCenter);

            // Placeholder button text 
            btn_Back.Text = "<<<";
            btn_Next.Text = ">>>";
        }

        /*--SET UP COMPONENTS THAT USE SQLITE--------------------------------------------------------------------------------------------------------SQLITE--
        private void LoadComponents()
        {
            cboxClassSelection.Text = "Choose Class";

            using SqliteConnection connection = new SqliteConnection("Data Source=chimeras.db");
            connection.Open();

            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM Classes";

            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cboxClassSelection.Items.Add(reader.GetString(0));
            }
        }*/

        /*--BUTTON CLICKS---------------------------------------------------------------------------------------------------------------------BUTTON CLICKS--*/
        private void ShowStartForm(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            
        }
    }
}
