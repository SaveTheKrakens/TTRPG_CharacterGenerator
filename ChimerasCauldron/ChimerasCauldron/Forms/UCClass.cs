using Microsoft.Data.Sqlite;
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
        private struct DndClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        private List<DndClass> dndClasses = new();

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

            lblClassSelection.Text = "Class Selection";
            lblClassDescription.Text = "Class Description";

            // Placed at the end of configuration just in case
            LoadData();
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

        private void LoadData()
        {
            try
            {
                // Start the connection
                using var connection = new SqliteConnection("Data Source=chimeras.db");
                connection.Open();

                // Give the query
                using var command = connection.CreateCommand();
                command.CommandText = "SELECT Class_Id, Name, Description FROM Classes ORDER BY Name";

                // Loop through the results of the query
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.IsDBNull(0) ? -1 : reader.GetInt32(0);
                    var name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    var description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                    dndClasses.Add(new DndClass { Id = id, Name = name, Description = description });
                }

                // Add to combobox
                cboxClasses.DataSource = null;
                cboxClasses.DataSource = dndClasses;
                cboxClasses.DisplayMember = nameof(DndClass.Name);
                cboxClasses.ValueMember = nameof(DndClass.Id);

                // Set up first item and description only if we have items
                if (dndClasses.Count > 0)
                {
                    cboxClasses.SelectedIndex = 0;
                    tboxDescription.Text = dndClasses[0].Description;
                }
                else
                {
                    tboxDescription.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Something happened {ex.StackTrace}", "uh oh");
            }
        }
    }
}
