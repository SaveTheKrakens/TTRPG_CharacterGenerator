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
            pnlFlowRight.Location = new Point(startLoc.X + pnlFlowLeft.Size.Width + margins*2, margins);

            pnlFlowLeft.Size = new Size(Math.Clamp((this.Size.Width / 2) - (margins * 2), 100, 200), this.Size.Height - margins * 2);
            pnlFlowRight.Size = new Size(this.Size.Width - pnlFlowLeft.Size.Width - (margins * 3), this.Size.Height - margins * 2);

            lblClassSelection.Location = new Point(pnlFlowLeft.Location.X + margins, pnlFlowLeft.Location.Y + margins);
            lblClassDescription.Location = new Point(pnlFlowRight.Location.X + margins, pnlFlowRight.Location.Y + margins);
        }

        private void SetResize(object sender, EventArgs e)
        {
            int margins = 10;
            Point startLoc = this.Location;
            pnlFlowLeft.Location = new Point(startLoc.X + margins, startLoc.Y + margins);
            pnlFlowRight.Location = new Point(startLoc.X + pnlFlowLeft.Size.Width + margins*2, margins);

            pnlFlowLeft.Size = new Size(Math.Clamp((this.Size.Width / 2) - (margins * 2), 100, 200), this.Size.Height - margins * 2);
            pnlFlowRight.Size = new Size(this.Size.Width - pnlFlowLeft.Size.Width - (margins * 3), this.Size.Height - margins * 2);
        }
    }
}
