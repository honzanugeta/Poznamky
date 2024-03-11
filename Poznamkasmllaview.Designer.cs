namespace Poznamky
{
    partial class Poznamkasmllaview
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 15);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 0;
            label1.Text = "(Název Poznámky)";
            label1.Click += Poznamkasmllaview_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Poznamkasmllaview_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(98, 47);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 2;
            label2.Text = "(DatumSplnění)";
            label2.Click += Poznamkasmllaview_Click;
            // 
            // Poznamkasmllaview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Poznamkasmllaview";
            Size = new Size(273, 85);
            Click += Poznamkasmllaview_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
