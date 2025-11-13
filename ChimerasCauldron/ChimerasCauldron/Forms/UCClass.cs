using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChimerasCauldron.Forms
{
    public partial class UCClass : UserControl
    {
        public UCClass()
        {
            InitializeComponent();
            ConfigurePanels();

            this.Resize += SetResize;
        }

        private void ConfigurePanels()
        { 
            if(pnlFlowLeft.Parent != this)
            {
                var parent = pnlFlowLeft.Parent;
                parent.Controls.Remove(pnlFlowLeft);
                this.Controls.Add(pnlFlowLeft);
            }
            if (pnlFlowRight.Parent != this)
            {
                var parent = pnlFlowRight.Parent;
                parent.Controls.Remove(pnlFlowRight);
                this.Controls.Add(pnlFlowRight);
            }

            int margins = 10;
            Point startLoc = this.Location;
            pnlFlowLeft.Location = new Point(startLoc.X + margins, startLoc.Y + margins);
            pnlFlowRight.Location = new Point(this.Width / 2, margins);
        }

        private void SetResize(object sender, EventArgs e)
        {
            int leftWidthMin = 100;
            int leftWidthMax = 200;
        }
    }
}
