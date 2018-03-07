namespace Final_Cinema
{
    partial class DataTime
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_box = new System.Windows.Forms.ComboBox();
            this.time_box = new System.Windows.Forms.ComboBox();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.people_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.price_show_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(187, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Data :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(414, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Time :";
            // 
            // date_box
            // 
            this.date_box.FormattingEnabled = true;
            this.date_box.Location = new System.Drawing.Point(172, 121);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(121, 21);
            this.date_box.TabIndex = 11;
            this.date_box.SelectedIndexChanged += new System.EventHandler(this.date_box_SelectedIndexChanged);
            // 
            // time_box
            // 
            this.time_box.FormattingEnabled = true;
            this.time_box.Location = new System.Drawing.Point(404, 121);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(121, 21);
            this.time_box.TabIndex = 12;
            this.time_box.SelectedIndexChanged += new System.EventHandler(this.time_box_SelectedIndexChanged);
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.prev_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_btn.Location = new System.Drawing.Point(70, 407);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(149, 38);
            this.prev_btn.TabIndex = 19;
            this.prev_btn.Text = "PREVIOUS";
            this.prev_btn.UseVisualStyleBackColor = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.next_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(489, 407);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(149, 38);
            this.next_btn.TabIndex = 20;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // people_box
            // 
            this.people_box.FormattingEnabled = true;
            this.people_box.Location = new System.Drawing.Point(300, 262);
            this.people_box.Name = "people_box";
            this.people_box.Size = new System.Drawing.Size(121, 21);
            this.people_box.TabIndex = 21;
            this.people_box.SelectedIndexChanged += new System.EventHandler(this.people_box_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(319, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "(max 10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(262, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "PRICE :";
            // 
            // price_show_box
            // 
            this.price_show_box.BackColor = System.Drawing.SystemColors.HighlightText;
            this.price_show_box.Location = new System.Drawing.Point(332, 345);
            this.price_show_box.Name = "price_show_box";
            this.price_show_box.Size = new System.Drawing.Size(65, 20);
            this.price_show_box.TabIndex = 24;
            this.price_show_box.TextChanged += new System.EventHandler(this.price_show_box_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(197, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "GNY Cinema Center";
            // 
            // DataTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Cinema.Properties.Resources.backimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 509);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_show_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.people_box);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.time_box);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "DataTime";
            this.Text = "DataTime";
            this.Load += new System.EventHandler(this.DataTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox date_box;
        private System.Windows.Forms.ComboBox time_box;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.ComboBox people_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price_show_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}