namespace ChimerasCauldron.Forms
{
    partial class UCRaceSpecies
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
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            label2 = new Label();
            checkedListBox2 = new CheckedListBox();
            label1 = new Label();
            checkedListBox3 = new CheckedListBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(132, 25);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(181, 114);
            checkedListBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 156);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 8;
            label3.Text = "Subrace:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(69, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 7;
            label2.Text = "Race:";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(132, 156);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(181, 114);
            checkedListBox2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 289);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 11;
            label1.Text = "Languages:";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(132, 289);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(181, 114);
            checkedListBox3.TabIndex = 13;
            // 
            // UCRaceSpecies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBox3);
            Controls.Add(checkedListBox2);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCRaceSpecies";
            Size = new Size(383, 459);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Label label3;
        private Label label2;
        private CheckedListBox checkedListBox2;
        private Label label1;
        private CheckedListBox checkedListBox3;
    }
}
