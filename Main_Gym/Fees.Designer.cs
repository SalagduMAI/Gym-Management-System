namespace Main_Gym
{
    partial class Fees
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_feeid = new System.Windows.Forms.TextBox();
            this.comboBox_fee = new System.Windows.Forms.ComboBox();
            this.btn_fee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.comb_day = new System.Windows.Forms.ComboBox();
            this.comb_year = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_feeid
            // 
            this.txt_feeid.Location = new System.Drawing.Point(118, 52);
            this.txt_feeid.Name = "txt_feeid";
            this.txt_feeid.Size = new System.Drawing.Size(201, 20);
            this.txt_feeid.TabIndex = 1;
            // 
            // comboBox_fee
            // 
            this.comboBox_fee.FormattingEnabled = true;
            this.comboBox_fee.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox_fee.Location = new System.Drawing.Point(171, 102);
            this.comboBox_fee.Name = "comboBox_fee";
            this.comboBox_fee.Size = new System.Drawing.Size(95, 21);
            this.comboBox_fee.TabIndex = 2;
            this.comboBox_fee.Text = "Month";
            // 
            // btn_fee
            // 
            this.btn_fee.Location = new System.Drawing.Point(130, 143);
            this.btn_fee.Name = "btn_fee";
            this.btn_fee.Size = new System.Drawing.Size(75, 23);
            this.btn_fee.TabIndex = 0;
            this.btn_fee.Text = "Pay";
            this.btn_fee.UseVisualStyleBackColor = true;
            this.btn_fee.Click += new System.EventHandler(this.btn_fee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fee Month";
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(367, 52);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(240, 150);
            this.datagrid.TabIndex = 4;
            // 
            // comb_day
            // 
            this.comb_day.FormattingEnabled = true;
            this.comb_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comb_day.Location = new System.Drawing.Point(118, 102);
            this.comb_day.Name = "comb_day";
            this.comb_day.Size = new System.Drawing.Size(47, 21);
            this.comb_day.TabIndex = 6;
            this.comb_day.Text = "Day";
            // 
            // comb_year
            // 
            this.comb_year.FormattingEnabled = true;
            this.comb_year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comb_year.Location = new System.Drawing.Point(272, 102);
            this.comb_year.Name = "comb_year";
            this.comb_year.Size = new System.Drawing.Size(47, 21);
            this.comb_year.TabIndex = 7;
            this.comb_year.Text = "Year";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 397);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comb_year);
            this.Controls.Add(this.comb_day);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_fee);
            this.Controls.Add(this.txt_feeid);
            this.Controls.Add(this.btn_fee);
            this.Controls.Add(this.button1);
            this.Name = "Fees";
            this.Text = "Fees";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_feeid;
        private System.Windows.Forms.ComboBox comboBox_fee;
        private System.Windows.Forms.Button btn_fee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ComboBox comb_day;
        private System.Windows.Forms.ComboBox comb_year;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}