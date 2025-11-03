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
    public partial class FrmStartPage : Form
    {
        // Add new modules as we make them
        string[] modules =
        {
            "Dungeons and Dragons 5e"
        };
        public FrmStartPage()
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
            if (cBoxModules.SelectedIndex == 0)
            {
                Form formCharacterCreation = new FormDndCharacterCreation();
                formCharacterCreation.ShowDialog();

            }
        }

        private void btnLoadCharacter_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
