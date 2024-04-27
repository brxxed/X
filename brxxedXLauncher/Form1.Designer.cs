namespace brxxedXLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loadLabel
            // 
            loadLabel.AutoSize = true;
            loadLabel.Font = new Font("Exo 2", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadLabel.Location = new Point(297, 275);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(200, 31);
            loadLabel.TabIndex = 0;
            loadLabel.Text = "x assets loading......";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.brxxedX256;
            pictureBox1.Location = new Point(319, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(loadLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "brxxed X";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loadLabel;
        private PictureBox pictureBox1;
    }
}
