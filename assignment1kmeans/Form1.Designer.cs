namespace assignment1kmeans
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ButtonRUN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonFileSelect.Location = new System.Drawing.Point(335, 9);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonFileSelect.TabIndex = 0;
            this.buttonFileSelect.Text = "Select File";
            this.buttonFileSelect.UseVisualStyleBackColor = false;
            this.buttonFileSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxFilename.Location = new System.Drawing.Point(12, 11);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.ReadOnly = true;
            this.textBoxFilename.Size = new System.Drawing.Size(317, 20);
            this.textBoxFilename.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(115, 37);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(115, 63);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount of clusters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount of iterations:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Thistle;
            this.listView1.Location = new System.Drawing.Point(12, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(267, 216);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonRUN
            // 
            this.ButtonRUN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonRUN.Location = new System.Drawing.Point(204, 39);
            this.ButtonRUN.Name = "ButtonRUN";
            this.ButtonRUN.Size = new System.Drawing.Size(206, 45);
            this.ButtonRUN.TabIndex = 8;
            this.ButtonRUN.Text = "RUN";
            this.ButtonRUN.UseVisualStyleBackColor = false;
            this.ButtonRUN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "testeuc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 307);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1187, 264);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::assignment1kmeans.Properties.Resources.crow_of_judgement;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1214, 607);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonRUN);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.buttonFileSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ButtonRUN;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

