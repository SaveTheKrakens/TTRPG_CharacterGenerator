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
            button2 = new Button();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(357, 192);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(211, 192);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 11;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(487, 20);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(132, 76);
            checkedListBox1.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(163, 20);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 79);
            listBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(307, 20);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 8;
            label3.Text = "Choose Your Subrace:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 7;
            label2.Text = "Choose Your Race:";
            // 
            // UCRaceSpecies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "UCRaceSpecies";
            Size = new Size(741, 468);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
    }
}
