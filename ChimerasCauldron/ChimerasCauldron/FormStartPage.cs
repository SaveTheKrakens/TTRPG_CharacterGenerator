using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChimerasCauldron
{
    public partial class frmStartPage : Form
    {
        // Add new modules as we make them
        string[] modules =
        {
            "Dungeons and Dragons 5e"
        };
        public frmStartPage()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cBoxModules.Items.AddRange(modules);
            cBoxModules.SelectedIndex = 0;
        }

        private void btnNewCharacter_Click(object sender, EventArgs e)
        {
            if(cBoxModules.SelectedIndex == 0)
            {
                Form formCharacterCreation = new formDndCharacterCreation();
                formCharacterCreation.Show();
                this.Hide();
            }
        }

        private void btnLoadCharacter_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
