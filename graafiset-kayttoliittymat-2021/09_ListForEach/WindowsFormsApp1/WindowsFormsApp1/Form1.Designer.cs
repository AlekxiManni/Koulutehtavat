
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LuoLista_Button = new System.Windows.Forms.Button();
            this.Lisaa_Button = new System.Windows.Forms.Button();
            this.Haku_Button = new System.Windows.Forms.Button();
            this.Lisaa_TextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUODAAN string -TYYPPINEN LISTA";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISÄTÄÄN LISTAN MERKKIJONO";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "HAETAAN LISTAN SISÄLTÖ";
            // 
            // LuoLista_Button
            // 
            this.LuoLista_Button.Location = new System.Drawing.Point(139, 50);
            this.LuoLista_Button.Name = "LuoLista_Button";
            this.LuoLista_Button.Size = new System.Drawing.Size(122, 46);
            this.LuoLista_Button.TabIndex = 3;
            this.LuoLista_Button.Text = "Luo lista";
            this.LuoLista_Button.UseVisualStyleBackColor = true;
            this.LuoLista_Button.Click += new System.EventHandler(this.LuoLista_Button_Click);
            // 
            // Lisaa_Button
            // 
            this.Lisaa_Button.Location = new System.Drawing.Point(276, 194);
            this.Lisaa_Button.Name = "Lisaa_Button";
            this.Lisaa_Button.Size = new System.Drawing.Size(122, 46);
            this.Lisaa_Button.TabIndex = 4;
            this.Lisaa_Button.Text = "Lisää";
            this.Lisaa_Button.UseVisualStyleBackColor = true;
            this.Lisaa_Button.Click += new System.EventHandler(this.Lisaa_Button_Click);
            // 
            // Haku_Button
            // 
            this.Haku_Button.Location = new System.Drawing.Point(276, 323);
            this.Haku_Button.Name = "Haku_Button";
            this.Haku_Button.Size = new System.Drawing.Size(122, 46);
            this.Haku_Button.TabIndex = 5;
            this.Haku_Button.Text = "Haku";
            this.Haku_Button.UseVisualStyleBackColor = true;
            this.Haku_Button.Click += new System.EventHandler(this.Haku_Button_Click);
            // 
            // Lisaa_TextBox
            // 
            this.Lisaa_TextBox.Location = new System.Drawing.Point(61, 208);
            this.Lisaa_TextBox.Name = "Lisaa_TextBox";
            this.Lisaa_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Lisaa_TextBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 418);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lisaa_TextBox);
            this.Controls.Add(this.Haku_Button);
            this.Controls.Add(this.Lisaa_Button);
            this.Controls.Add(this.LuoLista_Button);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LuoLista_Button;
        private System.Windows.Forms.Button Lisaa_Button;
        private System.Windows.Forms.Button Haku_Button;
        private System.Windows.Forms.TextBox Lisaa_TextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

