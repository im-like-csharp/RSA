namespace RSA
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
            this.p_text = new System.Windows.Forms.TextBox();
            this.q_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.n_text = new System.Windows.Forms.TextBox();
            this.d_text = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.IN = new System.Windows.Forms.RichTextBox();
            this.OUT = new System.Windows.Forms.RichTextBox();
            this.Crypted = new System.Windows.Forms.RichTextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.e_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p_text
            // 
            this.p_text.Location = new System.Drawing.Point(43, 54);
            this.p_text.Name = "p_text";
            this.p_text.ReadOnly = true;
            this.p_text.Size = new System.Drawing.Size(297, 20);
            this.p_text.TabIndex = 0;
            this.p_text.TextChanged += new System.EventHandler(this.p_text_TextChanged);
            // 
            // q_text
            // 
            this.q_text.Location = new System.Drawing.Point(43, 80);
            this.q_text.Name = "q_text";
            this.q_text.ReadOnly = true;
            this.q_text.Size = new System.Drawing.Size(297, 20);
            this.q_text.TabIndex = 1;
            this.q_text.TextChanged += new System.EventHandler(this.q_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "d";
            // 
            // n_text
            // 
            this.n_text.Location = new System.Drawing.Point(43, 395);
            this.n_text.Name = "n_text";
            this.n_text.ReadOnly = true;
            this.n_text.Size = new System.Drawing.Size(297, 20);
            this.n_text.TabIndex = 5;
            this.n_text.TextChanged += new System.EventHandler(this.n_text_TextChanged);
            // 
            // d_text
            // 
            this.d_text.Location = new System.Drawing.Point(43, 369);
            this.d_text.Name = "d_text";
            this.d_text.ReadOnly = true;
            this.d_text.Size = new System.Drawing.Size(297, 20);
            this.d_text.TabIndex = 4;
            this.d_text.TextChanged += new System.EventHandler(this.d_text_TextChanged);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(43, 132);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(105, 23);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Генерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(43, 421);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(105, 23);
            this.Decrypt.TabIndex = 9;
            this.Decrypt.Text = "Расшифровать";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // IN
            // 
            this.IN.Location = new System.Drawing.Point(366, 30);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(341, 149);
            this.IN.TabIndex = 10;
            this.IN.Text = "";
            // 
            // OUT
            // 
            this.OUT.Location = new System.Drawing.Point(366, 338);
            this.OUT.Name = "OUT";
            this.OUT.ReadOnly = true;
            this.OUT.Size = new System.Drawing.Size(341, 149);
            this.OUT.TabIndex = 11;
            this.OUT.Text = "";
            // 
            // Crypted
            // 
            this.Crypted.Location = new System.Drawing.Point(19, 183);
            this.Crypted.Name = "Crypted";
            this.Crypted.Size = new System.Drawing.Size(688, 149);
            this.Crypted.TabIndex = 12;
            this.Crypted.Text = "";
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(235, 132);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(105, 23);
            this.Encrypt.TabIndex = 13;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(265, 156);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // e_text
            // 
            this.e_text.Location = new System.Drawing.Point(43, 106);
            this.e_text.Name = "e_text";
            this.e_text.ReadOnly = true;
            this.e_text.Size = new System.Drawing.Size(297, 20);
            this.e_text.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "e";
            // 
            // bits
            // 
            this.bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bits.Location = new System.Drawing.Point(43, 26);
            this.bits.MaxLength = 4;
            this.bits.Name = "bits";
            this.bits.Size = new System.Drawing.Size(52, 22);
            this.bits.TabIndex = 17;
            this.bits.Text = "512";
            this.bits.TextChanged += new System.EventHandler(this.bits_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 499);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.e_text);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.Crypted);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.IN);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_text);
            this.Controls.Add(this.d_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.q_text);
            this.Controls.Add(this.p_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p_text;
        private System.Windows.Forms.TextBox q_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox n_text;
        private System.Windows.Forms.TextBox d_text;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.RichTextBox IN;
        private System.Windows.Forms.RichTextBox OUT;
        private System.Windows.Forms.RichTextBox Crypted;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox e_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bits;
        private System.Windows.Forms.Label label6;
    }
}

