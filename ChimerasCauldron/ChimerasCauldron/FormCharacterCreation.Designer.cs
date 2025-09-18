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
            pnl_CurrentCharacter = new Panel();
            btn_Back = new Button();
            btn_Next = new Button();
            pnlRaceSelection.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRaceSelection
            // 
            pnlRaceSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRaceSelection.BackColor = SystemColors.ActiveCaption;
            pnlRaceSelection.Controls.Add(pnl_CurrentCharacter);
            pnlRaceSelection.Location = new Point(77, 12);
            pnlRaceSelection.Name = "pnlRaceSelection";
            pnlRaceSelection.Size = new Size(768, 547);
            pnlRaceSelection.TabIndex = 0;
            // 
            // pnl_CurrentCharacter
            // 
            pnl_CurrentCharacter.BackColor = SystemColors.Window;
            pnl_CurrentCharacter.Location = new Point(575, 17);
            pnl_CurrentCharacter.Name = "pnl_CurrentCharacter";
            pnl_CurrentCharacter.Size = new Size(170, 509);
            pnl_CurrentCharacter.TabIndex = 0;
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Left;
            btn_Back.Location = new Point(33, 250);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 23);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "button1";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(877, 260);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 23);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "button2";
            btn_Next.UseVisualStyleBackColor = true;
            // 
            // Form_CharacterCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(926, 571);
            Controls.Add(btn_Next);
            Controls.Add(btn_Back);
            Controls.Add(pnlRaceSelection);
            Name = "Form_CharacterCreation";
            Text = "Character Creation";
            pnlRaceSelection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRaceSelection;
        private Panel pnl_CurrentCharacter;
        private Button btn_Back;
        private Button btn_Next;
    }
}
