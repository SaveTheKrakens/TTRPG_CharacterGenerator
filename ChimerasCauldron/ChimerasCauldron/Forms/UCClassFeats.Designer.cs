namespace ChimerasCauldron.Forms
{
    partial class UCClassFeats
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
            checkedListBox4 = new CheckedListBox();
            label4 = new Label();
            checkedListBox3 = new CheckedListBox();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkedListBox4
            // 
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Location = new Point(38, 406);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(223, 136);
            checkedListBox4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(38, 375);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 14;
            label4.Text = " Skill Expertise:";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(38, 226);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(223, 136);
            checkedListBox3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(31, 195);
            label3.Name = "label3";
            label3.Size = new Size(157, 28);
            label3.TabIndex = 12;
            label3.Text = " Skill Proficiency:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(38, 46);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(223, 136);
            checkedListBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 8;
            label1.Text = " Weapon Mastery:";
            // 
            // UCClassFeats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBox4);
            Controls.Add(label4);
            Controls.Add(checkedListBox3);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "UCClassFeats";
            Size = new Size(346, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox4;
        private Label label4;
        private CheckedListBox checkedListBox3;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label1;
    }
}
