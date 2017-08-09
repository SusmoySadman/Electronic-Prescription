namespace Electronic_Prescription
{
    partial class Medicine_form
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
            this.textBox1_auto_text_fill = new System.Windows.Forms.TextBox();
            this.textBox2_medicine_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1_quantity = new System.Windows.Forms.ComboBox();
            this.comboBox2_times_per_day = new System.Windows.Forms.ComboBox();
            this.button1_add_medicine = new System.Windows.Forms.Button();
            this.button1_insert = new System.Windows.Forms.Button();
            this.comboBox1_visit_id = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1_medicine = new System.Windows.Forms.DataGridView();
            this.button1_delete = new System.Windows.Forms.Button();
            this.button2_update = new System.Windows.Forms.Button();
            this.button3_refresh = new System.Windows.Forms.Button();
            this.button1_back_to_form1 = new System.Windows.Forms.Button();
            this.button_get_patient_name = new System.Windows.Forms.Button();
            this.textBox1_get_patient_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_medicine)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_auto_text_fill
            // 
            this.textBox1_auto_text_fill.AutoCompleteCustomSource.AddRange(new string[] {
            "Abecab",
            "Napa Extra",
            "Alatrol",
            "Synagis",
            "Zyvox",
            "Bystolic",
            "Sandostatin LAR\t",
            "Complera\t",
            "Benicar HCT\t",
            "Treanda\t",
            "Gardasil\t",
            "Zostavax\t",
            "Pristiq\t",
            "Erbitux\t",
            "Focalin XR\t",
            "Tarceva\t",
            "Cubicin\t",
            "Strattera\t",
            "Latuda\t",
            "Velcade\t",
            "Viread\t",
            "Welchol\t",
            "Nuvaring\t",
            "Sprycel"});
            this.textBox1_auto_text_fill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1_auto_text_fill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1_auto_text_fill.Location = new System.Drawing.Point(118, 34);
            this.textBox1_auto_text_fill.Name = "textBox1_auto_text_fill";
            this.textBox1_auto_text_fill.Size = new System.Drawing.Size(166, 20);
            this.textBox1_auto_text_fill.TabIndex = 0;
            this.textBox1_auto_text_fill.TextChanged += new System.EventHandler(this.textBox1_auto_text_fill_TextChanged);
            // 
            // textBox2_medicine_name
            // 
            this.textBox2_medicine_name.Location = new System.Drawing.Point(118, 99);
            this.textBox2_medicine_name.Name = "textBox2_medicine_name";
            this.textBox2_medicine_name.Size = new System.Drawing.Size(166, 20);
            this.textBox2_medicine_name.TabIndex = 1;
            this.textBox2_medicine_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Medicine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medicine Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Times a Day";
            // 
            // comboBox1_quantity
            // 
            this.comboBox1_quantity.FormattingEnabled = true;
            this.comboBox1_quantity.Items.AddRange(new object[] {
            "1 Piece",
            "2 Piece",
            "3 Piece",
            "4 Piece",
            "5 Piece",
            "6 Piece",
            "7 Piece",
            "8 Piece",
            "9 Piece",
            "10 Piece",
            "1 packet",
            "2 packet",
            "3 packet"});
            this.comboBox1_quantity.Location = new System.Drawing.Point(118, 136);
            this.comboBox1_quantity.Name = "comboBox1_quantity";
            this.comboBox1_quantity.Size = new System.Drawing.Size(166, 21);
            this.comboBox1_quantity.TabIndex = 8;
            this.comboBox1_quantity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2_times_per_day
            // 
            this.comboBox2_times_per_day.FormattingEnabled = true;
            this.comboBox2_times_per_day.Items.AddRange(new object[] {
            "1+1+1",
            "1+1+0",
            "0+0+1",
            "1+0+1",
            "0+1+1",
            "1+0+0",
            "0+1+0"});
            this.comboBox2_times_per_day.Location = new System.Drawing.Point(118, 175);
            this.comboBox2_times_per_day.Name = "comboBox2_times_per_day";
            this.comboBox2_times_per_day.Size = new System.Drawing.Size(166, 21);
            this.comboBox2_times_per_day.TabIndex = 9;
            this.comboBox2_times_per_day.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1_add_medicine
            // 
            this.button1_add_medicine.Location = new System.Drawing.Point(118, 60);
            this.button1_add_medicine.Name = "button1_add_medicine";
            this.button1_add_medicine.Size = new System.Drawing.Size(75, 23);
            this.button1_add_medicine.TabIndex = 10;
            this.button1_add_medicine.Text = "Add Medicine";
            this.button1_add_medicine.UseVisualStyleBackColor = true;
            this.button1_add_medicine.Click += new System.EventHandler(this.button1_add_medicine_Click);
            // 
            // button1_insert
            // 
            this.button1_insert.Location = new System.Drawing.Point(307, 242);
            this.button1_insert.Name = "button1_insert";
            this.button1_insert.Size = new System.Drawing.Size(110, 46);
            this.button1_insert.TabIndex = 11;
            this.button1_insert.Text = "Add To List";
            this.button1_insert.UseVisualStyleBackColor = true;
            this.button1_insert.Click += new System.EventHandler(this.button1_insert_Click);
            // 
            // comboBox1_visit_id
            // 
            this.comboBox1_visit_id.FormattingEnabled = true;
            this.comboBox1_visit_id.Location = new System.Drawing.Point(118, 215);
            this.comboBox1_visit_id.Name = "comboBox1_visit_id";
            this.comboBox1_visit_id.Size = new System.Drawing.Size(166, 21);
            this.comboBox1_visit_id.TabIndex = 12;
            this.comboBox1_visit_id.SelectedIndexChanged += new System.EventHandler(this.comboBox1_visit_id_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Visit Id";
            // 
            // dataGridView1_medicine
            // 
            this.dataGridView1_medicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_medicine.Location = new System.Drawing.Point(307, 34);
            this.dataGridView1_medicine.Name = "dataGridView1_medicine";
            this.dataGridView1_medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_medicine.Size = new System.Drawing.Size(490, 202);
            this.dataGridView1_medicine.TabIndex = 14;
            this.dataGridView1_medicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_medicine_CellClick);
            this.dataGridView1_medicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_medicine_CellContentClick);
            // 
            // button1_delete
            // 
            this.button1_delete.Location = new System.Drawing.Point(165, 336);
            this.button1_delete.Name = "button1_delete";
            this.button1_delete.Size = new System.Drawing.Size(81, 23);
            this.button1_delete.TabIndex = 15;
            this.button1_delete.Text = "Delete";
            this.button1_delete.UseVisualStyleBackColor = true;
            this.button1_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_update
            // 
            this.button2_update.Location = new System.Drawing.Point(89, 336);
            this.button2_update.Name = "button2_update";
            this.button2_update.Size = new System.Drawing.Size(70, 23);
            this.button2_update.TabIndex = 16;
            this.button2_update.Text = "Update";
            this.button2_update.UseVisualStyleBackColor = true;
            this.button2_update.Click += new System.EventHandler(this.button2_update_Click);
            // 
            // button3_refresh
            // 
            this.button3_refresh.Location = new System.Drawing.Point(14, 336);
            this.button3_refresh.Name = "button3_refresh";
            this.button3_refresh.Size = new System.Drawing.Size(69, 23);
            this.button3_refresh.TabIndex = 17;
            this.button3_refresh.Text = "Refresh";
            this.button3_refresh.UseVisualStyleBackColor = true;
            this.button3_refresh.Click += new System.EventHandler(this.button3_refresh_Click);
            // 
            // button1_back_to_form1
            // 
            this.button1_back_to_form1.Location = new System.Drawing.Point(563, 336);
            this.button1_back_to_form1.Name = "button1_back_to_form1";
            this.button1_back_to_form1.Size = new System.Drawing.Size(75, 23);
            this.button1_back_to_form1.TabIndex = 18;
            this.button1_back_to_form1.Text = "Back To ";
            this.button1_back_to_form1.UseVisualStyleBackColor = true;
            this.button1_back_to_form1.Click += new System.EventHandler(this.button1_back_to_form1_Click);
            // 
            // button_get_patient_name
            // 
            this.button_get_patient_name.Location = new System.Drawing.Point(118, 243);
            this.button_get_patient_name.Name = "button_get_patient_name";
            this.button_get_patient_name.Size = new System.Drawing.Size(166, 23);
            this.button_get_patient_name.TabIndex = 19;
            this.button_get_patient_name.Text = "Get Patient Name";
            this.button_get_patient_name.UseVisualStyleBackColor = true;
            this.button_get_patient_name.Click += new System.EventHandler(this.button_get_patient_name_Click);
            // 
            // textBox1_get_patient_name
            // 
            this.textBox1_get_patient_name.Location = new System.Drawing.Point(118, 273);
            this.textBox1_get_patient_name.Name = "textBox1_get_patient_name";
            this.textBox1_get_patient_name.Size = new System.Drawing.Size(166, 20);
            this.textBox1_get_patient_name.TabIndex = 20;
            this.textBox1_get_patient_name.TextChanged += new System.EventHandler(this.textBox1_get_patient_name_TextChanged);
            // 
            // Medicine_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 371);
            this.Controls.Add(this.textBox1_get_patient_name);
            this.Controls.Add(this.button_get_patient_name);
            this.Controls.Add(this.button1_back_to_form1);
            this.Controls.Add(this.button3_refresh);
            this.Controls.Add(this.button2_update);
            this.Controls.Add(this.button1_delete);
            this.Controls.Add(this.dataGridView1_medicine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1_visit_id);
            this.Controls.Add(this.button1_insert);
            this.Controls.Add(this.button1_add_medicine);
            this.Controls.Add(this.comboBox2_times_per_day);
            this.Controls.Add(this.comboBox1_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_medicine_name);
            this.Controls.Add(this.textBox1_auto_text_fill);
            this.Name = "Medicine_form";
            this.Text = "Medicine_form";
            this.Load += new System.EventHandler(this.Medicine_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_medicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_auto_text_fill;
        private System.Windows.Forms.TextBox textBox2_medicine_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1_quantity;
        private System.Windows.Forms.ComboBox comboBox2_times_per_day;
        private System.Windows.Forms.Button button1_add_medicine;
        private System.Windows.Forms.Button button1_insert;
        private System.Windows.Forms.ComboBox comboBox1_visit_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1_medicine;
        private System.Windows.Forms.Button button1_delete;
        private System.Windows.Forms.Button button2_update;
        private System.Windows.Forms.Button button3_refresh;
        private System.Windows.Forms.Button button1_back_to_form1;
        private System.Windows.Forms.Button button_get_patient_name;
        private System.Windows.Forms.TextBox textBox1_get_patient_name;
    }
}