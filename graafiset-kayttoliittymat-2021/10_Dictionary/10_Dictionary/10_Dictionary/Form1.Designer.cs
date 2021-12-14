
namespace _10_Dictionary
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
            this.Luo_Dictionary_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Hae_Button = new System.Windows.Forms.Button();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.Value_textBox = new System.Windows.Forms.TextBox();
            this.hakuKey_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUODAAN Dictionary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISÄTÄÄN ELEMENTTEJÄ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HAETAAN ELEMENTTEJÄ";
            // 
            // Luo_Dictionary_button
            // 
            this.Luo_Dictionary_button.Location = new System.Drawing.Point(121, 56);
            this.Luo_Dictionary_button.Name = "Luo_Dictionary_button";
            this.Luo_Dictionary_button.Size = new System.Drawing.Size(102, 23);
            this.Luo_Dictionary_button.TabIndex = 3;
            this.Luo_Dictionary_button.Text = "Luo Dictionary";
            this.Luo_Dictionary_button.UseVisualStyleBackColor = true;
            this.Luo_Dictionary_button.Click += new System.EventHandler(this.Luo_Dictionary_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lisää";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hae_Button
            // 
            this.Hae_Button.Location = new System.Drawing.Point(269, 261);
            this.Hae_Button.Name = "Hae_Button";
            this.Hae_Button.Size = new System.Drawing.Size(75, 23);
            this.Hae_Button.TabIndex = 5;
            this.Hae_Button.Text = "Hae";
            this.Hae_Button.UseVisualStyleBackColor = true;
            this.Hae_Button.Click += new System.EventHandler(this.Hae_Button_Click);
            // 
            // Key_textBox
            // 
            this.Key_textBox.Location = new System.Drawing.Point(69, 136);
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(190, 20);
            this.Key_textBox.TabIndex = 6;
            // 
            // Value_textBox
            // 
            this.Value_textBox.Location = new System.Drawing.Point(69, 172);
            this.Value_textBox.Name = "Value_textBox";
            this.Value_textBox.Size = new System.Drawing.Size(190, 20);
            this.Value_textBox.TabIndex = 7;
            // 
            // hakuKey_textBox
            // 
            this.hakuKey_textBox.Location = new System.Drawing.Point(69, 261);
            this.hakuKey_textBox.Name = "hakuKey_textBox";
            this.hakuKey_textBox.Size = new System.Drawing.Size(190, 20);
            this.hakuKey_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ValueLabel.Location = new System.Drawing.Point(66, 304);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(23, 13);
            this.ValueLabel.TabIndex = 13;
            this.ValueLabel.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 341);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hakuKey_textBox);
            this.Controls.Add(this.Value_textBox);
            this.Controls.Add(this.Key_textBox);
            this.Controls.Add(this.Hae_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Luo_Dictionary_button);
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
        private System.Windows.Forms.Button Luo_Dictionary_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Hae_Button;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.TextBox Value_textBox;
        private System.Windows.Forms.TextBox hakuKey_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ValueLabel;
    }
}

