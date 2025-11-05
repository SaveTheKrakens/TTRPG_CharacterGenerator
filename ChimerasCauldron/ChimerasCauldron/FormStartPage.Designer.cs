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
            btnRandomGenerator = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            cBoxModules = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNewCharacter
            // 
            btnNewCharacter.Location = new Point(214, 152);
            btnNewCharacter.Margin = new Padding(3, 4, 3, 4);
            btnNewCharacter.Name = "btnNewCharacter";
            btnNewCharacter.Size = new Size(137, 40);
            btnNewCharacter.TabIndex = 0;
            btnNewCharacter.Text = "New Character";
            btnNewCharacter.UseVisualStyleBackColor = true;
            btnNewCharacter.Click += btnNewCharacter_Click;
            // 
            // btnLoadCharacter
            // 
            btnLoadCharacter.Location = new Point(214, 200);
            btnLoadCharacter.Margin = new Padding(3, 4, 3, 4);
            btnLoadCharacter.Name = "btnLoadCharacter";
            btnLoadCharacter.Size = new Size(137, 40);
            btnLoadCharacter.TabIndex = 1;
            btnLoadCharacter.Text = "Load Character";
            btnLoadCharacter.UseVisualStyleBackColor = true;
            btnLoadCharacter.Click += btnLoadCharacter_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(214, 293);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRandomGenerator
            // 
            btnRandomGenerator.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRandomGenerator.Location = new Point(214, 247);
            btnRandomGenerator.Name = "btnRandomGenerator";
            btnRandomGenerator.Size = new Size(137, 40);
            btnRandomGenerator.TabIndex = 6;
            btnRandomGenerator.Text = "Random Generator";
            btnRandomGenerator.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Italic);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 43);
            label1.TabIndex = 8;
            label1.Text = "DND";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Italic);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(35, 56);
            label2.Name = "label2";
            label2.Size = new Size(214, 43);
            label2.TabIndex = 9;
            label2.Text = "Character";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Italic);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(96, 100);
            label3.Name = "label3";
            label3.Size = new Size(171, 43);
            label3.TabIndex = 10;
            label3.Text = "Creator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kitsune_bit_art_shaded1;
            pictureBox1.Location = new Point(277, 56);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 94);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cBoxModules
            // 
            cBoxModules.FormattingEnabled = true;
            cBoxModules.Location = new Point(14, 159);
            cBoxModules.Margin = new Padding(3, 4, 3, 4);
            cBoxModules.Name = "cBoxModules";
            cBoxModules.Size = new Size(193, 28);
            cBoxModules.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(14, 196);
            label4.Name = "label4";
            label4.Size = new Size(207, 37);
            label4.TabIndex = 13;
            label4.Text = "Created by:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 11.25F);
            label5.Location = new Point(15, 247);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 14;
            label5.Text = "Spencer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 11.25F);
            label6.Location = new Point(114, 291);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 15;
            label6.Text = "Gabe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 11.25F);
            label7.Location = new Point(18, 292);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 16;
            label7.Text = "Jared";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 11.25F);
            label8.Location = new Point(66, 269);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 17;
            label8.Text = "Ember";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MV Boli", 11.25F);
            label9.Location = new Point(119, 247);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 18;
            label9.Text = "Alex";
            // 
            // FrmStartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 367);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cBoxModules);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRandomGenerator);
            Controls.Add(btnExit);
            Controls.Add(btnLoadCharacter);
            Controls.Add(btnNewCharacter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmStartPage";
            Text = "Chimeras Cauldron";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewCharacter;
        private Button btnLoadCharacter;
        private Button btnExit;
        private Button btnRandomGenerator;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private ComboBox cBoxModules;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}