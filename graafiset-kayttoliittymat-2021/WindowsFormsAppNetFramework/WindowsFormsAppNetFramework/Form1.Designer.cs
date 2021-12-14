
namespace WindowsFormsAppNetFramework
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBoxToiminnallisuus = new System.Windows.Forms.GroupBox();
            this.buttonPoista = new System.Windows.Forms.Button();
            this.buttonTallenna = new System.Windows.Forms.Button();
            this.buttonUusitietue = new System.Windows.Forms.Button();
            this.groupBoxElokuvanTiedot = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxJulkaisuvuosi = new System.Windows.Forms.TextBox();
            this.textBoxNimi = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSeuraava = new System.Windows.Forms.Button();
            this.buttonEdellinen = new System.Windows.Forms.Button();
            this.groupBoxArvio = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxArvio = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxToiminnallisuus.SuspendLayout();
            this.groupBoxElokuvanTiedot.SuspendLayout();
            this.groupBoxArvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            this.tietojaToolStripMenuItem.Click += new System.EventHandler(this.tietojaToolStripMenuItem_Click);
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click_1);
            // 
            // groupBoxToiminnallisuus
            // 
            this.groupBoxToiminnallisuus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxToiminnallisuus.Controls.Add(this.buttonPoista);
            this.groupBoxToiminnallisuus.Controls.Add(this.buttonTallenna);
            this.groupBoxToiminnallisuus.Controls.Add(this.buttonUusitietue);
            this.groupBoxToiminnallisuus.Location = new System.Drawing.Point(453, 27);
            this.groupBoxToiminnallisuus.Name = "groupBoxToiminnallisuus";
            this.groupBoxToiminnallisuus.Size = new System.Drawing.Size(317, 529);
            this.groupBoxToiminnallisuus.TabIndex = 1;
            this.groupBoxToiminnallisuus.TabStop = false;
            this.groupBoxToiminnallisuus.Text = "Toiminnallisuus";
            // 
            // buttonPoista
            // 
            this.buttonPoista.BackColor = System.Drawing.Color.DarkRed;
            this.buttonPoista.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPoista.Location = new System.Drawing.Point(6, 172);
            this.buttonPoista.Name = "buttonPoista";
            this.buttonPoista.Size = new System.Drawing.Size(304, 65);
            this.buttonPoista.TabIndex = 4;
            this.buttonPoista.Text = "Poista";
            this.buttonPoista.UseVisualStyleBackColor = false;
            this.buttonPoista.Click += new System.EventHandler(this.buttonPoista_Click);
            // 
            // buttonTallenna
            // 
            this.buttonTallenna.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonTallenna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTallenna.Location = new System.Drawing.Point(6, 101);
            this.buttonTallenna.Name = "buttonTallenna";
            this.buttonTallenna.Size = new System.Drawing.Size(304, 65);
            this.buttonTallenna.TabIndex = 3;
            this.buttonTallenna.Text = "Tallenna";
            this.buttonTallenna.UseVisualStyleBackColor = false;
            this.buttonTallenna.Click += new System.EventHandler(this.buttonTallenna_Click);
            // 
            // buttonUusitietue
            // 
            this.buttonUusitietue.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonUusitietue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUusitietue.Location = new System.Drawing.Point(6, 30);
            this.buttonUusitietue.Name = "buttonUusitietue";
            this.buttonUusitietue.Size = new System.Drawing.Size(304, 65);
            this.buttonUusitietue.TabIndex = 2;
            this.buttonUusitietue.Text = "Uusi tietue";
            this.buttonUusitietue.UseVisualStyleBackColor = false;
            this.buttonUusitietue.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxElokuvanTiedot
            // 
            this.groupBoxElokuvanTiedot.Controls.Add(this.label4);
            this.groupBoxElokuvanTiedot.Controls.Add(this.label3);
            this.groupBoxElokuvanTiedot.Controls.Add(this.label2);
            this.groupBoxElokuvanTiedot.Controls.Add(this.label1);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxMin);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxJulkaisuvuosi);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxNimi);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxID);
            this.groupBoxElokuvanTiedot.Controls.Add(this.buttonSeuraava);
            this.groupBoxElokuvanTiedot.Controls.Add(this.buttonEdellinen);
            this.groupBoxElokuvanTiedot.Location = new System.Drawing.Point(12, 27);
            this.groupBoxElokuvanTiedot.Name = "groupBoxElokuvanTiedot";
            this.groupBoxElokuvanTiedot.Size = new System.Drawing.Size(436, 210);
            this.groupBoxElokuvanTiedot.TabIndex = 5;
            this.groupBoxElokuvanTiedot.TabStop = false;
            this.groupBoxElokuvanTiedot.Text = "Elokuvan tiedot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kesto (min):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Julkaisuvuosi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(88, 108);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(164, 20);
            this.textBoxMin.TabIndex = 9;
            this.textBoxMin.Click += new System.EventHandler(this.textBoxMin_Click);
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBoxMin.Leave += new System.EventHandler(this.textBoxMin_Leave);
            // 
            // textBoxJulkaisuvuosi
            // 
            this.textBoxJulkaisuvuosi.Location = new System.Drawing.Point(88, 82);
            this.textBoxJulkaisuvuosi.Name = "textBoxJulkaisuvuosi";
            this.textBoxJulkaisuvuosi.Size = new System.Drawing.Size(164, 20);
            this.textBoxJulkaisuvuosi.TabIndex = 8;
            this.textBoxJulkaisuvuosi.Click += new System.EventHandler(this.textBoxJulkaisuvuosi_Click);
            this.textBoxJulkaisuvuosi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBoxJulkaisuvuosi.Leave += new System.EventHandler(this.textBoxJulkaisuvuosi_Leave);
            // 
            // textBoxNimi
            // 
            this.textBoxNimi.Location = new System.Drawing.Point(88, 56);
            this.textBoxNimi.Name = "textBoxNimi";
            this.textBoxNimi.Size = new System.Drawing.Size(236, 20);
            this.textBoxNimi.TabIndex = 7;
            this.textBoxNimi.Click += new System.EventHandler(this.textBoxNimi_Click);
            this.textBoxNimi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxNimi.Leave += new System.EventHandler(this.textBoxNimi_Leave);
            // 
            // textBoxID
            // 
            this.textBoxID.AccessibleDescription = "";
            this.textBoxID.Location = new System.Drawing.Point(88, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(164, 20);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.Text = "0";
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSeuraava
            // 
            this.buttonSeuraava.Location = new System.Drawing.Point(242, 151);
            this.buttonSeuraava.Name = "buttonSeuraava";
            this.buttonSeuraava.Size = new System.Drawing.Size(169, 53);
            this.buttonSeuraava.TabIndex = 1;
            this.buttonSeuraava.Text = "Seuraava";
            this.buttonSeuraava.UseVisualStyleBackColor = true;
            // 
            // buttonEdellinen
            // 
            this.buttonEdellinen.Location = new System.Drawing.Point(22, 151);
            this.buttonEdellinen.Name = "buttonEdellinen";
            this.buttonEdellinen.Size = new System.Drawing.Size(169, 53);
            this.buttonEdellinen.TabIndex = 0;
            this.buttonEdellinen.Text = "Edellinen";
            this.buttonEdellinen.UseVisualStyleBackColor = true;
            // 
            // groupBoxArvio
            // 
            this.groupBoxArvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxArvio.Controls.Add(this.numericUpDown2);
            this.groupBoxArvio.Controls.Add(this.label6);
            this.groupBoxArvio.Controls.Add(this.numericUpDown1);
            this.groupBoxArvio.Controls.Add(this.label5);
            this.groupBoxArvio.Controls.Add(this.textBoxArvio);
            this.groupBoxArvio.Location = new System.Drawing.Point(12, 243);
            this.groupBoxArvio.Name = "groupBoxArvio";
            this.groupBoxArvio.Size = new System.Drawing.Size(436, 311);
            this.groupBoxArvio.TabIndex = 14;
            this.groupBoxArvio.TabStop = false;
            this.groupBoxArvio.Text = "Arvio";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown2.Location = new System.Drawing.Point(131, 285);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = ".";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(67, 285);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Arvosana:";
            // 
            // textBoxArvio
            // 
            this.textBoxArvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArvio.Location = new System.Drawing.Point(9, 14);
            this.textBoxArvio.Multiline = true;
            this.textBoxArvio.Name = "textBoxArvio";
            this.textBoxArvio.Size = new System.Drawing.Size(411, 261);
            this.textBoxArvio.TabIndex = 6;
            this.textBoxArvio.Click += new System.EventHandler(this.textBoxArvio_Click);
            this.textBoxArvio.Leave += new System.EventHandler(this.textBoxArvio_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 558);
            this.Controls.Add(this.groupBoxArvio);
            this.Controls.Add(this.groupBoxElokuvanTiedot);
            this.Controls.Add(this.groupBoxToiminnallisuus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Elokuvasovellus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxToiminnallisuus.ResumeLayout(false);
            this.groupBoxElokuvanTiedot.ResumeLayout(false);
            this.groupBoxElokuvanTiedot.PerformLayout();
            this.groupBoxArvio.ResumeLayout(false);
            this.groupBoxArvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBoxToiminnallisuus;
        private System.Windows.Forms.Button buttonUusitietue;
        private System.Windows.Forms.Button buttonPoista;
        private System.Windows.Forms.Button buttonTallenna;
        private System.Windows.Forms.GroupBox groupBoxElokuvanTiedot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxJulkaisuvuosi;
        private System.Windows.Forms.TextBox textBoxNimi;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonSeuraava;
        private System.Windows.Forms.Button buttonEdellinen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxArvio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxArvio;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

