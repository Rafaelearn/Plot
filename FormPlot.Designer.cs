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
            pictureBoxPlot = new System.Windows.Forms.PictureBox();
            textBoxCoordinates = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            textBoxUnit = new System.Windows.Forms.TextBox();
            buttonSaveAsImage = new System.Windows.Forms.Button();
            buttonPickNewOne = new System.Windows.Forms.Button();
            numericFontSize = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            textBoxFunction = new System.Windows.Forms.TextBox();
            textBoxTo = new System.Windows.Forms.TextBox();
            textBoxFrom = new System.Windows.Forms.TextBox();
            textBoxResult = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numericPlotWidth = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            buttonPlotColor = new System.Windows.Forms.Button();
            panelOptions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPlotWidth).BeginInit();
            panelOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPlot
            // 
            pictureBoxPlot.BackColor = System.Drawing.Color.White;
            pictureBoxPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxPlot.Location = new System.Drawing.Point(0, 0);
            pictureBoxPlot.Name = "pictureBoxPlot";
            pictureBoxPlot.Size = new System.Drawing.Size(800, 593);
            pictureBoxPlot.TabIndex = 0;
            pictureBoxPlot.TabStop = false;
            pictureBoxPlot.SizeChanged += PictureBoxPlot_SizeChanged;
            pictureBoxPlot.Click += pictureBoxPlot_Click;
            pictureBoxPlot.Paint += PictureBoxPlot_Paint;
            pictureBoxPlot.MouseDown += PictureBoxPlot_MouseDown;
            pictureBoxPlot.MouseMove += PictureBoxPlot_MouseMove;
            pictureBoxPlot.MouseUp += PictureBoxPlot_MouseUp;
            // 
            // textBoxCoordinates
            // 
            textBoxCoordinates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxCoordinates.Location = new System.Drawing.Point(0, 0);
            textBoxCoordinates.Margin = new System.Windows.Forms.Padding(0);
            textBoxCoordinates.Name = "textBoxCoordinates";
            textBoxCoordinates.ReadOnly = true;
            textBoxCoordinates.Size = new System.Drawing.Size(250, 23);
            textBoxCoordinates.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Scale";
            label1.Click += label1_Click;
            // 
            // textBoxUnit
            // 
            textBoxUnit.Location = new System.Drawing.Point(40, 26);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new System.Drawing.Size(26, 23);
            textBoxUnit.TabIndex = 3;
            textBoxUnit.Validating += TextBoxUnit_Validating;
            textBoxUnit.Validated += TextBoxUnit_Validated;
            // 
            // buttonSaveAsImage
            // 
            buttonSaveAsImage.Location = new System.Drawing.Point(0, 47);
            buttonSaveAsImage.Name = "buttonSaveAsImage";
            buttonSaveAsImage.Size = new System.Drawing.Size(250, 23);
            buttonSaveAsImage.TabIndex = 4;
            buttonSaveAsImage.Text = "Save as image...";
            buttonSaveAsImage.UseVisualStyleBackColor = true;
            buttonSaveAsImage.Click += ButtonSaveAsImage_Click;
            // 
            // buttonPickNewOne
            // 
            buttonPickNewOne.Location = new System.Drawing.Point(0, 0);
            buttonPickNewOne.Name = "buttonPickNewOne";
            buttonPickNewOne.Size = new System.Drawing.Size(75, 23);
            buttonPickNewOne.TabIndex = 16;
            // 
            // numericFontSize
            // 
            numericFontSize.Location = new System.Drawing.Point(201, 160);
            numericFontSize.Maximum = new decimal(new int[] { 36, 0, 0, 0 });
            numericFontSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericFontSize.Name = "numericFontSize";
            numericFontSize.Size = new System.Drawing.Size(46, 23);
            numericFontSize.TabIndex = 6;
            numericFontSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericFontSize.ValueChanged += NumericFontSize_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(4, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 21);
            label2.TabIndex = 7;
            label2.Text = "Font size";
            // 
            // textBoxFunction
            // 
            textBoxFunction.Location = new System.Drawing.Point(0, 76);
            textBoxFunction.Name = "textBoxFunction";
            textBoxFunction.ReadOnly = true;
            textBoxFunction.Size = new System.Drawing.Size(250, 23);
            textBoxFunction.TabIndex = 8;
            textBoxFunction.TextChanged += textBoxFunction_TextChanged;
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new System.Drawing.Point(0, 0);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new System.Drawing.Size(100, 23);
            textBoxTo.TabIndex = 0;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new System.Drawing.Point(0, 0);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new System.Drawing.Size(100, 23);
            textBoxFrom.TabIndex = 0;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new System.Drawing.Point(0, 0);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new System.Drawing.Size(100, 23);
            textBoxResult.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(0, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(0, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 23);
            label3.TabIndex = 0;
            // 
            // numericPlotWidth
            // 
            numericPlotWidth.Location = new System.Drawing.Point(85, 118);
            numericPlotWidth.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericPlotWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPlotWidth.Name = "numericPlotWidth";
            numericPlotWidth.Size = new System.Drawing.Size(46, 23);
            numericPlotWidth.TabIndex = 12;
            numericPlotWidth.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericPlotWidth.ValueChanged += NumericPlotWidth_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(137, 162);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 21);
            label6.TabIndex = 13;
            label6.Text = "Plot size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(3, 159);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 21);
            label7.TabIndex = 14;
            label7.Text = "Plot color";
            // 
            // buttonPlotColor
            // 
            buttonPlotColor.BackColor = System.Drawing.Color.Blue;
            buttonPlotColor.Location = new System.Drawing.Point(85, 160);
            buttonPlotColor.Name = "buttonPlotColor";
            buttonPlotColor.Size = new System.Drawing.Size(46, 23);
            buttonPlotColor.TabIndex = 15;
            buttonPlotColor.UseVisualStyleBackColor = false;
            buttonPlotColor.Click += ButtonPlotColor_Click;
            // 
            // panelOptions
            // 
            panelOptions.BackColor = System.Drawing.SystemColors.Control;
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
            panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            panelOptions.Location = new System.Drawing.Point(550, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new System.Drawing.Size(250, 593);
            panelOptions.TabIndex = 17;
            // 
            // FormPlot
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 593);
            Controls.Add(panelOptions);
            Controls.Add(pictureBoxPlot);
            Name = "FormPlot";
            Text = "Plot";
            FormClosing += FormPlot_FormClosing;
            Load += FormPlot_Load;
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
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.NumericUpDown numericPlotWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPlotColor;
        private System.Windows.Forms.Panel panelOptions;
    }
}