namespace Fourier_Transformatie {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox_Origineel = new System.Windows.Forms.PictureBox();
            this.button_Inladen = new System.Windows.Forms.Button();
            this.button_Forward = new System.Windows.Forms.Button();
            this.button_Backwards = new System.Windows.Forms.Button();
            this.pictureBox_grijs = new System.Windows.Forms.PictureBox();
            this.label_origineel = new System.Windows.Forms.Label();
            this.label_grijs = new System.Windows.Forms.Label();
            this.label_Magnitude = new System.Windows.Forms.Label();
            this.pictureBox_Mag = new System.Windows.Forms.PictureBox();
            this.label_Reverse = new System.Windows.Forms.Label();
            this.pictureBox_Backward = new System.Windows.Forms.PictureBox();
            this.checkBox_shift = new System.Windows.Forms.CheckBox();
            this.numericUpDown_mag = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Origineel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grijs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mag)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Origineel
            // 
            this.pictureBox_Origineel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Origineel.Location = new System.Drawing.Point(16, 31);
            this.pictureBox_Origineel.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Origineel.Name = "pictureBox_Origineel";
            this.pictureBox_Origineel.Size = new System.Drawing.Size(682, 630);
            this.pictureBox_Origineel.TabIndex = 0;
            this.pictureBox_Origineel.TabStop = false;
            // 
            // button_Inladen
            // 
            this.button_Inladen.Location = new System.Drawing.Point(15, 670);
            this.button_Inladen.Margin = new System.Windows.Forms.Padding(4);
            this.button_Inladen.Name = "button_Inladen";
            this.button_Inladen.Size = new System.Drawing.Size(147, 31);
            this.button_Inladen.TabIndex = 1;
            this.button_Inladen.Text = "Add image";
            this.button_Inladen.UseVisualStyleBackColor = true;
            this.button_Inladen.Click += new System.EventHandler(this.button_Inladen_Click);
            // 
            // button_Forward
            // 
            this.button_Forward.Enabled = false;
            this.button_Forward.Location = new System.Drawing.Point(397, 670);
            this.button_Forward.Margin = new System.Windows.Forms.Padding(4);
            this.button_Forward.Name = "button_Forward";
            this.button_Forward.Size = new System.Drawing.Size(147, 31);
            this.button_Forward.TabIndex = 2;
            this.button_Forward.Text = "Forward FFT";
            this.button_Forward.UseVisualStyleBackColor = true;
            this.button_Forward.Click += new System.EventHandler(this.button_Forward_Click);
            // 
            // button_Backwards
            // 
            this.button_Backwards.Enabled = false;
            this.button_Backwards.Location = new System.Drawing.Point(552, 670);
            this.button_Backwards.Margin = new System.Windows.Forms.Padding(4);
            this.button_Backwards.Name = "button_Backwards";
            this.button_Backwards.Size = new System.Drawing.Size(147, 31);
            this.button_Backwards.TabIndex = 3;
            this.button_Backwards.Text = "Backward FFT";
            this.button_Backwards.UseVisualStyleBackColor = true;
            this.button_Backwards.Click += new System.EventHandler(this.button_Backwards_Click);
            // 
            // pictureBox_grijs
            // 
            this.pictureBox_grijs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_grijs.Location = new System.Drawing.Point(707, 31);
            this.pictureBox_grijs.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_grijs.Name = "pictureBox_grijs";
            this.pictureBox_grijs.Size = new System.Drawing.Size(340, 314);
            this.pictureBox_grijs.TabIndex = 5;
            this.pictureBox_grijs.TabStop = false;
            // 
            // label_origineel
            // 
            this.label_origineel.AutoSize = true;
            this.label_origineel.Location = new System.Drawing.Point(16, 11);
            this.label_origineel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_origineel.Name = "label_origineel";
            this.label_origineel.Size = new System.Drawing.Size(64, 16);
            this.label_origineel.TabIndex = 6;
            this.label_origineel.Text = "Origineel:";
            // 
            // label_grijs
            // 
            this.label_grijs.AutoSize = true;
            this.label_grijs.Location = new System.Drawing.Point(707, 11);
            this.label_grijs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grijs.Name = "label_grijs";
            this.label_grijs.Size = new System.Drawing.Size(73, 16);
            this.label_grijs.TabIndex = 7;
            this.label_grijs.Text = "Grey-scale";
            // 
            // label_Magnitude
            // 
            this.label_Magnitude.AutoSize = true;
            this.label_Magnitude.Location = new System.Drawing.Point(1056, 11);
            this.label_Magnitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Magnitude.Name = "label_Magnitude";
            this.label_Magnitude.Size = new System.Drawing.Size(115, 16);
            this.label_Magnitude.TabIndex = 11;
            this.label_Magnitude.Text = "Fourier Amplitude:";
            // 
            // pictureBox_Mag
            // 
            this.pictureBox_Mag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Mag.Location = new System.Drawing.Point(1056, 31);
            this.pictureBox_Mag.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Mag.Name = "pictureBox_Mag";
            this.pictureBox_Mag.Size = new System.Drawing.Size(340, 314);
            this.pictureBox_Mag.TabIndex = 10;
            this.pictureBox_Mag.TabStop = false;
            // 
            // label_Reverse
            // 
            this.label_Reverse.AutoSize = true;
            this.label_Reverse.Location = new System.Drawing.Point(1016, 362);
            this.label_Reverse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Reverse.Name = "label_Reverse";
            this.label_Reverse.Size = new System.Drawing.Size(98, 16);
            this.label_Reverse.TabIndex = 13;
            this.label_Reverse.Text = "Backward FFT:";
            // 
            // pictureBox_Backward
            // 
            this.pictureBox_Backward.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Backward.Location = new System.Drawing.Point(888, 382);
            this.pictureBox_Backward.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Backward.Name = "pictureBox_Backward";
            this.pictureBox_Backward.Size = new System.Drawing.Size(340, 314);
            this.pictureBox_Backward.TabIndex = 12;
            this.pictureBox_Backward.TabStop = false;
            // 
            // checkBox_shift
            // 
            this.checkBox_shift.AutoSize = true;
            this.checkBox_shift.Location = new System.Drawing.Point(283, 676);
            this.checkBox_shift.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_shift.Name = "checkBox_shift";
            this.checkBox_shift.Size = new System.Drawing.Size(73, 20);
            this.checkBox_shift.TabIndex = 18;
            this.checkBox_shift.Text = "Normal";
            this.checkBox_shift.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_mag
            // 
            this.numericUpDown_mag.Location = new System.Drawing.Point(19, 720);
            this.numericUpDown_mag.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_mag.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_mag.Name = "numericUpDown_mag";
            this.numericUpDown_mag.Size = new System.Drawing.Size(10, 22);
            this.numericUpDown_mag.TabIndex = 19;
            this.numericUpDown_mag.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 754);
            this.Controls.Add(this.numericUpDown_mag);
            this.Controls.Add(this.checkBox_shift);
            this.Controls.Add(this.label_Reverse);
            this.Controls.Add(this.pictureBox_Backward);
            this.Controls.Add(this.label_Magnitude);
            this.Controls.Add(this.pictureBox_Mag);
            this.Controls.Add(this.label_grijs);
            this.Controls.Add(this.label_origineel);
            this.Controls.Add(this.pictureBox_grijs);
            this.Controls.Add(this.button_Backwards);
            this.Controls.Add(this.button_Forward);
            this.Controls.Add(this.button_Inladen);
            this.Controls.Add(this.pictureBox_Origineel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1434, 801);
            this.MinimumSize = new System.Drawing.Size(1434, 801);
            this.Name = "Form1";
            this.Text = "Fourier Transformatie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Origineel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grijs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Origineel;
        private System.Windows.Forms.Button button_Inladen;
        private System.Windows.Forms.Button button_Forward;
        private System.Windows.Forms.Button button_Backwards;
        private System.Windows.Forms.PictureBox pictureBox_grijs;
        private System.Windows.Forms.Label label_origineel;
        private System.Windows.Forms.Label label_grijs;
        private System.Windows.Forms.Label label_Magnitude;
        private System.Windows.Forms.PictureBox pictureBox_Mag;
        private System.Windows.Forms.Label label_Reverse;
        private System.Windows.Forms.PictureBox pictureBox_Backward;
        private System.Windows.Forms.CheckBox checkBox_shift;
        private System.Windows.Forms.NumericUpDown numericUpDown_mag;
    }
}

