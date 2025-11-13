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
            pnlFlowRight = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnlFlowLeft
            // 
            pnlFlowLeft.BackColor = SystemColors.AppWorkspace;
            pnlFlowLeft.Location = new Point(3, 3);
            pnlFlowLeft.Name = "pnlFlowLeft";
            pnlFlowLeft.Size = new Size(295, 399);
            pnlFlowLeft.TabIndex = 0;
            // 
            // pnlFlowRight
            // 
            pnlFlowRight.BackColor = SystemColors.ControlDarkDark;
            pnlFlowRight.Location = new Point(343, 3);
            pnlFlowRight.Name = "pnlFlowRight";
            pnlFlowRight.Size = new Size(321, 399);
            pnlFlowRight.TabIndex = 1;
            // 
            // UCClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlFlowRight);
            Controls.Add(pnlFlowLeft);
            Name = "UCClass";
            Size = new Size(667, 405);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlFlowLeft;
        private FlowLayoutPanel pnlFlowRight;
    }
}
