namespace EmguCvProject
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
            this.picInput = new System.Windows.Forms.PictureBox();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblBroj = new System.Windows.Forms.Label();
            this.picOutput2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnEdgeDetection = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblDetectParams = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.CarHeight = new System.Windows.Forms.NumericUpDown();
            this.CarWidth = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // picInput
            // 
            this.picInput.Location = new System.Drawing.Point(12, 49);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(522, 456);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInput.TabIndex = 0;
            this.picInput.TabStop = false;
            // 
            // picOutput
            // 
            this.picOutput.Location = new System.Drawing.Point(564, 49);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(522, 456);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOutput.TabIndex = 1;
            this.picOutput.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 552);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(125, 43);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(564, 552);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 43);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(348, 552);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(0, 29);
            this.lblBroj.TabIndex = 4;
            // 
            // picOutput2
            // 
            this.picOutput2.Location = new System.Drawing.Point(1120, 49);
            this.picOutput2.Name = "picOutput2";
            this.picOutput2.Size = new System.Drawing.Size(522, 456);
            this.picOutput2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOutput2.TabIndex = 5;
            this.picOutput2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "broj auta:";
            // 
            // btnConvert2
            // 
            this.btnConvert2.Location = new System.Drawing.Point(736, 552);
            this.btnConvert2.Name = "btnConvert2";
            this.btnConvert2.Size = new System.Drawing.Size(125, 43);
            this.btnConvert2.TabIndex = 7;
            this.btnConvert2.Text = "Convert 2";
            this.btnConvert2.UseVisualStyleBackColor = true;
            this.btnConvert2.Visible = false;
            this.btnConvert2.Click += new System.EventHandler(this.btnConvert2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 612);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 43);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(175, 612);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 43);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(564, 612);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 43);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send Data";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(736, 612);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(125, 43);
            this.btnGet.TabIndex = 11;
            this.btnGet.Text = "Get Data";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Visible = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnEdgeDetection
            // 
            this.btnEdgeDetection.Location = new System.Drawing.Point(887, 552);
            this.btnEdgeDetection.Name = "btnEdgeDetection";
            this.btnEdgeDetection.Size = new System.Drawing.Size(125, 43);
            this.btnEdgeDetection.TabIndex = 12;
            this.btnEdgeDetection.Text = "Edge Detection";
            this.btnEdgeDetection.UseVisualStyleBackColor = true;
            this.btnEdgeDetection.Click += new System.EventHandler(this.btnEdgeDetection_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(1120, 556);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(1120, 596);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // lblDetectParams
            // 
            this.lblDetectParams.AutoSize = true;
            this.lblDetectParams.Location = new System.Drawing.Point(1117, 526);
            this.lblDetectParams.Name = "lblDetectParams";
            this.lblDetectParams.Size = new System.Drawing.Size(173, 16);
            this.lblDetectParams.TabIndex = 15;
            this.lblDetectParams.Text = "Edge detection parameters:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(1341, 526);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(130, 16);
            this.lblSize.TabIndex = 18;
            this.lblSize.Text = "Car size parameters:";
            // 
            // CarHeight
            // 
            this.CarHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CarHeight.Location = new System.Drawing.Point(1344, 596);
            this.CarHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CarHeight.Name = "CarHeight";
            this.CarHeight.Size = new System.Drawing.Size(120, 22);
            this.CarHeight.TabIndex = 17;
            this.CarHeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // CarWidth
            // 
            this.CarWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CarWidth.Location = new System.Drawing.Point(1344, 556);
            this.CarWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CarWidth.Name = "CarWidth";
            this.CarWidth.Size = new System.Drawing.Size(120, 22);
            this.CarWidth.TabIndex = 16;
            this.CarWidth.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Change color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.CarHeight);
            this.Controls.Add(this.CarWidth);
            this.Controls.Add(this.lblDetectParams);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnEdgeDetection);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnConvert2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picOutput2);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picOutput);
            this.Controls.Add(this.picInput);
            this.Name = "Form1";
            this.Text = "Car recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.PictureBox picOutput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnEdgeDetection;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblDetectParams;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown CarHeight;
        private System.Windows.Forms.NumericUpDown CarWidth;
        private System.Windows.Forms.Button button1;
    }
}

