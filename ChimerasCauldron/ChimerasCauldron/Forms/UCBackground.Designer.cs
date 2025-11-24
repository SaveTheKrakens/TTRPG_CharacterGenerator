namespace ChimerasCauldron.Forms
{
    partial class UCBackground
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
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            richTextBox3 = new RichTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(199, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(228, 121);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 93);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 10;
            label3.Text = "Skill Proficiency:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 54);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 9;
            label2.Text = "Background Base:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 8;
            label1.Text = "Background Name:";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(200, 351);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(228, 121);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(19, 347);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 14;
            label4.Text = "Description:";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(200, 224);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(228, 121);
            richTextBox3.TabIndex = 17;
            richTextBox3.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 220);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 16;
            label5.Text = "Tools Proficiency:";
            // 
            // UCBackground
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(richTextBox3);
            Controls.Add(label5);
            Controls.Add(richTextBox2);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCBackground";
            Size = new Size(463, 511);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox2;
        private Label label4;
        private RichTextBox richTextBox3;
        private Label label5;
    }
}
