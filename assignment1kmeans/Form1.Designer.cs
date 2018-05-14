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
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::assignment1kmeans.Properties.Resources.crow_of_judgement;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(782, 395);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.buttonFileSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.TextBox textBoxFilename;
    }
}

