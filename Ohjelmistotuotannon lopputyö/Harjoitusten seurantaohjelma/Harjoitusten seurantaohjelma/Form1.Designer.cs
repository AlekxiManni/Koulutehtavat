
namespace Harjoitusten_seurantaohjelma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.liike_textBox = new System.Windows.Forms.TextBox();
            this.sarjat_textBox = new System.Windows.Forms.TextBox();
            this.toistot_textBox = new System.Windows.Forms.TextBox();
            this.paino_textBox = new System.Windows.Forms.TextBox();
            this.lisaa_button = new System.Windows.Forms.Button();
            this.tallenna_button = new System.Windows.Forms.Button();
            this.poista_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sarjat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toistot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button_tulosarkisto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.poistuOhjelmastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liike_textBox
            // 
            this.liike_textBox.Location = new System.Drawing.Point(225, 56);
            this.liike_textBox.Name = "liike_textBox";
            this.liike_textBox.Size = new System.Drawing.Size(155, 20);
            this.liike_textBox.TabIndex = 2;
            // 
            // sarjat_textBox
            // 
            this.sarjat_textBox.Location = new System.Drawing.Point(386, 56);
            this.sarjat_textBox.Name = "sarjat_textBox";
            this.sarjat_textBox.Size = new System.Drawing.Size(59, 20);
            this.sarjat_textBox.TabIndex = 3;
            // 
            // toistot_textBox
            // 
            this.toistot_textBox.Location = new System.Drawing.Point(451, 56);
            this.toistot_textBox.Name = "toistot_textBox";
            this.toistot_textBox.Size = new System.Drawing.Size(58, 20);
            this.toistot_textBox.TabIndex = 4;
            // 
            // paino_textBox
            // 
            this.paino_textBox.Location = new System.Drawing.Point(515, 56);
            this.paino_textBox.Name = "paino_textBox";
            this.paino_textBox.Size = new System.Drawing.Size(58, 20);
            this.paino_textBox.TabIndex = 5;
            // 
            // lisaa_button
            // 
            this.lisaa_button.Location = new System.Drawing.Point(579, 54);
            this.lisaa_button.Name = "lisaa_button";
            this.lisaa_button.Size = new System.Drawing.Size(75, 23);
            this.lisaa_button.TabIndex = 6;
            this.lisaa_button.Text = "Lisää";
            this.lisaa_button.UseVisualStyleBackColor = true;
            this.lisaa_button.Click += new System.EventHandler(this.lisaa_button_Click);
            // 
            // tallenna_button
            // 
            this.tallenna_button.Location = new System.Drawing.Point(256, 240);
            this.tallenna_button.Name = "tallenna_button";
            this.tallenna_button.Size = new System.Drawing.Size(166, 44);
            this.tallenna_button.TabIndex = 8;
            this.tallenna_button.Text = "Tallenna";
            this.tallenna_button.UseVisualStyleBackColor = true;
            this.tallenna_button.Click += new System.EventHandler(this.tallenna_button_Click);
            // 
            // poista_button
            // 
            this.poista_button.Location = new System.Drawing.Point(565, 251);
            this.poista_button.Name = "poista_button";
            this.poista_button.Size = new System.Drawing.Size(75, 23);
            this.poista_button.TabIndex = 9;
            this.poista_button.Text = "Poista";
            this.poista_button.UseVisualStyleBackColor = true;
            this.poista_button.Click += new System.EventHandler(this.poista_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Treeniliike";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sarjat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Toistomäärä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sarjapaino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Päivämäärä";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.liike,
            this.sarjat,
            this.toistot,
            this.paino});
            this.dataGridView1.Location = new System.Drawing.Point(19, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 142);
            this.dataGridView1.TabIndex = 16;
            // 
            // date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.HeaderText = "Päivämäärä";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // liike
            // 
            this.liike.HeaderText = "Treeniliike";
            this.liike.Name = "liike";
            // 
            // sarjat
            // 
            this.sarjat.HeaderText = "Sarjat";
            this.sarjat.Name = "sarjat";
            // 
            // toistot
            // 
            this.toistot.HeaderText = "Toistomäärä";
            this.toistot.Name = "toistot";
            // 
            // paino
            // 
            this.paino.HeaderText = "Sarjapaino";
            this.paino.Name = "paino";
            this.paino.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Poista valittu rivi";
            // 
            // button_tulosarkisto
            // 
            this.button_tulosarkisto.Location = new System.Drawing.Point(256, 299);
            this.button_tulosarkisto.Name = "button_tulosarkisto";
            this.button_tulosarkisto.Size = new System.Drawing.Size(163, 44);
            this.button_tulosarkisto.TabIndex = 18;
            this.button_tulosarkisto.Text = "Siirry tulosarkistoon";
            this.button_tulosarkisto.UseVisualStyleBackColor = true;
            this.button_tulosarkisto.Click += new System.EventHandler(this.button_tulosarkisto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuOhjelmastaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // poistuOhjelmastaToolStripMenuItem
            // 
            this.poistuOhjelmastaToolStripMenuItem.Name = "poistuOhjelmastaToolStripMenuItem";
            this.poistuOhjelmastaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.poistuOhjelmastaToolStripMenuItem.Text = "Poistu ohjelmasta";
            this.poistuOhjelmastaToolStripMenuItem.Click += new System.EventHandler(this.poistuOhjelmastaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 418);
            this.Controls.Add(this.button_tulosarkisto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poista_button);
            this.Controls.Add(this.tallenna_button);
            this.Controls.Add(this.lisaa_button);
            this.Controls.Add(this.paino_textBox);
            this.Controls.Add(this.toistot_textBox);
            this.Controls.Add(this.sarjat_textBox);
            this.Controls.Add(this.liike_textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Treenipäiväkirja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox liike_textBox;
        private System.Windows.Forms.TextBox sarjat_textBox;
        private System.Windows.Forms.TextBox toistot_textBox;
        private System.Windows.Forms.TextBox paino_textBox;
        private System.Windows.Forms.Button lisaa_button;
        private System.Windows.Forms.Button tallenna_button;
        private System.Windows.Forms.Button poista_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_tulosarkisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn liike;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarjat;
        private System.Windows.Forms.DataGridViewTextBoxColumn toistot;
        private System.Windows.Forms.DataGridViewTextBoxColumn paino;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem poistuOhjelmastaToolStripMenuItem;
    }
}

