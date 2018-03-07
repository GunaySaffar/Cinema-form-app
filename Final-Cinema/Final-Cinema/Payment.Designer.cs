namespace Final_Cinema
{
    partial class Payment
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
            this.card_box = new System.Windows.Forms.ComboBox();
            this.end_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(86, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select payment system:";
            // 
            // card_box
            // 
            this.card_box.FormattingEnabled = true;
            this.card_box.Location = new System.Drawing.Point(283, 120);
            this.card_box.Name = "card_box";
            this.card_box.Size = new System.Drawing.Size(121, 21);
            this.card_box.TabIndex = 11;
            // 
            // end_btn
            // 
            this.end_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.end_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_btn.Location = new System.Drawing.Point(284, 240);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(149, 38);
            this.end_btn.TabIndex = 21;
            this.end_btn.Text = "PAY";
            this.end_btn.UseVisualStyleBackColor = false;
            this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "GNY Cinema Center";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Cinema.Properties.Resources.backimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end_btn);
            this.Controls.Add(this.card_box);
            this.Controls.Add(this.label4);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox card_box;
        private System.Windows.Forms.Button end_btn;
        private System.Windows.Forms.Label label1;
    }
}