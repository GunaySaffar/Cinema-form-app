namespace Final_Cinema
{
    partial class Movies
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
            this.film1 = new System.Windows.Forms.Button();
            this.film5 = new System.Windows.Forms.Button();
            this.film3 = new System.Windows.Forms.Button();
            this.film2 = new System.Windows.Forms.Button();
            this.film4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // film1
            // 
            this.film1.BackgroundImage = global::Final_Cinema.Properties.Resources.mebeforeu;
            this.film1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.film1.ForeColor = System.Drawing.Color.White;
            this.film1.Location = new System.Drawing.Point(12, 98);
            this.film1.Name = "film1";
            this.film1.Size = new System.Drawing.Size(134, 394);
            this.film1.TabIndex = 0;
            this.film1.Text = "Me Before You";
            this.film1.UseVisualStyleBackColor = true;
            this.film1.Click += new System.EventHandler(this.button1_Click);
            // 
            // film5
            // 
            this.film5.BackgroundImage = global::Final_Cinema.Properties.Resources.images;
            this.film5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.film5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.film5.Location = new System.Drawing.Point(578, 98);
            this.film5.Name = "film5";
            this.film5.Size = new System.Drawing.Size(134, 394);
            this.film5.TabIndex = 1;
            this.film5.Text = "Lalaland";
            this.film5.UseVisualStyleBackColor = true;
            this.film5.Click += new System.EventHandler(this.film5_Click);
            // 
            // film3
            // 
            this.film3.BackgroundImage = global::Final_Cinema.Properties.Resources.Без_названия;
            this.film3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.film3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.film3.Location = new System.Drawing.Point(289, 98);
            this.film3.Name = "film3";
            this.film3.Size = new System.Drawing.Size(134, 394);
            this.film3.TabIndex = 2;
            this.film3.Text = "Dear John";
            this.film3.UseVisualStyleBackColor = true;
            this.film3.Click += new System.EventHandler(this.film3_Click);
            // 
            // film2
            // 
            this.film2.BackgroundImage = global::Final_Cinema.Properties.Resources._1307029911_online;
            this.film2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.film2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.film2.Location = new System.Drawing.Point(165, 134);
            this.film2.Name = "film2";
            this.film2.Size = new System.Drawing.Size(102, 338);
            this.film2.TabIndex = 3;
            this.film2.Text = "Pride&Prejudice";
            this.film2.UseVisualStyleBackColor = true;
            this.film2.Click += new System.EventHandler(this.film2_Click);
            // 
            // film4
            // 
            this.film4.BackgroundImage = global::Final_Cinema.Properties.Resources.Без_названия__1_;
            this.film4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.film4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.film4.Location = new System.Drawing.Point(452, 134);
            this.film4.Name = "film4";
            this.film4.Size = new System.Drawing.Size(102, 335);
            this.film4.TabIndex = 4;
            this.film4.Text = "The Best Of Me";
            this.film4.UseVisualStyleBackColor = true;
            this.film4.Click += new System.EventHandler(this.film4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(231, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "GNY Cinema Center";
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Cinema.Properties.Resources.backimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.film4);
            this.Controls.Add(this.film2);
            this.Controls.Add(this.film3);
            this.Controls.Add(this.film5);
            this.Controls.Add(this.film1);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button film1;
        private System.Windows.Forms.Button film5;
        private System.Windows.Forms.Button film3;
        private System.Windows.Forms.Button film2;
        private System.Windows.Forms.Button film4;
        private System.Windows.Forms.Label label1;
    }
}