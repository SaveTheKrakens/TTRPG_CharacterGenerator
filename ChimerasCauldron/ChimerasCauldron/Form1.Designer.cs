namespace ChimerasCauldron
{
    partial class Form_CharacterCreation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlRaceSelection = new Panel();
            SuspendLayout();
            // 
            // pnlRaceSelection
            // 
            pnlRaceSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRaceSelection.BackColor = SystemColors.ActiveCaption;
            pnlRaceSelection.Location = new Point(60, 12);
            pnlRaceSelection.Name = "pnlRaceSelection";
            pnlRaceSelection.Size = new Size(804, 547);
            pnlRaceSelection.TabIndex = 0;
            // 
            // Form_CharacterCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(926, 571);
            Controls.Add(pnlRaceSelection);
            Name = "Form_CharacterCreation";
            Text = "Character Creation";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRaceSelection;
    }
}
