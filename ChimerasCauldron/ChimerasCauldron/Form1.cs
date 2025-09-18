namespace ChimerasCauldron
{
    public partial class Form_CharacterCreation : Form
    {
        public Form_CharacterCreation()
        {
            InitializeComponent();

            /*--GET THE PANELS LAYOUT TO STAY IN THE CENTER----------------------------------------------------------------------------------------------------PANELS--*/
            ConfigurePanelWithMargin(pnlRaceSelection, 80, 20);

        }

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
    }
}
