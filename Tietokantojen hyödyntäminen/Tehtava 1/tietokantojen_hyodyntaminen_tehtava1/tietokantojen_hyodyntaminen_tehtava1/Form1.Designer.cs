
namespace tietokantojen_hyodyntaminen_tehtava1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpiskelijaIdTextBox = new System.Windows.Forms.TextBox();
            this.NimiTextBox = new System.Windows.Forms.TextBox();
            this.OpiskelijaryhmanIdTextBox = new System.Windows.Forms.TextBox();
            this.LisaaTiedotButton = new System.Windows.Forms.Button();
            this.opiskelijatDataSet = new tietokantojen_hyodyntaminen_tehtava1.OpiskelijatDataSet();
            this.nimiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nimiTableAdapter = new tietokantojen_hyodyntaminen_tehtava1.OpiskelijatDataSetTableAdapters.NimiTableAdapter();
            this.HaeButton = new System.Windows.Forms.Button();
            this.PoistaNimiButton = new System.Windows.Forms.Button();
            this.opiskelijatDataSet1 = new tietokantojen_hyodyntaminen_tehtava1.OpiskelijatDataSet1();
            this.opiskelijaryhmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opiskelijaryhmaTableAdapter = new tietokantojen_hyodyntaminen_tehtava1.OpiskelijatDataSet1TableAdapters.opiskelijaryhmaTableAdapter();
            this.HaeOpiskelijaRyhma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.opiskelijatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nimiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiskelijatDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiskelijaryhmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opiskelijan Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opiskelijan nimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opiskelijaryhmän Id:";
            // 
            // OpiskelijaIdTextBox
            // 
            this.OpiskelijaIdTextBox.Location = new System.Drawing.Point(119, 10);
            this.OpiskelijaIdTextBox.Name = "OpiskelijaIdTextBox";
            this.OpiskelijaIdTextBox.Size = new System.Drawing.Size(75, 20);
            this.OpiskelijaIdTextBox.TabIndex = 3;
            // 
            // NimiTextBox
            // 
            this.NimiTextBox.Location = new System.Drawing.Point(119, 36);
            this.NimiTextBox.Name = "NimiTextBox";
            this.NimiTextBox.Size = new System.Drawing.Size(259, 20);
            this.NimiTextBox.TabIndex = 4;
            // 
            // OpiskelijaryhmanIdTextBox
            // 
            this.OpiskelijaryhmanIdTextBox.Location = new System.Drawing.Point(119, 61);
            this.OpiskelijaryhmanIdTextBox.Name = "OpiskelijaryhmanIdTextBox";
            this.OpiskelijaryhmanIdTextBox.Size = new System.Drawing.Size(75, 20);
            this.OpiskelijaryhmanIdTextBox.TabIndex = 5;
            // 
            // LisaaTiedotButton
            // 
            this.LisaaTiedotButton.Location = new System.Drawing.Point(220, 59);
            this.LisaaTiedotButton.Name = "LisaaTiedotButton";
            this.LisaaTiedotButton.Size = new System.Drawing.Size(75, 23);
            this.LisaaTiedotButton.TabIndex = 6;
            this.LisaaTiedotButton.Text = "Lisää tiedot";
            this.LisaaTiedotButton.UseVisualStyleBackColor = true;
            this.LisaaTiedotButton.Click += new System.EventHandler(this.LisaaTiedotButton_Click);
            // 
            // opiskelijatDataSet
            // 
            this.opiskelijatDataSet.DataSetName = "OpiskelijatDataSet";
            this.opiskelijatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nimiBindingSource
            // 
            this.nimiBindingSource.DataMember = "Nimi";
            this.nimiBindingSource.DataSource = this.opiskelijatDataSet;
            // 
            // nimiTableAdapter
            // 
            this.nimiTableAdapter.ClearBeforeFill = true;
            // 
            // HaeButton
            // 
            this.HaeButton.Location = new System.Drawing.Point(452, 101);
            this.HaeButton.Name = "HaeButton";
            this.HaeButton.Size = new System.Drawing.Size(91, 50);
            this.HaeButton.TabIndex = 8;
            this.HaeButton.Text = "Hae opiskelijoiden nimet";
            this.HaeButton.UseVisualStyleBackColor = true;
            this.HaeButton.Click += new System.EventHandler(this.HaeTiedotButton_Click);
            // 
            // PoistaNimiButton
            // 
            this.PoistaNimiButton.BackColor = System.Drawing.Color.LightCoral;
            this.PoistaNimiButton.Location = new System.Drawing.Point(452, 157);
            this.PoistaNimiButton.Name = "PoistaNimiButton";
            this.PoistaNimiButton.Size = new System.Drawing.Size(91, 47);
            this.PoistaNimiButton.TabIndex = 9;
            this.PoistaNimiButton.Text = "Poista tietue";
            this.PoistaNimiButton.UseVisualStyleBackColor = false;
            this.PoistaNimiButton.Click += new System.EventHandler(this.PoistaNimiButton_Click);
            // 
            // opiskelijatDataSet1
            // 
            this.opiskelijatDataSet1.DataSetName = "OpiskelijatDataSet1";
            this.opiskelijatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opiskelijaryhmaBindingSource
            // 
            this.opiskelijaryhmaBindingSource.DataMember = "opiskelijaryhma";
            this.opiskelijaryhmaBindingSource.DataSource = this.opiskelijatDataSet1;
            // 
            // opiskelijaryhmaTableAdapter
            // 
            this.opiskelijaryhmaTableAdapter.ClearBeforeFill = true;
            // 
            // HaeOpiskelijaRyhma
            // 
            this.HaeOpiskelijaRyhma.Location = new System.Drawing.Point(452, 268);
            this.HaeOpiskelijaRyhma.Name = "HaeOpiskelijaRyhma";
            this.HaeOpiskelijaRyhma.Size = new System.Drawing.Size(98, 56);
            this.HaeOpiskelijaRyhma.TabIndex = 11;
            this.HaeOpiskelijaRyhma.Text = "Hae Opiskelijaryhmät";
            this.HaeOpiskelijaRyhma.UseVisualStyleBackColor = true;
            this.HaeOpiskelijaRyhma.Click += new System.EventHandler(this.HaeOpiskelijaryhmaButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 149);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 268);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(431, 149);
            this.dataGridView2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 518);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HaeOpiskelijaRyhma);
            this.Controls.Add(this.PoistaNimiButton);
            this.Controls.Add(this.HaeButton);
            this.Controls.Add(this.LisaaTiedotButton);
            this.Controls.Add(this.OpiskelijaryhmanIdTextBox);
            this.Controls.Add(this.NimiTextBox);
            this.Controls.Add(this.OpiskelijaIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opiskelijatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nimiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiskelijatDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiskelijaryhmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OpiskelijaIdTextBox;
        private System.Windows.Forms.TextBox NimiTextBox;
        private System.Windows.Forms.TextBox OpiskelijaryhmanIdTextBox;
        private System.Windows.Forms.Button LisaaTiedotButton;
        private OpiskelijatDataSet opiskelijatDataSet;
        private System.Windows.Forms.BindingSource nimiBindingSource;
        private OpiskelijatDataSetTableAdapters.NimiTableAdapter nimiTableAdapter;
        private System.Windows.Forms.Button HaeButton;
        private System.Windows.Forms.Button PoistaNimiButton;
        private OpiskelijatDataSet1 opiskelijatDataSet1;
        private System.Windows.Forms.BindingSource opiskelijaryhmaBindingSource;
        private OpiskelijatDataSet1TableAdapters.opiskelijaryhmaTableAdapter opiskelijaryhmaTableAdapter;
        private System.Windows.Forms.Button HaeOpiskelijaRyhma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

