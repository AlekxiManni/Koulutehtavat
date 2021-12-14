
namespace MatikkapeliWinforms
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
            this.helppo = new System.Windows.Forms.Button();
            this.keskivaikea = new System.Windows.Forms.Button();
            this.vaikea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helppo
            // 
            this.helppo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helppo.Location = new System.Drawing.Point(12, 110);
            this.helppo.Name = "helppo";
            this.helppo.Size = new System.Drawing.Size(126, 53);
            this.helppo.TabIndex = 0;
            this.helppo.Text = "Helppo";
            this.helppo.UseVisualStyleBackColor = true;
            this.helppo.Click += new System.EventHandler(this.helppo_Click);
            // 
            // keskivaikea
            // 
            this.keskivaikea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keskivaikea.Location = new System.Drawing.Point(144, 110);
            this.keskivaikea.Name = "keskivaikea";
            this.keskivaikea.Size = new System.Drawing.Size(126, 53);
            this.keskivaikea.TabIndex = 1;
            this.keskivaikea.Text = "Keskivaikea";
            this.keskivaikea.UseVisualStyleBackColor = true;
            this.keskivaikea.Click += new System.EventHandler(this.keskivaikea_Click);
            // 
            // vaikea
            // 
            this.vaikea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vaikea.Location = new System.Drawing.Point(276, 110);
            this.vaikea.Name = "vaikea";
            this.vaikea.Size = new System.Drawing.Size(126, 53);
            this.vaikea.TabIndex = 2;
            this.vaikea.Text = "Vaikea";
            this.vaikea.UseVisualStyleBackColor = true;
            this.vaikea.Click += new System.EventHandler(this.vaikea_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valitse vaikeusaste";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pelaajan nimi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vaikea);
            this.Controls.Add(this.keskivaikea);
            this.Controls.Add(this.helppo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Matikkapeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helppo;
        private System.Windows.Forms.Button keskivaikea;
        private System.Windows.Forms.Button vaikea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

