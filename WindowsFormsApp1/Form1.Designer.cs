namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.txtWiek = new System.Windows.Forms.TextBox();
            this.radioK = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.txtPPM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.mt_fuji_sakura;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(74, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "kg";
            // 
            // txtWzrost
            // 
            this.txtWzrost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWzrost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWzrost.Location = new System.Drawing.Point(12, 86);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(55, 20);
            this.txtWzrost.TabIndex = 3;
            this.txtWzrost.Text = "Wzrost";
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(12, 122);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(55, 20);
            this.txtWaga.TabIndex = 4;
            this.txtWaga.Text = "Waga";
            // 
            // txtWiek
            // 
            this.txtWiek.Location = new System.Drawing.Point(12, 159);
            this.txtWiek.Name = "txtWiek";
            this.txtWiek.Size = new System.Drawing.Size(55, 20);
            this.txtWiek.TabIndex = 5;
            this.txtWiek.Text = "Wiek";
            // 
            // radioK
            // 
            this.radioK.AutoSize = true;
            this.radioK.BackColor = System.Drawing.SystemColors.Control;
            this.radioK.Location = new System.Drawing.Point(13, 13);
            this.radioK.Name = "radioK";
            this.radioK.Size = new System.Drawing.Size(61, 17);
            this.radioK.TabIndex = 6;
            this.radioK.TabStop = true;
            this.radioK.Text = "Kobieta";
            this.radioK.UseVisualStyleBackColor = false;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.BackColor = System.Drawing.SystemColors.Control;
            this.radioM.Location = new System.Drawing.Point(12, 37);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(78, 17);
            this.radioM.TabIndex = 7;
            this.radioM.TabStop = true;
            this.radioM.Text = "Mężczyzna";
            this.radioM.UseVisualStyleBackColor = false;
            // 
            // txtPPM
            // 
            this.txtPPM.Location = new System.Drawing.Point(12, 270);
            this.txtPPM.Name = "txtPPM";
            this.txtPPM.Size = new System.Drawing.Size(62, 20);
            this.txtPPM.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "PPM";
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(12, 186);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 10;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPM";
            // 
            // txtCPM
            // 
            this.txtCPM.Location = new System.Drawing.Point(12, 337);
            this.txtCPM.Name = "txtCPM";
            this.txtCPM.Size = new System.Drawing.Size(108, 20);
            this.txtCPM.TabIndex = 12;
            this.txtCPM.Text = "Wybierz aktywność";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Aktywność fizyczna\r\n";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Nie trenuję";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(172, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "1-3 razy w tyg.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(172, 121);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(94, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "3-5 razy w tyg.";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(172, 159);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(94, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "5-7 razy w tyg.";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(172, 192);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(120, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Trenuję wyczynowo";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(80, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "kcal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(126, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "kcal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCPM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPPM);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.radioK);
            this.Controls.Add(this.txtWiek);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "KalkulatorCPM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.TextBox txtWiek;
        private System.Windows.Forms.RadioButton radioK;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.TextBox txtPPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

