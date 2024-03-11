namespace Poznamky
{
    partial class PoznamkaView
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
            label1 = new Label();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 73);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 0;
            label1.Text = "(Nadpis Poznámky)";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 135);
            label2.Name = "label2";
            label2.Size = new Size(511, 200);
            label2.TabIndex = 1;
            label2.Text = "(Popisek)";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(59, 362);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(434, 94);
            checkedListBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 335);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 3;
            label3.Text = "Termín Splnění (XX.YY.2024)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(69, 105);
            label4.Name = "label4";
            label4.Size = new Size(174, 19);
            label4.TabIndex = 4;
            label4.Text = "(Vytvořeno (xx.yy.2024))";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(532, 423);
            button1.Name = "button1";
            button1.Size = new Size(111, 59);
            button1.TabIndex = 5;
            button1.Text = "Splněno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 11);
            button2.Name = "button2";
            button2.Size = new Size(111, 59);
            button2.TabIndex = 6;
            button2.Text = "Smazat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(172, 11);
            button3.Name = "button3";
            button3.Size = new Size(111, 59);
            button3.TabIndex = 7;
            button3.Text = "Upravit";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(427, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(533, 34);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 9;
            label5.Text = "(Název Projektu)";
            // 
            // PoznamkaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PoznamkaView";
            Size = new Size(693, 520);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
