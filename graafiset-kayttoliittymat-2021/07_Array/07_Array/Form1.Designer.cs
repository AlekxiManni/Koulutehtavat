
namespace _07_Array
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
            this.Taulukon_koko_TextBox = new System.Windows.Forms.TextBox();
            this.Tallennettava_Numero_TextBox = new System.Windows.Forms.TextBox();
            this.Tallennuspaikan_Indeksi_TextBox = new System.Windows.Forms.TextBox();
            this.Tallennuspaikan_Indeksi_HAKU_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tulostus = new System.Windows.Forms.Label();
            this.Luo_Taulukko = new System.Windows.Forms.Button();
            this.Talleta = new System.Windows.Forms.Button();
            this.Hae = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Taulukon_koko_TextBox
            // 
            this.Taulukon_koko_TextBox.Location = new System.Drawing.Point(100, 60);
            this.Taulukon_koko_TextBox.Name = "Taulukon_koko_TextBox";
            this.Taulukon_koko_TextBox.Size = new System.Drawing.Size(61, 20);
            this.Taulukon_koko_TextBox.TabIndex = 0;
            // 
            // Tallennettava_Numero_TextBox
            // 
            this.Tallennettava_Numero_TextBox.Location = new System.Drawing.Point(140, 154);
            this.Tallennettava_Numero_TextBox.Name = "Tallennettava_Numero_TextBox";
            this.Tallennettava_Numero_TextBox.Size = new System.Drawing.Size(61, 20);
            this.Tallennettava_Numero_TextBox.TabIndex = 1;
            // 
            // Tallennuspaikan_Indeksi_TextBox
            // 
            this.Tallennuspaikan_Indeksi_TextBox.Location = new System.Drawing.Point(140, 180);
            this.Tallennuspaikan_Indeksi_TextBox.Name = "Tallennuspaikan_Indeksi_TextBox";
            this.Tallennuspaikan_Indeksi_TextBox.Size = new System.Drawing.Size(61, 20);
            this.Tallennuspaikan_Indeksi_TextBox.TabIndex = 2;
            // 
            // Tallennuspaikan_Indeksi_HAKU_TextBox
            // 
            this.Tallennuspaikan_Indeksi_HAKU_TextBox.Location = new System.Drawing.Point(140, 260);
            this.Tallennuspaikan_Indeksi_HAKU_TextBox.Name = "Tallennuspaikan_Indeksi_HAKU_TextBox";
            this.Tallennuspaikan_Indeksi_HAKU_TextBox.Size = new System.Drawing.Size(61, 20);
            this.Tallennuspaikan_Indeksi_HAKU_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Taulukon koko:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Talletettava numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tallennuspaikan indeksi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Talletuspaikan indeksi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TAULUKON LUONTI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TALLENNUS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "HAKU";
            // 
            // Tulostus
            // 
            this.Tulostus.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tulostus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tulostus.Location = new System.Drawing.Point(136, 302);
            this.Tulostus.Name = "Tulostus";
            this.Tulostus.Size = new System.Drawing.Size(71, 28);
            this.Tulostus.TabIndex = 11;
            this.Tulostus.Text = "0";
            this.Tulostus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Luo_Taulukko
            // 
            this.Luo_Taulukko.Location = new System.Drawing.Point(184, 58);
            this.Luo_Taulukko.Name = "Luo_Taulukko";
            this.Luo_Taulukko.Size = new System.Drawing.Size(88, 23);
            this.Luo_Taulukko.TabIndex = 12;
            this.Luo_Taulukko.Text = "Luo Taulukko";
            this.Luo_Taulukko.UseVisualStyleBackColor = true;
            this.Luo_Taulukko.Click += new System.EventHandler(this.Luo_Taulukko_Click);
            // 
            // Talleta
            // 
            this.Talleta.Location = new System.Drawing.Point(230, 176);
            this.Talleta.Name = "Talleta";
            this.Talleta.Size = new System.Drawing.Size(75, 23);
            this.Talleta.TabIndex = 13;
            this.Talleta.Text = "Talleta";
            this.Talleta.UseVisualStyleBackColor = true;
            this.Talleta.Click += new System.EventHandler(this.Talleta_Click);
            // 
            // Hae
            // 
            this.Hae.Location = new System.Drawing.Point(230, 256);
            this.Hae.Name = "Hae";
            this.Hae.Size = new System.Drawing.Size(75, 23);
            this.Hae.TabIndex = 14;
            this.Hae.Text = "Hae";
            this.Hae.UseVisualStyleBackColor = true;
            this.Hae.Click += new System.EventHandler(this.Hae_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 355);
            this.Controls.Add(this.Hae);
            this.Controls.Add(this.Talleta);
            this.Controls.Add(this.Luo_Taulukko);
            this.Controls.Add(this.Tulostus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tallennuspaikan_Indeksi_HAKU_TextBox);
            this.Controls.Add(this.Tallennuspaikan_Indeksi_TextBox);
            this.Controls.Add(this.Tallennettava_Numero_TextBox);
            this.Controls.Add(this.Taulukon_koko_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Taulukon_koko_TextBox;
        private System.Windows.Forms.TextBox Tallennettava_Numero_TextBox;
        private System.Windows.Forms.TextBox Tallennuspaikan_Indeksi_TextBox;
        private System.Windows.Forms.TextBox Tallennuspaikan_Indeksi_HAKU_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Tulostus;
        private System.Windows.Forms.Button Luo_Taulukko;
        private System.Windows.Forms.Button Talleta;
        private System.Windows.Forms.Button Hae;
    }
}

