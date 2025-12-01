namespace ChimerasCauldron.Forms
{
    partial class UCClass
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFlowLeft = new FlowLayoutPanel();
            lblClassSelection = new Label();
            pnlFlowRight = new FlowLayoutPanel();
            lblClassDescription = new Label();
            cboxClasses = new ComboBox();
            tboxDescription = new TextBox();
            pnlFlowLeft.SuspendLayout();
            pnlFlowRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFlowLeft
            // 
            pnlFlowLeft.BackColor = SystemColors.AppWorkspace;
            pnlFlowLeft.Controls.Add(lblClassSelection);
            pnlFlowLeft.Controls.Add(cboxClasses);
            pnlFlowLeft.FlowDirection = FlowDirection.TopDown;
            pnlFlowLeft.Location = new Point(3, 3);
            pnlFlowLeft.Name = "pnlFlowLeft";
            pnlFlowLeft.Size = new Size(192, 399);
            pnlFlowLeft.TabIndex = 0;
            // 
            // lblClassSelection
            // 
            lblClassSelection.AutoSize = true;
            lblClassSelection.Location = new Point(3, 0);
            lblClassSelection.Name = "lblClassSelection";
            lblClassSelection.Size = new Size(47, 15);
            lblClassSelection.TabIndex = 0;
            lblClassSelection.Text = "lblClass";
            // 
            // pnlFlowRight
            // 
            pnlFlowRight.BackColor = SystemColors.ControlDarkDark;
            pnlFlowRight.Controls.Add(lblClassDescription);
            pnlFlowRight.Controls.Add(tboxDescription);
            pnlFlowRight.FlowDirection = FlowDirection.TopDown;
            pnlFlowRight.Location = new Point(215, 3);
            pnlFlowRight.Name = "pnlFlowRight";
            pnlFlowRight.Size = new Size(270, 399);
            pnlFlowRight.TabIndex = 1;
            // 
            // lblClassDescription
            // 
            lblClassDescription.AutoSize = true;
            lblClassDescription.Location = new Point(3, 0);
            lblClassDescription.Name = "lblClassDescription";
            lblClassDescription.Size = new Size(80, 15);
            lblClassDescription.TabIndex = 0;
            lblClassDescription.Text = "lblDescription";
            // 
            // cboxClasses
            // 
            cboxClasses.FormattingEnabled = true;
            cboxClasses.Location = new Point(3, 18);
            cboxClasses.Name = "cboxClasses";
            cboxClasses.Size = new Size(121, 23);
            cboxClasses.TabIndex = 1;
            // 
            // tboxDescription
            // 
            tboxDescription.Dock = DockStyle.Fill;
            tboxDescription.Location = new Point(3, 18);
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(80, 23);
            tboxDescription.TabIndex = 1;
            // 
            // UCClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlFlowRight);
            Controls.Add(pnlFlowLeft);
            Name = "UCClass";
            Size = new Size(519, 405);
            pnlFlowLeft.ResumeLayout(false);
            pnlFlowLeft.PerformLayout();
            pnlFlowRight.ResumeLayout(false);
            pnlFlowRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlFlowLeft;
        private FlowLayoutPanel pnlFlowRight;
        private Label lblClassSelection;
        private Label lblClassDescription;
        private ComboBox cboxClasses;
        private TextBox tboxDescription;
    }
}
