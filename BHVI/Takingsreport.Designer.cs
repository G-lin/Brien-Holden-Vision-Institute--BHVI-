namespace BHVI
{
    partial class Takingsreport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.takingsreportgrid = new System.Windows.Forms.DataGridView();
            this.patcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstpayday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiptno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.ltotsa = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lpaynotype = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lpaynoamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lpaynodate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takingsreportgrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.takingsreportgrid);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label60);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 722);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Honeydew;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::BHVI.Properties.Resources.icons8_home_24;
            this.btnHome.Location = new System.Drawing.Point(1252, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 29);
            this.btnHome.TabIndex = 69;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // takingsreportgrid
            // 
            this.takingsreportgrid.BackgroundColor = System.Drawing.Color.Honeydew;
            this.takingsreportgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takingsreportgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patcode,
            this.Paydate,
            this.Name,
            this.Amount,
            this.Paytype,
            this.firstpayday,
            this.Receiptno});
            this.takingsreportgrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takingsreportgrid.Location = new System.Drawing.Point(64, 273);
            this.takingsreportgrid.Name = "takingsreportgrid";
            this.takingsreportgrid.RowHeadersWidth = 51;
            this.takingsreportgrid.RowTemplate.Height = 24;
            this.takingsreportgrid.Size = new System.Drawing.Size(1218, 409);
            this.takingsreportgrid.TabIndex = 48;
            this.takingsreportgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patcode
            // 
            this.patcode.Frozen = true;
            this.patcode.HeaderText = "Patient code";
            this.patcode.MinimumWidth = 6;
            this.patcode.Name = "patcode";
            this.patcode.Width = 125;
            // 
            // Paydate
            // 
            this.Paydate.Frozen = true;
            this.Paydate.HeaderText = "Payment date";
            this.Paydate.MinimumWidth = 6;
            this.Paydate.Name = "Paydate";
            this.Paydate.Width = 125;
            // 
            // Name
            // 
            this.Name.Frozen = true;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Amount
            // 
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Paytype
            // 
            this.Paytype.Frozen = true;
            this.Paytype.HeaderText = "Payment type";
            this.Paytype.MinimumWidth = 6;
            this.Paytype.Name = "Paytype";
            this.Paytype.Width = 125;
            // 
            // firstpayday
            // 
            this.firstpayday.Frozen = true;
            this.firstpayday.HeaderText = "First pay date";
            this.firstpayday.MinimumWidth = 6;
            this.firstpayday.Name = "firstpayday";
            this.firstpayday.Width = 125;
            // 
            // Receiptno
            // 
            this.Receiptno.Frozen = true;
            this.Receiptno.HeaderText = "Receipt number";
            this.Receiptno.MinimumWidth = 6;
            this.Receiptno.Name = "Receiptno";
            this.Receiptno.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.ltotsa);
            this.panel4.Location = new System.Drawing.Point(524, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 123);
            this.panel4.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(115, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 31);
            this.label23.TabIndex = 13;
            this.label23.Text = "Total";
            // 
            // ltotsa
            // 
            this.ltotsa.AutoSize = true;
            this.ltotsa.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ltotsa.Location = new System.Drawing.Point(114, 55);
            this.ltotsa.Name = "ltotsa";
            this.ltotsa.Size = new System.Drawing.Size(107, 41);
            this.ltotsa.TabIndex = 12;
            this.ltotsa.Text = "Lenses";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label60.Location = new System.Drawing.Point(927, 62);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(132, 20);
            this.label60.TabIndex = 46;
            this.label60.Text = "Error checking";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(612, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 34);
            this.textBox3.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(408, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Vision centre : ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lpaynotype);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lpaynoamount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lpaynodate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(923, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 129);
            this.panel2.TabIndex = 40;
            // 
            // lpaynotype
            // 
            this.lpaynotype.AutoSize = true;
            this.lpaynotype.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lpaynotype.Location = new System.Drawing.Point(272, 90);
            this.lpaynotype.Name = "lpaynotype";
            this.lpaynotype.Size = new System.Drawing.Size(68, 28);
            this.lpaynotype.TabIndex = 12;
            this.lpaynotype.Text = "Lenses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(19, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment type missing";
            // 
            // lpaynoamount
            // 
            this.lpaynoamount.AutoSize = true;
            this.lpaynoamount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lpaynoamount.Location = new System.Drawing.Point(272, 54);
            this.lpaynoamount.Name = "lpaynoamount";
            this.lpaynoamount.Size = new System.Drawing.Size(68, 28);
            this.lpaynoamount.TabIndex = 10;
            this.lpaynoamount.Text = "Lenses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment amount blank";
            // 
            // lpaynodate
            // 
            this.lpaynodate.AutoSize = true;
            this.lpaynodate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lpaynodate.Location = new System.Drawing.Point(272, 13);
            this.lpaynodate.Name = "lpaynodate";
            this.lpaynodate.Size = new System.Drawing.Size(68, 28);
            this.lpaynodate.TabIndex = 8;
            this.lpaynodate.Text = "Lenses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(19, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Payments without a date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Location = new System.Drawing.Point(176, 126);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(297, 31);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(59, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Date to : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 31);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(59, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date from : ";
            // 
            // Takingsreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            //this.Name = "Takingsreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takingsreport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takingsreportgrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lpaynotype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lpaynoamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lpaynodate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ltotsa;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView takingsreportgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paydate;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paytype;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstpayday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiptno;
        private System.Windows.Forms.Button btnHome;
    }
}