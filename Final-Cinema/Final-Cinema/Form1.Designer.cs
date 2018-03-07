namespace Final_Cinema
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_user = new System.Windows.Forms.TextBox();
            this.log_pass = new System.Windows.Forms.TextBox();
            this.Registr_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(237, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // log_user
            // 
            this.log_user.Location = new System.Drawing.Point(343, 93);
            this.log_user.Name = "log_user";
            this.log_user.Size = new System.Drawing.Size(153, 20);
            this.log_user.TabIndex = 2;
            // 
            // log_pass
            // 
            this.log_pass.Location = new System.Drawing.Point(343, 155);
            this.log_pass.Name = "log_pass";
            this.log_pass.PasswordChar = '*';
            this.log_pass.Size = new System.Drawing.Size(153, 20);
            this.log_pass.TabIndex = 3;
            // 
            // Registr_btn
            // 
            this.Registr_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Registr_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registr_btn.Location = new System.Drawing.Point(175, 327);
            this.Registr_btn.Name = "Registr_btn";
            this.Registr_btn.Size = new System.Drawing.Size(149, 38);
            this.Registr_btn.TabIndex = 4;
            this.Registr_btn.Text = "Registr";
            this.Registr_btn.UseVisualStyleBackColor = false;
            this.Registr_btn.Click += new System.EventHandler(this.registr_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Login_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(415, 327);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(140, 38);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Log In";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(235, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username :";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.Transparent;
            this.error_label.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.error_label.Location = new System.Drawing.Point(339, 209);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(18, 21);
            this.error_label.TabIndex = 8;
            this.error_label.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(206, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "GNY Cinema Center";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Cinema.Properties.Resources.backimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Registr_btn);
            this.Controls.Add(this.log_pass);
            this.Controls.Add(this.log_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox log_user;
        private System.Windows.Forms.TextBox log_pass;
        private System.Windows.Forms.Button Registr_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label label5;
    }
}

