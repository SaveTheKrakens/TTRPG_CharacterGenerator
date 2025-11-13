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
            pnlContentCreation = new Panel();
            pnl_Content = new Panel();
            lblChoice = new Label();
            pnl_CurrentCharacter = new Panel();
            btn_Next = new Button();
            btn_Back = new Button();
            pnlContentCreation.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentCreation
            // 
            pnlContentCreation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContentCreation.BackColor = SystemColors.ActiveCaption;
            pnlContentCreation.Controls.Add(pnl_Content);
            pnlContentCreation.Controls.Add(lblChoice);
            pnlContentCreation.Controls.Add(pnl_CurrentCharacter);
            pnlContentCreation.Location = new Point(77, 12);
            pnlContentCreation.Name = "pnlContentCreation";
            pnlContentCreation.Size = new Size(822, 547);
            pnlContentCreation.TabIndex = 0;
            // 
            // pnl_Content
            // 
            pnl_Content.BackColor = SystemColors.Control;
            pnl_Content.Location = new Point(25, 68);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(533, 458);
            pnl_Content.TabIndex = 3;
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoice.Location = new Point(276, 0);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(218, 31);
            lblChoice.TabIndex = 2;
            lblChoice.Text = "Character Sheet";
            // 
            // pnl_CurrentCharacter
            // 
            pnl_CurrentCharacter.BackColor = SystemColors.Window;
            pnl_CurrentCharacter.Location = new Point(579, 68);
            pnl_CurrentCharacter.Name = "pnl_CurrentCharacter";
            pnl_CurrentCharacter.Size = new Size(166, 458);
            pnl_CurrentCharacter.TabIndex = 0;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(860, 260);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 23);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "button2";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(-34, 260);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 23);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "button2";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // FormDndCharacterCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(909, 571);
            Controls.Add(btn_Back);
            Controls.Add(btn_Next);
            Controls.Add(pnlContentCreation);
            Name = "FormDndCharacterCreation";
            Text = "Character Creation";
            FormClosed += ShowStartForm;
            Load += FormDndCharacterCreation_Load;
            pnlContentCreation.ResumeLayout(false);
            pnlContentCreation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContentCreation;
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
        private Panel pnl_Content;
    }
}
