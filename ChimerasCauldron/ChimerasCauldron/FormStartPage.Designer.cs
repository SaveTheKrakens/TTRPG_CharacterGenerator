namespace ChimerasCauldron
{
    partial class FrmStartPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewCharacter = new Button();
            btnLoadCharacter = new Button();
            btnExit = new Button();
            cBoxModules = new ComboBox();
            SuspendLayout();
            // 
            // btnNewCharacter
            // 
            btnNewCharacter.Location = new Point(167, 206);
            btnNewCharacter.Name = "btnNewCharacter";
            btnNewCharacter.Size = new Size(120, 23);
            btnNewCharacter.TabIndex = 0;
            btnNewCharacter.Text = "NewCharacter";
            btnNewCharacter.UseVisualStyleBackColor = true;
            btnNewCharacter.Click += btnNewCharacter_Click;
            // 
            // btnLoadCharacter
            // 
            btnLoadCharacter.Location = new Point(103, 235);
            btnLoadCharacter.Name = "btnLoadCharacter";
            btnLoadCharacter.Size = new Size(120, 23);
            btnLoadCharacter.TabIndex = 1;
            btnLoadCharacter.Text = "Load Character";
            btnLoadCharacter.UseVisualStyleBackColor = true;
            btnLoadCharacter.Click += btnLoadCharacter_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(103, 264);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cBoxModules
            // 
            cBoxModules.FormattingEnabled = true;
            cBoxModules.Location = new Point(40, 206);
            cBoxModules.Name = "cBoxModules";
            cBoxModules.Size = new Size(121, 23);
            cBoxModules.TabIndex = 3;
            // 
            // frmStartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 402);
            Controls.Add(cBoxModules);
            Controls.Add(btnExit);
            Controls.Add(btnLoadCharacter);
            Controls.Add(btnNewCharacter);
            Name = "frmStartPage";
            Text = "Chimeras Cauldron";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewCharacter;
        private Button btnLoadCharacter;
        private Button btnExit;
        private ComboBox cBoxModules;
    }
}