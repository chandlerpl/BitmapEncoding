namespace BitmapEncoding
{
    partial class Form1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.encoderButton = new System.Windows.Forms.Button();
            this.decoderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.conversionRate = new System.Windows.Forms.Label();
            this.outputSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.encoderPanel = new System.Windows.Forms.Panel();
            this.decoderPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.outputImage = new System.Windows.Forms.PictureBox();
            this.encoderPanel.SuspendLayout();
            this.decoderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 46);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(257, 567);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(718, 46);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(257, 567);
            this.outputBox.TabIndex = 1;
            // 
            // encoderButton
            // 
            this.encoderButton.Location = new System.Drawing.Point(276, 46);
            this.encoderButton.Name = "encoderButton";
            this.encoderButton.Size = new System.Drawing.Size(436, 23);
            this.encoderButton.TabIndex = 2;
            this.encoderButton.Text = "Encode";
            this.encoderButton.UseVisualStyleBackColor = true;
            this.encoderButton.Click += new System.EventHandler(this.encoderButton_Click);
            // 
            // decoderButton
            // 
            this.decoderButton.Location = new System.Drawing.Point(276, 75);
            this.decoderButton.Name = "decoderButton";
            this.decoderButton.Size = new System.Drawing.Size(436, 23);
            this.decoderButton.TabIndex = 3;
            this.decoderButton.Text = "Decode";
            this.decoderButton.UseVisualStyleBackColor = true;
            this.decoderButton.Click += new System.EventHandler(this.decoderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(714, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output:";
            // 
            // runBox
            // 
            this.runBox.Location = new System.Drawing.Point(3, 63);
            this.runBox.Multiline = true;
            this.runBox.Name = "runBox";
            this.runBox.Size = new System.Drawing.Size(400, 395);
            this.runBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Whole runs (debugging):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conversion Rate: ";
            // 
            // conversionRate
            // 
            this.conversionRate.AutoSize = true;
            this.conversionRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionRate.Location = new System.Drawing.Point(433, 163);
            this.conversionRate.Name = "conversionRate";
            this.conversionRate.Size = new System.Drawing.Size(0, 20);
            this.conversionRate.TabIndex = 9;
            // 
            // outputSize
            // 
            this.outputSize.AutoSize = true;
            this.outputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSize.Location = new System.Drawing.Point(433, 132);
            this.outputSize.Name = "outputSize";
            this.outputSize.Size = new System.Drawing.Size(0, 20);
            this.outputSize.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output Size:";
            // 
            // inputSize
            // 
            this.inputSize.AutoSize = true;
            this.inputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSize.Location = new System.Drawing.Point(433, 101);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(0, 20);
            this.inputSize.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Input Size:";
            // 
            // encoderPanel
            // 
            this.encoderPanel.Controls.Add(this.label3);
            this.encoderPanel.Controls.Add(this.runBox);
            this.encoderPanel.Controls.Add(this.label4);
            this.encoderPanel.Location = new System.Drawing.Point(287, 155);
            this.encoderPanel.Name = "encoderPanel";
            this.encoderPanel.Size = new System.Drawing.Size(406, 458);
            this.encoderPanel.TabIndex = 14;
            // 
            // decoderPanel
            // 
            this.decoderPanel.Controls.Add(this.outputImage);
            this.decoderPanel.Controls.Add(this.label5);
            this.decoderPanel.Location = new System.Drawing.Point(287, 155);
            this.decoderPanel.Name = "decoderPanel";
            this.decoderPanel.Size = new System.Drawing.Size(406, 458);
            this.decoderPanel.TabIndex = 15;
            this.decoderPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image:";
            // 
            // outputImage
            // 
            this.outputImage.Location = new System.Drawing.Point(3, 52);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(400, 403);
            this.outputImage.TabIndex = 8;
            this.outputImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 625);
            this.Controls.Add(this.decoderPanel);
            this.Controls.Add(this.encoderPanel);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.outputSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.conversionRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decoderButton);
            this.Controls.Add(this.encoderButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.encoderPanel.ResumeLayout(false);
            this.encoderPanel.PerformLayout();
            this.decoderPanel.ResumeLayout(false);
            this.decoderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button encoderButton;
        private System.Windows.Forms.Button decoderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox runBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label conversionRate;
        private System.Windows.Forms.Label outputSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label inputSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel encoderPanel;
        private System.Windows.Forms.Panel decoderPanel;
        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.Label label5;
    }
}

