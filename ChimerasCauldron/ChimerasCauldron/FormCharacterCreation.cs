namespace ChimerasCauldron
{
    public partial class Form_CharacterCreation : Form
    {
        public Form_CharacterCreation()
        {
            InitializeComponent();

            /*--GET THE PANELS LAYOUT TO STAY IN THE CENTER------------------------------------------------------------------------------------------PANELS--*/
            ConfigurePanelWithMargin(pnlRaceSelection, 80, 20);
            ConfigureCharacterPanelWithMargin();
            ConfigureButtons();
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
        }
    }
}
