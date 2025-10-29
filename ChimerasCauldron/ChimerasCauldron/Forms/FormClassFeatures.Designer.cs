namespace ChimerasCauldron
{
    partial class FormClassFeatures
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
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            checkedListBox2 = new CheckedListBox();
            label3 = new Label();
            checkedListBox3 = new CheckedListBox();
            label4 = new Label();
            checkedListBox4 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(112, 42);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 0;
            label1.Text = " Weapon Mastery:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(122, 73);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(371, 42);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = " Language:";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(380, 73);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 114);
            checkedListBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(112, 226);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 4;
            label3.Text = " Skill Abilities:";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(122, 257);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(150, 114);
            checkedListBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(371, 226);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 6;
            label4.Text = " Skill Expertise:";
            // 
            // checkedListBox4
            // 
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Location = new Point(380, 257);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(150, 114);
            checkedListBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(631, 140);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(631, 226);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormClassFeatures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox4);
            Controls.Add(label4);
            Controls.Add(checkedListBox3);
            Controls.Add(label3);
            Controls.Add(checkedListBox2);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "FormClassFeatures";
            Text = "Class Features";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private CheckedListBox checkedListBox2;
        private Label label3;
        private CheckedListBox checkedListBox3;
        private Label label4;
        private CheckedListBox checkedListBox4;
        private Button button1;
        private Button button2;
    }
}