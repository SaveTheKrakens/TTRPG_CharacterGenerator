namespace ChimerasCauldron
{
    partial class FormTitlePage
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
            label2 = new Label();
            btnRandomGenerator = new Button();
            btnCreateYourOwn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(368, 57);
            label1.TabIndex = 0;
            label1.Text = "Welcome Player!   ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(14, 125);
            label2.Name = "label2";
            label2.Size = new Size(384, 46);
            label2.TabIndex = 1;
            label2.Text = "D&&D Character Creation";
            // 
            // btnRandomGenerator
            // 
            btnRandomGenerator.Font = new Font("Segoe UI", 10F);
            btnRandomGenerator.Location = new Point(14, 203);
            btnRandomGenerator.Name = "btnRandomGenerator";
            btnRandomGenerator.Size = new Size(167, 29);
            btnRandomGenerator.TabIndex = 2;
            btnRandomGenerator.Text = "Random Generator";
            btnRandomGenerator.UseVisualStyleBackColor = true;
            // 
            // btnCreateYourOwn
            // 
            btnCreateYourOwn.Font = new Font("Segoe UI", 10F);
            btnCreateYourOwn.Location = new Point(237, 203);
            btnCreateYourOwn.Name = "btnCreateYourOwn";
            btnCreateYourOwn.Size = new Size(152, 29);
            btnCreateYourOwn.TabIndex = 3;
            btnCreateYourOwn.Text = "Create Your Own";
            btnCreateYourOwn.UseVisualStyleBackColor = true;
            // 
            // FormTitlePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 310);
            Controls.Add(btnCreateYourOwn);
            Controls.Add(btnRandomGenerator);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTitlePage";
            Text = "Title Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRandomGenerator;
        private Button btnCreateYourOwn;
    }
}