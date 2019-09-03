namespace StatisticsCalculator
{
    partial class statisticsCalculatorMainForm
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
            this.loadDataButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.dataSetGroupBox = new System.Windows.Forms.GroupBox();
            this.dataSetTextBox = new System.Windows.Forms.TextBox();
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.medianTextBox = new System.Windows.Forms.TextBox();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            this.rangeTextBox = new System.Windows.Forms.TextBox();
            this.maximumValueTextBox = new System.Windows.Forms.TextBox();
            this.minimumValueTextBox = new System.Windows.Forms.TextBox();
            this.medianLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.maximumValueLabel = new System.Windows.Forms.Label();
            this.minimumValueLabel = new System.Windows.Forms.Label();
            this.calculateStatisticsButton = new System.Windows.Forms.Button();
            this.histogramGroupBox = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.histogramTextBox = new System.Windows.Forms.TextBox();
            this.dataSetGroupBox.SuspendLayout();
            this.statisticsGroupBox.SuspendLayout();
            this.histogramGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadDataButton
            // 
            this.loadDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataButton.Location = new System.Drawing.Point(111, 35);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(85, 63);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = false;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // saveDataButton
            // 
            this.saveDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataButton.Location = new System.Drawing.Point(111, 104);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(85, 64);
            this.saveDataButton.TabIndex = 1;
            this.saveDataButton.Text = "Save Data";
            this.saveDataButton.UseVisualStyleBackColor = false;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // dataSetGroupBox
            // 
            this.dataSetGroupBox.Controls.Add(this.dataSetTextBox);
            this.dataSetGroupBox.Controls.Add(this.saveDataButton);
            this.dataSetGroupBox.Controls.Add(this.loadDataButton);
            this.dataSetGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSetGroupBox.Location = new System.Drawing.Point(17, 10);
            this.dataSetGroupBox.Name = "dataSetGroupBox";
            this.dataSetGroupBox.Size = new System.Drawing.Size(202, 369);
            this.dataSetGroupBox.TabIndex = 2;
            this.dataSetGroupBox.TabStop = false;
            this.dataSetGroupBox.Text = "Data Set";
            // 
            // dataSetTextBox
            // 
            this.dataSetTextBox.Location = new System.Drawing.Point(6, 35);
            this.dataSetTextBox.Multiline = true;
            this.dataSetTextBox.Name = "dataSetTextBox";
            this.dataSetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataSetTextBox.Size = new System.Drawing.Size(87, 314);
            this.dataSetTextBox.TabIndex = 2;
            this.dataSetTextBox.TextChanged += new System.EventHandler(this.loadDataButton_Click);
            this.dataSetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataSetTextBox_KeyPress);
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Controls.Add(this.medianTextBox);
            this.statisticsGroupBox.Controls.Add(this.meanTextBox);
            this.statisticsGroupBox.Controls.Add(this.rangeTextBox);
            this.statisticsGroupBox.Controls.Add(this.maximumValueTextBox);
            this.statisticsGroupBox.Controls.Add(this.minimumValueTextBox);
            this.statisticsGroupBox.Controls.Add(this.medianLabel);
            this.statisticsGroupBox.Controls.Add(this.meanLabel);
            this.statisticsGroupBox.Controls.Add(this.rangeLabel);
            this.statisticsGroupBox.Controls.Add(this.maximumValueLabel);
            this.statisticsGroupBox.Controls.Add(this.minimumValueLabel);
            this.statisticsGroupBox.Controls.Add(this.calculateStatisticsButton);
            this.statisticsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsGroupBox.Location = new System.Drawing.Point(227, 10);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(313, 181);
            this.statisticsGroupBox.TabIndex = 3;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statistics";
            // 
            // medianTextBox
            // 
            this.medianTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianTextBox.Location = new System.Drawing.Point(240, 150);
            this.medianTextBox.Name = "medianTextBox";
            this.medianTextBox.ReadOnly = true;
            this.medianTextBox.Size = new System.Drawing.Size(59, 26);
            this.medianTextBox.TabIndex = 10;
            // 
            // meanTextBox
            // 
            this.meanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanTextBox.Location = new System.Drawing.Point(240, 118);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.ReadOnly = true;
            this.meanTextBox.Size = new System.Drawing.Size(59, 26);
            this.meanTextBox.TabIndex = 9;
            // 
            // rangeTextBox
            // 
            this.rangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeTextBox.Location = new System.Drawing.Point(240, 86);
            this.rangeTextBox.Name = "rangeTextBox";
            this.rangeTextBox.ReadOnly = true;
            this.rangeTextBox.Size = new System.Drawing.Size(59, 26);
            this.rangeTextBox.TabIndex = 8;
            // 
            // maximumValueTextBox
            // 
            this.maximumValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumValueTextBox.Location = new System.Drawing.Point(240, 54);
            this.maximumValueTextBox.Name = "maximumValueTextBox";
            this.maximumValueTextBox.ReadOnly = true;
            this.maximumValueTextBox.Size = new System.Drawing.Size(59, 26);
            this.maximumValueTextBox.TabIndex = 7;
            // 
            // minimumValueTextBox
            // 
            this.minimumValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumValueTextBox.Location = new System.Drawing.Point(240, 20);
            this.minimumValueTextBox.Name = "minimumValueTextBox";
            this.minimumValueTextBox.ReadOnly = true;
            this.minimumValueTextBox.Size = new System.Drawing.Size(59, 26);
            this.minimumValueTextBox.TabIndex = 6;
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianLabel.Location = new System.Drawing.Point(169, 150);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(65, 20);
            this.medianLabel.TabIndex = 5;
            this.medianLabel.Text = "Median:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanLabel.Location = new System.Drawing.Point(181, 121);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(53, 20);
            this.meanLabel.TabIndex = 4;
            this.meanLabel.Text = "Mean:";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeLabel.Location = new System.Drawing.Point(173, 89);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(61, 20);
            this.rangeLabel.TabIndex = 3;
            this.rangeLabel.Text = "Range:";
            // 
            // maximumValueLabel
            // 
            this.maximumValueLabel.AutoSize = true;
            this.maximumValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumValueLabel.Location = new System.Drawing.Point(111, 57);
            this.maximumValueLabel.Name = "maximumValueLabel";
            this.maximumValueLabel.Size = new System.Drawing.Size(125, 20);
            this.maximumValueLabel.TabIndex = 2;
            this.maximumValueLabel.Text = "Maximum Value:";
            // 
            // minimumValueLabel
            // 
            this.minimumValueLabel.AutoSize = true;
            this.minimumValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumValueLabel.Location = new System.Drawing.Point(114, 24);
            this.minimumValueLabel.Name = "minimumValueLabel";
            this.minimumValueLabel.Size = new System.Drawing.Size(121, 20);
            this.minimumValueLabel.TabIndex = 1;
            this.minimumValueLabel.Text = "Minimum Value:";
            // 
            // calculateStatisticsButton
            // 
            this.calculateStatisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateStatisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateStatisticsButton.Location = new System.Drawing.Point(6, 30);
            this.calculateStatisticsButton.Name = "calculateStatisticsButton";
            this.calculateStatisticsButton.Size = new System.Drawing.Size(87, 72);
            this.calculateStatisticsButton.TabIndex = 0;
            this.calculateStatisticsButton.Text = "Calculate Statistics";
            this.calculateStatisticsButton.UseVisualStyleBackColor = false;
            this.calculateStatisticsButton.Click += new System.EventHandler(this.calculateStatisticsButton_Click);
            // 
            // histogramGroupBox
            // 
            this.histogramGroupBox.Controls.Add(this.histogramTextBox);
            this.histogramGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histogramGroupBox.Location = new System.Drawing.Point(228, 194);
            this.histogramGroupBox.Name = "histogramGroupBox";
            this.histogramGroupBox.Size = new System.Drawing.Size(311, 185);
            this.histogramGroupBox.TabIndex = 4;
            this.histogramGroupBox.TabStop = false;
            this.histogramGroupBox.Text = "Histogram";
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(463, 385);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(76, 29);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // histogramTextBox
            // 
            this.histogramTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histogramTextBox.Location = new System.Drawing.Point(10, 30);
            this.histogramTextBox.Multiline = true;
            this.histogramTextBox.Name = "histogramTextBox";
            this.histogramTextBox.ReadOnly = true;
            this.histogramTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.histogramTextBox.Size = new System.Drawing.Size(287, 134);
            this.histogramTextBox.TabIndex = 0;
            // 
            // statisticsCalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.histogramGroupBox);
            this.Controls.Add(this.statisticsGroupBox);
            this.Controls.Add(this.dataSetGroupBox);
            this.Name = "statisticsCalculatorMainForm";
            this.Text = "Statistics Calculator";
            this.dataSetGroupBox.ResumeLayout(false);
            this.dataSetGroupBox.PerformLayout();
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            this.histogramGroupBox.ResumeLayout(false);
            this.histogramGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.GroupBox dataSetGroupBox;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.TextBox medianTextBox;
        private System.Windows.Forms.TextBox meanTextBox;
        private System.Windows.Forms.TextBox rangeTextBox;
        private System.Windows.Forms.TextBox maximumValueTextBox;
        private System.Windows.Forms.TextBox minimumValueTextBox;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label maximumValueLabel;
        private System.Windows.Forms.Label minimumValueLabel;
        private System.Windows.Forms.Button calculateStatisticsButton;
        private System.Windows.Forms.GroupBox histogramGroupBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox dataSetTextBox;
        private System.Windows.Forms.TextBox histogramTextBox;
    }
}

