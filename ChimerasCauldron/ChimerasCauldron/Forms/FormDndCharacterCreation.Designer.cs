namespace ChimerasCauldron
{
    partial class FormDndCharacterCreation
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
            pnlClassSelection = new Panel();
            lblChoice = new Label();
            pnl_CurrentCharacter = new Panel();
            btn_Next = new Button();
            btn_Back = new Button();
            pnlClassSelection.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClassSelection
            // 
            pnlClassSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlClassSelection.BackColor = SystemColors.ActiveCaption;
            pnlClassSelection.Controls.Add(lblChoice);
            pnlClassSelection.Controls.Add(pnl_CurrentCharacter);
            pnlClassSelection.Location = new Point(88, 16);
            pnlClassSelection.Margin = new Padding(3, 4, 3, 4);
            pnlClassSelection.Name = "pnlClassSelection";
            pnlClassSelection.Size = new Size(939, 729);
            pnlClassSelection.TabIndex = 0;
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoice.Location = new Point(316, 0);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(271, 39);
            lblChoice.TabIndex = 2;
            lblChoice.Text = "Character Sheet";
            // 
            // pnl_CurrentCharacter
            // 
            pnl_CurrentCharacter.BackColor = SystemColors.Window;
            pnl_CurrentCharacter.Location = new Point(89, 91);
            pnl_CurrentCharacter.Margin = new Padding(3, 4, 3, 4);
            pnl_CurrentCharacter.Name = "pnl_CurrentCharacter";
            pnl_CurrentCharacter.Size = new Size(762, 611);
            pnl_CurrentCharacter.TabIndex = 0;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(983, 347);
            btn_Next.Margin = new Padding(3, 4, 3, 4);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(86, 31);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "button2";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(-39, 347);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(86, 31);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "button2";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // FormDndCharacterCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1039, 761);
            Controls.Add(btn_Back);
            Controls.Add(btn_Next);
            Controls.Add(pnlClassSelection);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDndCharacterCreation";
            Text = "Character Creation";
            FormClosed += ShowStartForm;
            Load += FormDndCharacterCreation_Load;
            pnlClassSelection.ResumeLayout(false);
            pnlClassSelection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClassSelection;
        private Panel pnl_CurrentCharacter;
        private Label lblChoice;
        private ComboBox cboxRaceSelection;
        private Label lblChooseRace;
        private ComboBox cboxBackgroundSelection;
        private Label label1;
        private Button btn_Next;
        private Label lblCharacterName;
        private TextBox txtCharacterName;
        
        private Button btn_Back;
    }
}
