namespace Plot
{
    partial class FormPlot
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
            pictureBoxPlot = new PictureBox();
            textBoxCoordinates = new TextBox();
            label1 = new Label();
            textBoxUnit = new TextBox();
            buttonSaveAsImage = new Button();
            buttonPickNewOne = new Button();
            numericFontSize = new NumericUpDown();
            label2 = new Label();
            textBoxFunction = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericPlotWidth = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            buttonPlotColor = new Button();
            panelOptions = new Panel();
            labelResult = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBoxTo = new TextBox();
            textBoxFrom = new TextBox();
            textBoxStep = new TextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPlotWidth).BeginInit();
            panelOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPlot
            // 
            pictureBoxPlot.BackColor = Color.White;
            pictureBoxPlot.Dock = DockStyle.Fill;
            pictureBoxPlot.Location = new Point(0, 0);
            pictureBoxPlot.Name = "pictureBoxPlot";
            pictureBoxPlot.Size = new Size(800, 593);
            pictureBoxPlot.TabIndex = 0;
            pictureBoxPlot.TabStop = false;
            pictureBoxPlot.SizeChanged += PictureBoxPlot_SizeChanged;
            pictureBoxPlot.Paint += PictureBoxPlot_Paint;
            pictureBoxPlot.MouseDown += PictureBoxPlot_MouseDown;
            pictureBoxPlot.MouseMove += PictureBoxPlot_MouseMove;
            pictureBoxPlot.MouseUp += PictureBoxPlot_MouseUp;
            // 
            // textBoxCoordinates
            // 
            textBoxCoordinates.BorderStyle = BorderStyle.FixedSingle;
            textBoxCoordinates.Location = new Point(0, 0);
            textBoxCoordinates.Margin = new Padding(0);
            textBoxCoordinates.Name = "textBoxCoordinates";
            textBoxCoordinates.ReadOnly = true;
            textBoxCoordinates.Size = new Size(250, 23);
            textBoxCoordinates.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 29);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Scale";
            // 
            // textBoxUnit
            // 
            textBoxUnit.Location = new Point(40, 26);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(26, 23);
            textBoxUnit.TabIndex = 3;
            textBoxUnit.Validating += TextBoxUnit_Validating;
            textBoxUnit.Validated += TextBoxUnit_Validated;
            // 
            // buttonSaveAsImage
            // 
            buttonSaveAsImage.Location = new Point(0, 47);
            buttonSaveAsImage.Name = "buttonSaveAsImage";
            buttonSaveAsImage.Size = new Size(250, 23);
            buttonSaveAsImage.TabIndex = 4;
            buttonSaveAsImage.Text = "Save as image...";
            buttonSaveAsImage.UseVisualStyleBackColor = true;
            buttonSaveAsImage.Click += ButtonSaveAsImage_Click;
            // 
            // buttonPickNewOne
            // 
            buttonPickNewOne.Location = new Point(0, 0);
            buttonPickNewOne.Name = "buttonPickNewOne";
            buttonPickNewOne.Size = new Size(75, 23);
            buttonPickNewOne.TabIndex = 16;
            // 
            // numericFontSize
            // 
            numericFontSize.Location = new Point(167, 147);
            numericFontSize.Maximum = new decimal(new int[] { 36, 0, 0, 0 });
            numericFontSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericFontSize.Name = "numericFontSize";
            numericFontSize.Size = new Size(46, 23);
            numericFontSize.TabIndex = 6;
            numericFontSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericFontSize.ValueChanged += NumericFontSize_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 115);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 7;
            label2.Text = "Font size";
            // 
            // textBoxFunction
            // 
            textBoxFunction.Location = new Point(0, 76);
            textBoxFunction.Name = "textBoxFunction";
            textBoxFunction.ReadOnly = true;
            textBoxFunction.Size = new Size(250, 23);
            textBoxFunction.TabIndex = 8;
            textBoxFunction.TextChanged += textBoxFunction_TextChanged;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // numericPlotWidth
            // 
            numericPlotWidth.Location = new Point(94, 118);
            numericPlotWidth.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericPlotWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPlotWidth.Name = "numericPlotWidth";
            numericPlotWidth.Size = new Size(46, 23);
            numericPlotWidth.TabIndex = 12;
            numericPlotWidth.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericPlotWidth.ValueChanged += NumericPlotWidth_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(158, 118);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 13;
            label6.Text = "Plot size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(4, 146);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 14;
            label7.Text = "Plot color";
            // 
            // buttonPlotColor
            // 
            buttonPlotColor.BackColor = Color.Blue;
            buttonPlotColor.Location = new Point(94, 147);
            buttonPlotColor.Name = "buttonPlotColor";
            buttonPlotColor.Size = new Size(46, 23);
            buttonPlotColor.TabIndex = 15;
            buttonPlotColor.UseVisualStyleBackColor = false;
            buttonPlotColor.Click += ButtonPlotColor_Click;
            // 
            // panelOptions
            // 
            panelOptions.BackColor = SystemColors.Control;
            panelOptions.Controls.Add(label13);
            panelOptions.Controls.Add(textBoxStep);
            panelOptions.Controls.Add(labelResult);
            panelOptions.Controls.Add(label11);
            panelOptions.Controls.Add(textBox1);
            panelOptions.Controls.Add(label10);
            panelOptions.Controls.Add(label9);
            panelOptions.Controls.Add(label8);
            panelOptions.Controls.Add(textBoxTo);
            panelOptions.Controls.Add(textBoxFrom);
            panelOptions.Controls.Add(label2);
            panelOptions.Controls.Add(textBoxCoordinates);
            panelOptions.Controls.Add(label6);
            panelOptions.Controls.Add(numericFontSize);
            panelOptions.Controls.Add(buttonPlotColor);
            panelOptions.Controls.Add(textBoxUnit);
            panelOptions.Controls.Add(label7);
            panelOptions.Controls.Add(label1);
            panelOptions.Controls.Add(buttonSaveAsImage);
            panelOptions.Controls.Add(numericPlotWidth);
            panelOptions.Controls.Add(buttonPickNewOne);
            panelOptions.Controls.Add(textBoxFunction);
            panelOptions.Dock = DockStyle.Right;
            panelOptions.Location = new Point(550, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(250, 593);
            panelOptions.TabIndex = 17;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(72, 339);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(59, 21);
            labelResult.TabIndex = 25;
            labelResult.Text = "Square";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(77, 176);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 24;
            label11.Text = "Function";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(10, 339);
            label10.Name = "label10";
            label10.Size = new Size(56, 21);
            label10.TabIndex = 22;
            label10.Text = "Result:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(4, 243);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 20;
            label9.Text = "From:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(124, 243);
            label8.Name = "label8";
            label8.Size = new Size(28, 21);
            label8.TabIndex = 19;
            label8.Text = "To:";
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(158, 241);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(40, 23);
            textBoxTo.TabIndex = 18;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(66, 241);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(40, 23);
            textBoxFrom.TabIndex = 17;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(66, 293);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(40, 23);
            textBoxStep.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(10, 293);
            label13.Name = "label13";
            label13.Size = new Size(43, 21);
            label13.TabIndex = 28;
            label13.Text = "Step:";
            // 
            // FormPlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(panelOptions);
            Controls.Add(pictureBoxPlot);
            Name = "FormPlot";
            Text = "Plot";
            FormClosing += FormPlot_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPlotWidth).EndInit();
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlot;
        private System.Windows.Forms.TextBox textBoxCoordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Button buttonSaveAsImage;
        private System.Windows.Forms.Button buttonPickNewOne;
        private System.Windows.Forms.NumericUpDown numericFontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericPlotWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPlotColor;
        private System.Windows.Forms.Panel panelOptions;
        private Label label9;
        private Label label8;
        private TextBox textBoxTo;
        private TextBox textBoxFrom;
        private Label label11;
        private TextBox textBox1;
        private Label label10;
        private Label labelResult;
        private Label label13;
        private TextBox textBoxStep;
    }
}