namespace ChimerasCauldron
{
    partial class formDndCharacterCreation
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
            lblChooseClass = new Label();
            cboxClassSelection = new ComboBox();
            pnl_CurrentCharacter = new Panel();
            btn_Back = new Button();
            btn_Next = new Button();
            pnlClassSelection.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClassSelection
            // 
            pnlClassSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlClassSelection.BackColor = SystemColors.ActiveCaption;
            pnlClassSelection.Controls.Add(lblChooseClass);
            pnlClassSelection.Controls.Add(cboxClassSelection);
            pnlClassSelection.Controls.Add(pnl_CurrentCharacter);
            pnlClassSelection.Location = new Point(77, 12);
            pnlClassSelection.Name = "pnlClassSelection";
            pnlClassSelection.Size = new Size(768, 547);
            pnlClassSelection.TabIndex = 0;
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
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Left;
            btn_Back.Location = new Point(33, 250);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 23);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "button1";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(877, 260);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 23);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "button2";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // formDndCharacterCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(926, 571);
            Controls.Add(btn_Next);
            Controls.Add(btn_Back);
            Controls.Add(pnlClassSelection);
            Name = "formDndCharacterCreation";
            Text = "Character Creation";
            pnlClassSelection.ResumeLayout(false);
            pnlClassSelection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClassSelection;
        private Panel pnl_CurrentCharacter;
        private Button btn_Back;
        private Button btn_Next;
        private Label lblChooseClass;
        private ComboBox cboxClassSelection;
    }
}
