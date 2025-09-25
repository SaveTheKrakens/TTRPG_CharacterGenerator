using Microsoft.Data.Sqlite;
using System.ComponentModel;

namespace ChimerasCauldron
{
    public partial class formDndCharacterCreation : Form
    {
        public formDndCharacterCreation()
        {
            InitializeComponent();

            /*--GET THE PANELS LAYOUT TO STAY IN THE CENTER------------------------------------------------------------------------------------------PANELS--*/
            ConfigurePanelWithMargin(pnlClassSelection, 80, 20);
            ConfigureCharacterPanelWithMargin();
            ConfigureButtons();
            LoadComponents();
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
        private void ConfigureCharacterPanelWithMargin()
        {
            // Set anchor on top right and bottom to stick it to the side of the panel
            pnl_CurrentCharacter.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

            // Set the initial location and margins
            int topBottomMargin = 20;
            int sideMargin = 180;
            int minWidth = 200;
            int maxWidth = 500;

            pnl_CurrentCharacter.Location = new Point(this.ClientSize.Width - minWidth - sideMargin, topBottomMargin);
            pnl_CurrentCharacter.Size = new Size(minWidth, this.ClientSize.Height - (4 * topBottomMargin));

            // Handle resizing to maintain margins
            this.Resize += (s, e) =>
            {
                int currentWidth = Math.Clamp(pnlClassSelection.Width / 5, minWidth, maxWidth);
                pnl_CurrentCharacter.Location = new Point(this.ClientSize.Width - currentWidth - sideMargin, topBottomMargin);
                pnl_CurrentCharacter.Size = new Size(currentWidth, this.ClientSize.Height - 4 * topBottomMargin);
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

        /*--SET UP COMPONENTS THAT USE SQLITE--------------------------------------------------------------------------------------------------------SQLITE--*/
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
        }

        /*--BUTTON CLICKS---------------------------------------------------------------------------------------------------------------------BUTTON CLICKS--*/
        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

        }
    }
}
