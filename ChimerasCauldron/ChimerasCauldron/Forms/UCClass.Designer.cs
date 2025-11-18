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
            pnlFlowLeft.Location = new Point(3, 4);
            pnlFlowLeft.Margin = new Padding(3, 4, 3, 4);
            pnlFlowLeft.Name = "pnlFlowLeft";
            pnlFlowLeft.Size = new Size(220, 532);
            pnlFlowLeft.TabIndex = 0;
            // 
            // pnlFlowRight
            // 
            pnlFlowRight.BackColor = SystemColors.ControlDarkDark;
            pnlFlowRight.Location = new Point(246, 4);
            pnlFlowRight.Margin = new Padding(3, 4, 3, 4);
            pnlFlowRight.Name = "pnlFlowRight";
            pnlFlowRight.Size = new Size(308, 532);
            pnlFlowRight.TabIndex = 1;
            // 
            // UCClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlFlowRight);
            Controls.Add(pnlFlowLeft);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCClass";
            Size = new Size(593, 540);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlFlowLeft;
        private FlowLayoutPanel pnlFlowRight;
    }
}
