namespace ImageDownsizer
{
    partial class ImageDownsizer
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
            button1 = new Button();
            txtForDownscale = new TextBox();
            picBoxOriginal = new PictureBox();
            picBoxDownscaled = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDownscaled).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(329, 64);
            button1.Name = "button1";
            button1.Size = new Size(133, 32);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtForDownscale
            // 
            txtForDownscale.Location = new Point(166, 35);
            txtForDownscale.Name = "txtForDownscale";
            txtForDownscale.Size = new Size(464, 23);
            txtForDownscale.TabIndex = 2;
            // 
            // picBoxOriginal
            // 
            picBoxOriginal.Location = new Point(54, 140);
            picBoxOriginal.Name = "picBoxOriginal";
            picBoxOriginal.Size = new Size(275, 291);
            picBoxOriginal.TabIndex = 3;
            picBoxOriginal.TabStop = false;
            // 
            // picBoxDownscaled
            // 
            picBoxDownscaled.Location = new Point(460, 140);
            picBoxDownscaled.Name = "picBoxDownscaled";
            picBoxDownscaled.Size = new Size(275, 291);
            picBoxDownscaled.TabIndex = 4;
            picBoxDownscaled.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 113);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 5;
            label1.Text = "Original Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(646, 116);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 6;
            label2.Text = "New Image";
            // 
            // button2
            // 
            button2.Location = new Point(329, 102);
            button2.Name = "button2";
            button2.Size = new Size(133, 32);
            button2.TabIndex = 7;
            button2.Text = "Downscale";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 17);
            label3.Name = "label3";
            label3.Size = new Size(464, 15);
            label3.TabIndex = 8;
            label3.Text = "Enter your downscaling factor =>It's percentage between 1 and 100 of the original size!\r\n";
            // 
            // ImageDownsizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picBoxDownscaled);
            Controls.Add(picBoxOriginal);
            Controls.Add(txtForDownscale);
            Controls.Add(button1);
            Name = "ImageDownsizer";
            Text = "ImageDownsizer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDownscaled).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtForDownscale;
        private PictureBox picBoxOriginal;
        private PictureBox picBoxDownscaled;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}