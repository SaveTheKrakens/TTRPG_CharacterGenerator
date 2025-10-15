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
            label1 = new Label();
            cboxBackgroundSelection = new ComboBox();
            cboxRaceSelection = new ComboBox();
            lblChooseRace = new Label();
            lblChooseClass = new Label();
            cboxClassSelection = new ComboBox();
            pnl_CurrentCharacter = new Panel();
            btn_Next = new Button();
            btn_Back = new Button();
            txtCharacterName = new TextBox();
            lblCharacterName = new Label();
            pnlClassSelection.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClassSelection
            // 
            pnlClassSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlClassSelection.BackColor = SystemColors.ActiveCaption;
            pnlClassSelection.Controls.Add(lblCharacterName);
            pnlClassSelection.Controls.Add(txtCharacterName);
            pnlClassSelection.Controls.Add(label1);
            pnlClassSelection.Controls.Add(cboxBackgroundSelection);
            pnlClassSelection.Controls.Add(cboxRaceSelection);
            pnlClassSelection.Controls.Add(lblChooseRace);
            pnlClassSelection.Controls.Add(lblChooseClass);
            pnlClassSelection.Controls.Add(cboxClassSelection);
            pnlClassSelection.Controls.Add(pnl_CurrentCharacter);
            pnlClassSelection.Location = new Point(77, 12);
            pnlClassSelection.Name = "pnlClassSelection";
            pnlClassSelection.Size = new Size(751, 547);
            pnlClassSelection.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 8;
            label1.Text = "Choose Background";
            // 
            // cboxBackgroundSelection
            // 
            cboxBackgroundSelection.FormattingEnabled = true;
            cboxBackgroundSelection.Location = new Point(448, 36);
            cboxBackgroundSelection.Name = "cboxBackgroundSelection";
            cboxBackgroundSelection.Size = new Size(121, 23);
            cboxBackgroundSelection.TabIndex = 7;
            // 
            // cboxRaceSelection
            // 
            cboxRaceSelection.FormattingEnabled = true;
            cboxRaceSelection.Location = new Point(222, 36);
            cboxRaceSelection.Name = "cboxRaceSelection";
            cboxRaceSelection.Size = new Size(121, 23);
            cboxRaceSelection.TabIndex = 6;
            // 
            // lblChooseRace
            // 
            lblChooseRace.AutoSize = true;
            lblChooseRace.Location = new Point(222, 18);
            lblChooseRace.Name = "lblChooseRace";
            lblChooseRace.Size = new Size(75, 15);
            lblChooseRace.TabIndex = 5;
            lblChooseRace.Text = "Choose Race";
            // 
            // lblChooseClass
            // 
            lblChooseClass.AutoSize = true;
            lblChooseClass.Location = new Point(3, 17);
            lblChooseClass.Name = "lblChooseClass";
            lblChooseClass.Size = new Size(77, 15);
            lblChooseClass.TabIndex = 2;
            lblChooseClass.Text = "Choose Class";
            // 
            // cboxClassSelection
            // 
            cboxClassSelection.FormattingEnabled = true;
            cboxClassSelection.Location = new Point(3, 35);
            cboxClassSelection.Name = "cboxClassSelection";
            cboxClassSelection.Size = new Size(121, 23);
            cboxClassSelection.TabIndex = 1;
            // 
            // pnl_CurrentCharacter
            // 
            pnl_CurrentCharacter.BackColor = SystemColors.Window;
            pnl_CurrentCharacter.Location = new Point(575, 17);
            pnl_CurrentCharacter.Name = "pnl_CurrentCharacter";
            pnl_CurrentCharacter.Size = new Size(170, 509);
            pnl_CurrentCharacter.TabIndex = 0;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(792, 260);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 23);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "&Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Left;
            btn_Back.Location = new Point(33, 250);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 23);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "&Back";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(3, 113);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(206, 23);
            txtCharacterName.TabIndex = 9;
            // 
            // lblCharacterName
            // 
            lblCharacterName.AutoSize = true;
            lblCharacterName.Location = new Point(3, 95);
            lblCharacterName.Name = "lblCharacterName";
            lblCharacterName.Size = new Size(93, 15);
            lblCharacterName.TabIndex = 10;
            lblCharacterName.Text = "Character Name";
            // 
            // FormDndCharacterCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(909, 571);
            Controls.Add(btn_Next);
            Controls.Add(btn_Back);
            Controls.Add(pnlClassSelection);
            Name = "FormDndCharacterCreation";
            Text = "Character Creation";
            FormClosed += ShowStartForm;
            pnlClassSelection.ResumeLayout(false);
            pnlClassSelection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClassSelection;
        private Panel pnl_CurrentCharacter;
        private Label lblChooseClass;
        private ComboBox cboxClassSelection;
        private ComboBox cboxRaceSelection;
        private Label lblChooseRace;
        private ComboBox cboxBackgroundSelection;
        private Label label1;
        private Button btn_Next;
        private Button btn_Back;
        private Label lblCharacterName;
        private TextBox txtCharacterName;
    }
}
