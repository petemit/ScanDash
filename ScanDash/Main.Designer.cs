namespace ScanDash
{
    partial class Main
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Flatbed_Bw_High = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Flatbed_Bw_Medium = new System.Windows.Forms.Button();
            this.Flatbed_Bw_Loww = new System.Windows.Forms.Button();
            this.Flatbed_Color_Low = new System.Windows.Forms.Button();
            this.Flatbed_Color_Medium = new System.Windows.Forms.Button();
            this.Flatbed_Color_High = new System.Windows.Forms.Button();
            this.Flatbed_Grayscale_Low = new System.Windows.Forms.Button();
            this.Flatbed_Grayscale_Medium = new System.Windows.Forms.Button();
            this.Flatbed_Grayscale_High = new System.Windows.Forms.Button();
            this.Adf_Grayscale_Low = new System.Windows.Forms.Button();
            this.Adf_Grayscale_Medium = new System.Windows.Forms.Button();
            this.Adf_Grayscale_High = new System.Windows.Forms.Button();
            this.Adf_Color_Low = new System.Windows.Forms.Button();
            this.Adf_Color_Medium = new System.Windows.Forms.Button();
            this.Adf_Color_High = new System.Windows.Forms.Button();
            this.Adf_Bw_Low = new System.Windows.Forms.Button();
            this.Adf_Bw_Medium = new System.Windows.Forms.Button();
            this.Adf_Bw_High = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.fieldValidationWarning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Flatbed_Bw_High
            // 
            this.Flatbed_Bw_High.Location = new System.Drawing.Point(41, 226);
            this.Flatbed_Bw_High.Name = "Flatbed_Bw_High";
            this.Flatbed_Bw_High.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Bw_High.TabIndex = 0;
            this.Flatbed_Bw_High.Text = "High";
            this.Flatbed_Bw_High.UseVisualStyleBackColor = true;
            this.Flatbed_Bw_High.Click += new System.EventHandler(this.Flatbed_Bw_High_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(487, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(484, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Document Feeder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(135, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Flatbed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(325, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Black and White";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(365, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(349, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grayscale";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Flatbed_Bw_Medium
            // 
            this.Flatbed_Bw_Medium.Location = new System.Drawing.Point(138, 226);
            this.Flatbed_Bw_Medium.Name = "Flatbed_Bw_Medium";
            this.Flatbed_Bw_Medium.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Bw_Medium.TabIndex = 11;
            this.Flatbed_Bw_Medium.Text = "Medium";
            this.Flatbed_Bw_Medium.UseVisualStyleBackColor = true;
            this.Flatbed_Bw_Medium.Click += new System.EventHandler(this.Flatbed_Bw_Medium_Click);
            // 
            // Flatbed_Bw_Loww
            // 
            this.Flatbed_Bw_Loww.Location = new System.Drawing.Point(234, 226);
            this.Flatbed_Bw_Loww.Name = "Flatbed_Bw_Loww";
            this.Flatbed_Bw_Loww.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Bw_Loww.TabIndex = 12;
            this.Flatbed_Bw_Loww.Text = "Low";
            this.Flatbed_Bw_Loww.UseVisualStyleBackColor = true;
            this.Flatbed_Bw_Loww.Click += new System.EventHandler(this.Flatbed_Bw_Low);
            // 
            // Flatbed_Color_Low
            // 
            this.Flatbed_Color_Low.Location = new System.Drawing.Point(234, 357);
            this.Flatbed_Color_Low.Name = "Flatbed_Color_Low";
            this.Flatbed_Color_Low.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Color_Low.TabIndex = 15;
            this.Flatbed_Color_Low.Text = "Low";
            this.Flatbed_Color_Low.UseVisualStyleBackColor = true;
            this.Flatbed_Color_Low.Click += new System.EventHandler(this.Flatbed_Color_Low_Click);
            // 
            // Flatbed_Color_Medium
            // 
            this.Flatbed_Color_Medium.Location = new System.Drawing.Point(138, 357);
            this.Flatbed_Color_Medium.Name = "Flatbed_Color_Medium";
            this.Flatbed_Color_Medium.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Color_Medium.TabIndex = 14;
            this.Flatbed_Color_Medium.Text = "Medium";
            this.Flatbed_Color_Medium.UseVisualStyleBackColor = true;
            this.Flatbed_Color_Medium.Click += new System.EventHandler(this.Flatbed_Color_Medium_Click);
            // 
            // Flatbed_Color_High
            // 
            this.Flatbed_Color_High.Location = new System.Drawing.Point(41, 357);
            this.Flatbed_Color_High.Name = "Flatbed_Color_High";
            this.Flatbed_Color_High.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Color_High.TabIndex = 13;
            this.Flatbed_Color_High.Text = "High";
            this.Flatbed_Color_High.UseVisualStyleBackColor = true;
            this.Flatbed_Color_High.Click += new System.EventHandler(this.Flatbed_Color_High_Click);
            // 
            // Flatbed_Grayscale_Low
            // 
            this.Flatbed_Grayscale_Low.Location = new System.Drawing.Point(234, 294);
            this.Flatbed_Grayscale_Low.Name = "Flatbed_Grayscale_Low";
            this.Flatbed_Grayscale_Low.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Grayscale_Low.TabIndex = 18;
            this.Flatbed_Grayscale_Low.Text = "Low";
            this.Flatbed_Grayscale_Low.UseVisualStyleBackColor = true;
            this.Flatbed_Grayscale_Low.Click += new System.EventHandler(this.Flatbed_Grayscale_Low_Click);
            // 
            // Flatbed_Grayscale_Medium
            // 
            this.Flatbed_Grayscale_Medium.Location = new System.Drawing.Point(138, 294);
            this.Flatbed_Grayscale_Medium.Name = "Flatbed_Grayscale_Medium";
            this.Flatbed_Grayscale_Medium.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Grayscale_Medium.TabIndex = 17;
            this.Flatbed_Grayscale_Medium.Text = "Medium";
            this.Flatbed_Grayscale_Medium.UseVisualStyleBackColor = true;
            this.Flatbed_Grayscale_Medium.Click += new System.EventHandler(this.Flatbed_Grayscale_Medium_Click);
            // 
            // Flatbed_Grayscale_High
            // 
            this.Flatbed_Grayscale_High.Location = new System.Drawing.Point(41, 294);
            this.Flatbed_Grayscale_High.Name = "Flatbed_Grayscale_High";
            this.Flatbed_Grayscale_High.Size = new System.Drawing.Size(75, 23);
            this.Flatbed_Grayscale_High.TabIndex = 16;
            this.Flatbed_Grayscale_High.Text = "High";
            this.Flatbed_Grayscale_High.UseVisualStyleBackColor = true;
            this.Flatbed_Grayscale_High.Click += new System.EventHandler(this.Flatbed_Grayscale_High_Click);
            // 
            // Adf_Grayscale_Low
            // 
            this.Adf_Grayscale_Low.Location = new System.Drawing.Point(667, 294);
            this.Adf_Grayscale_Low.Name = "Adf_Grayscale_Low";
            this.Adf_Grayscale_Low.Size = new System.Drawing.Size(75, 23);
            this.Adf_Grayscale_Low.TabIndex = 27;
            this.Adf_Grayscale_Low.Text = "Low";
            this.Adf_Grayscale_Low.UseVisualStyleBackColor = true;
            this.Adf_Grayscale_Low.Click += new System.EventHandler(this.Adf_Grayscale_Low_Click);
            // 
            // Adf_Grayscale_Medium
            // 
            this.Adf_Grayscale_Medium.Location = new System.Drawing.Point(571, 294);
            this.Adf_Grayscale_Medium.Name = "Adf_Grayscale_Medium";
            this.Adf_Grayscale_Medium.Size = new System.Drawing.Size(75, 23);
            this.Adf_Grayscale_Medium.TabIndex = 26;
            this.Adf_Grayscale_Medium.Text = "Medium";
            this.Adf_Grayscale_Medium.UseVisualStyleBackColor = true;
            this.Adf_Grayscale_Medium.Click += new System.EventHandler(this.Adf_Grayscale_Medium_Click);
            // 
            // Adf_Grayscale_High
            // 
            this.Adf_Grayscale_High.Location = new System.Drawing.Point(474, 294);
            this.Adf_Grayscale_High.Name = "Adf_Grayscale_High";
            this.Adf_Grayscale_High.Size = new System.Drawing.Size(75, 23);
            this.Adf_Grayscale_High.TabIndex = 25;
            this.Adf_Grayscale_High.Text = "High";
            this.Adf_Grayscale_High.UseVisualStyleBackColor = true;
            this.Adf_Grayscale_High.Click += new System.EventHandler(this.Adf_Grayscale_High_Click);
            // 
            // Adf_Color_Low
            // 
            this.Adf_Color_Low.Location = new System.Drawing.Point(667, 357);
            this.Adf_Color_Low.Name = "Adf_Color_Low";
            this.Adf_Color_Low.Size = new System.Drawing.Size(75, 23);
            this.Adf_Color_Low.TabIndex = 24;
            this.Adf_Color_Low.Text = "Low";
            this.Adf_Color_Low.UseVisualStyleBackColor = true;
            this.Adf_Color_Low.Click += new System.EventHandler(this.Adf_Color_Low_Click);
            // 
            // Adf_Color_Medium
            // 
            this.Adf_Color_Medium.Location = new System.Drawing.Point(571, 357);
            this.Adf_Color_Medium.Name = "Adf_Color_Medium";
            this.Adf_Color_Medium.Size = new System.Drawing.Size(75, 23);
            this.Adf_Color_Medium.TabIndex = 23;
            this.Adf_Color_Medium.Text = "Medium";
            this.Adf_Color_Medium.UseVisualStyleBackColor = true;
            this.Adf_Color_Medium.Click += new System.EventHandler(this.Adf_Color_Medium_Click);
            // 
            // Adf_Color_High
            // 
            this.Adf_Color_High.Location = new System.Drawing.Point(474, 357);
            this.Adf_Color_High.Name = "Adf_Color_High";
            this.Adf_Color_High.Size = new System.Drawing.Size(75, 23);
            this.Adf_Color_High.TabIndex = 22;
            this.Adf_Color_High.Text = "High";
            this.Adf_Color_High.UseVisualStyleBackColor = true;
            this.Adf_Color_High.Click += new System.EventHandler(this.Adf_Color_High_Click);
            // 
            // Adf_Bw_Low
            // 
            this.Adf_Bw_Low.Location = new System.Drawing.Point(667, 226);
            this.Adf_Bw_Low.Name = "Adf_Bw_Low";
            this.Adf_Bw_Low.Size = new System.Drawing.Size(75, 23);
            this.Adf_Bw_Low.TabIndex = 21;
            this.Adf_Bw_Low.Text = "Low";
            this.Adf_Bw_Low.UseVisualStyleBackColor = true;
            this.Adf_Bw_Low.Click += new System.EventHandler(this.Adf_Bw_Low_Click);
            // 
            // Adf_Bw_Medium
            // 
            this.Adf_Bw_Medium.Location = new System.Drawing.Point(571, 226);
            this.Adf_Bw_Medium.Name = "Adf_Bw_Medium";
            this.Adf_Bw_Medium.Size = new System.Drawing.Size(75, 23);
            this.Adf_Bw_Medium.TabIndex = 20;
            this.Adf_Bw_Medium.Text = "Medium";
            this.Adf_Bw_Medium.UseVisualStyleBackColor = true;
            this.Adf_Bw_Medium.Click += new System.EventHandler(this.Adf_Bw_Medium_Click);
            // 
            // Adf_Bw_High
            // 
            this.Adf_Bw_High.Location = new System.Drawing.Point(474, 226);
            this.Adf_Bw_High.Name = "Adf_Bw_High";
            this.Adf_Bw_High.Size = new System.Drawing.Size(75, 23);
            this.Adf_Bw_High.TabIndex = 19;
            this.Adf_Bw_High.Text = "High";
            this.Adf_Bw_High.UseVisualStyleBackColor = true;
            this.Adf_Bw_High.Click += new System.EventHandler(this.Adf_Bw_High_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(138, 430);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(159, 20);
            this.path.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(134, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Path";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SelectFolder
            // 
            this.SelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.SelectFolder.Location = new System.Drawing.Point(303, 430);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(25, 20);
            this.SelectFolder.TabIndex = 30;
            this.SelectFolder.Text = "...";
            this.SelectFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolderButton);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(470, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Filename";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(474, 430);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(159, 20);
            this.filename.TabIndex = 31;
            // 
            // fieldValidationWarning
            // 
            this.fieldValidationWarning.AutoSize = true;
            this.fieldValidationWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fieldValidationWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldValidationWarning.ForeColor = System.Drawing.SystemColors.Control;
            this.fieldValidationWarning.Location = new System.Drawing.Point(242, 470);
            this.fieldValidationWarning.Name = "fieldValidationWarning";
            this.fieldValidationWarning.Size = new System.Drawing.Size(283, 16);
            this.fieldValidationWarning.TabIndex = 33;
            this.fieldValidationWarning.Text = "Ensure Path and Filename are not blank";
            this.fieldValidationWarning.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Restart Scanner Service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.restartService);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fieldValidationWarning);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.path);
            this.Controls.Add(this.Adf_Grayscale_Low);
            this.Controls.Add(this.Adf_Grayscale_Medium);
            this.Controls.Add(this.Adf_Grayscale_High);
            this.Controls.Add(this.Adf_Color_Low);
            this.Controls.Add(this.Adf_Color_Medium);
            this.Controls.Add(this.Adf_Color_High);
            this.Controls.Add(this.Adf_Bw_Low);
            this.Controls.Add(this.Adf_Bw_Medium);
            this.Controls.Add(this.Adf_Bw_High);
            this.Controls.Add(this.Flatbed_Grayscale_Low);
            this.Controls.Add(this.Flatbed_Grayscale_Medium);
            this.Controls.Add(this.Flatbed_Grayscale_High);
            this.Controls.Add(this.Flatbed_Color_Low);
            this.Controls.Add(this.Flatbed_Color_Medium);
            this.Controls.Add(this.Flatbed_Color_High);
            this.Controls.Add(this.Flatbed_Bw_Loww);
            this.Controls.Add(this.Flatbed_Bw_Medium);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Flatbed_Bw_High);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Flatbed_Bw_High;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Flatbed_Bw_Medium;
        private System.Windows.Forms.Button Flatbed_Bw_Loww;
        private System.Windows.Forms.Button Flatbed_Color_Low;
        private System.Windows.Forms.Button Flatbed_Color_Medium;
        private System.Windows.Forms.Button Flatbed_Color_High;
        private System.Windows.Forms.Button Flatbed_Grayscale_Low;
        private System.Windows.Forms.Button Flatbed_Grayscale_Medium;
        private System.Windows.Forms.Button Flatbed_Grayscale_High;
        private System.Windows.Forms.Button Adf_Grayscale_Low;
        private System.Windows.Forms.Button Adf_Grayscale_Medium;
        private System.Windows.Forms.Button Adf_Grayscale_High;
        private System.Windows.Forms.Button Adf_Color_Low;
        private System.Windows.Forms.Button Adf_Color_Medium;
        private System.Windows.Forms.Button Adf_Color_High;
        private System.Windows.Forms.Button Adf_Bw_Low;
        private System.Windows.Forms.Button Adf_Bw_Medium;
        private System.Windows.Forms.Button Adf_Bw_High;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label fieldValidationWarning;
        private System.Windows.Forms.Button button1;
    }
}

