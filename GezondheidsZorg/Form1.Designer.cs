﻿namespace GezondheidsZorg
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.box_Filter = new System.Windows.Forms.TextBox();
            this.verwijderRow = new System.Windows.Forms.Button();
            this.Btn_contract = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.klntvoornaam = new System.Windows.Forms.TextBox();
            this.klntachternaam = new System.Windows.Forms.TextBox();
            this.klntAdd = new System.Windows.Forms.Button();
            this.artsvoornaam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.artsachternaam = new System.Windows.Forms.TextBox();
            this.artsAdd = new System.Windows.Forms.Button();
            this.soortMed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.klntadres = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.klntpostcode = new System.Windows.Forms.TextBox();
            this.artspostcode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.artsAdres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.artsComboBox = new System.Windows.Forms.ComboBox();
            this.Btn_filter = new System.Windows.Forms.Button();
            this.Dropdown = new System.Windows.Forms.ComboBox();
            this.einddatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.klntVerz = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(274, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoeken naar:";
            // 
            // box_Filter
            // 
            this.box_Filter.Location = new System.Drawing.Point(229, 148);
            this.box_Filter.Name = "box_Filter";
            this.box_Filter.Size = new System.Drawing.Size(100, 20);
            this.box_Filter.TabIndex = 4;
            // 
            // verwijderRow
            // 
            this.verwijderRow.Location = new System.Drawing.Point(12, 203);
            this.verwijderRow.Name = "verwijderRow";
            this.verwijderRow.Size = new System.Drawing.Size(75, 23);
            this.verwijderRow.TabIndex = 6;
            this.verwijderRow.Text = "Verwijder";
            this.verwijderRow.UseVisualStyleBackColor = true;
            this.verwijderRow.Click += new System.EventHandler(this.verwijderRow_Click);
            // 
            // Btn_contract
            // 
            this.Btn_contract.Location = new System.Drawing.Point(12, 174);
            this.Btn_contract.Name = "Btn_contract";
            this.Btn_contract.Size = new System.Drawing.Size(118, 23);
            this.Btn_contract.TabIndex = 7;
            this.Btn_contract.Text = "Verleng Contract";
            this.Btn_contract.UseVisualStyleBackColor = true;
            this.Btn_contract.Click += new System.EventHandler(this.Btn_contract_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Arts: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Verzekering: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Voornaam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Achternaam:";
            // 
            // klntvoornaam
            // 
            this.klntvoornaam.Location = new System.Drawing.Point(278, 289);
            this.klntvoornaam.Name = "klntvoornaam";
            this.klntvoornaam.Size = new System.Drawing.Size(100, 20);
            this.klntvoornaam.TabIndex = 18;
            // 
            // klntachternaam
            // 
            this.klntachternaam.Location = new System.Drawing.Point(278, 315);
            this.klntachternaam.Name = "klntachternaam";
            this.klntachternaam.Size = new System.Drawing.Size(100, 20);
            this.klntachternaam.TabIndex = 19;
            // 
            // klntAdd
            // 
            this.klntAdd.Location = new System.Drawing.Point(278, 455);
            this.klntAdd.Name = "klntAdd";
            this.klntAdd.Size = new System.Drawing.Size(102, 23);
            this.klntAdd.TabIndex = 20;
            this.klntAdd.Text = "Klant toevoegen";
            this.klntAdd.UseVisualStyleBackColor = true;
            this.klntAdd.Click += new System.EventHandler(this.klntAdd_Click);
            // 
            // artsvoornaam
            // 
            this.artsvoornaam.Location = new System.Drawing.Point(87, 260);
            this.artsvoornaam.Name = "artsvoornaam";
            this.artsvoornaam.Size = new System.Drawing.Size(100, 20);
            this.artsvoornaam.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Voornaam:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Achternaam:";
            // 
            // artsachternaam
            // 
            this.artsachternaam.Location = new System.Drawing.Point(87, 286);
            this.artsachternaam.Name = "artsachternaam";
            this.artsachternaam.Size = new System.Drawing.Size(100, 20);
            this.artsachternaam.TabIndex = 24;
            // 
            // artsAdd
            // 
            this.artsAdd.Location = new System.Drawing.Point(85, 398);
            this.artsAdd.Name = "artsAdd";
            this.artsAdd.Size = new System.Drawing.Size(102, 23);
            this.artsAdd.TabIndex = 25;
            this.artsAdd.Text = "Arts toevoegen";
            this.artsAdd.UseVisualStyleBackColor = true;
            this.artsAdd.Click += new System.EventHandler(this.artsAdd_Click);
            // 
            // soortMed
            // 
            this.soortMed.Location = new System.Drawing.Point(278, 393);
            this.soortMed.Name = "soortMed";
            this.soortMed.Size = new System.Drawing.Size(100, 20);
            this.soortMed.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Medicatie";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Adres: ";
            // 
            // klntadres
            // 
            this.klntadres.Location = new System.Drawing.Point(278, 341);
            this.klntadres.Name = "klntadres";
            this.klntadres.Size = new System.Drawing.Size(100, 20);
            this.klntadres.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(214, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Postcode: ";
            // 
            // klntpostcode
            // 
            this.klntpostcode.Location = new System.Drawing.Point(278, 367);
            this.klntpostcode.Name = "klntpostcode";
            this.klntpostcode.Size = new System.Drawing.Size(100, 20);
            this.klntpostcode.TabIndex = 38;
            // 
            // artspostcode
            // 
            this.artspostcode.Location = new System.Drawing.Point(87, 337);
            this.artspostcode.Name = "artspostcode";
            this.artspostcode.Size = new System.Drawing.Size(100, 20);
            this.artspostcode.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Postcode: ";
            // 
            // artsAdres
            // 
            this.artsAdres.Location = new System.Drawing.Point(87, 312);
            this.artsAdres.Name = "artsAdres";
            this.artsAdres.Size = new System.Drawing.Size(100, 20);
            this.artsAdres.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Adres: ";
            // 
            // artsComboBox
            // 
            this.artsComboBox.DisplayMember = "ArtsID";
            this.artsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.artsComboBox.FormattingEnabled = true;
            this.artsComboBox.Location = new System.Drawing.Point(278, 259);
            this.artsComboBox.Name = "artsComboBox";
            this.artsComboBox.Size = new System.Drawing.Size(121, 21);
            this.artsComboBox.TabIndex = 44;
            this.artsComboBox.Tag = "";
            this.artsComboBox.ValueMember = "ArtsID";
            // 
            // Btn_filter
            // 
            this.Btn_filter.Location = new System.Drawing.Point(335, 147);
            this.Btn_filter.Name = "Btn_filter";
            this.Btn_filter.Size = new System.Drawing.Size(64, 23);
            this.Btn_filter.TabIndex = 47;
            this.Btn_filter.Text = "Filter";
            this.Btn_filter.UseVisualStyleBackColor = true;
            this.Btn_filter.Click += new System.EventHandler(this.Btn_filter_Click);
            // 
            // Dropdown
            // 
            this.Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown.FormattingEnabled = true;
            this.Dropdown.Items.AddRange(new object[] {
            "Arts",
            "Klant"});
            this.Dropdown.Location = new System.Drawing.Point(87, 147);
            this.Dropdown.Name = "Dropdown";
            this.Dropdown.Size = new System.Drawing.Size(121, 21);
            this.Dropdown.TabIndex = 43;
            // 
            // einddatum
            // 
            this.einddatum.Location = new System.Drawing.Point(87, 365);
            this.einddatum.Name = "einddatum";
            this.einddatum.Size = new System.Drawing.Size(100, 20);
            this.einddatum.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Einddatum";
            // 
            // klntVerz
            // 
            this.klntVerz.Location = new System.Drawing.Point(278, 419);
            this.klntVerz.Name = "klntVerz";
            this.klntVerz.Size = new System.Drawing.Size(100, 20);
            this.klntVerz.TabIndex = 50;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(308, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(292, 131);
            this.dataGridView2.TabIndex = 51;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(405, 259);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(195, 125);
            this.dataGridView3.TabIndex = 52;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(430, 146);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 53;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 603);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.klntVerz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.einddatum);
            this.Controls.Add(this.Btn_filter);
            this.Controls.Add(this.artsComboBox);
            this.Controls.Add(this.Dropdown);
            this.Controls.Add(this.artspostcode);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.artsAdres);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.klntpostcode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.klntadres);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.soortMed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.artsAdd);
            this.Controls.Add(this.artsachternaam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.artsvoornaam);
            this.Controls.Add(this.klntAdd);
            this.Controls.Add(this.klntachternaam);
            this.Controls.Add(this.klntvoornaam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_contract);
            this.Controls.Add(this.verwijderRow);
            this.Controls.Add(this.box_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_Filter;
        private System.Windows.Forms.Button verwijderRow;
        private System.Windows.Forms.Button Btn_contract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox klntvoornaam;
        private System.Windows.Forms.TextBox klntachternaam;
        private System.Windows.Forms.Button klntAdd;
        private System.Windows.Forms.TextBox artsvoornaam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox artsachternaam;
        private System.Windows.Forms.Button artsAdd;
        private System.Windows.Forms.TextBox soortMed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox klntadres;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox klntpostcode;
        private System.Windows.Forms.TextBox artspostcode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox artsAdres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox artsComboBox;
        private System.Windows.Forms.Button Btn_filter;
        private System.Windows.Forms.ComboBox Dropdown;
        private System.Windows.Forms.TextBox einddatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox klntVerz;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnPrint;
    }
}

