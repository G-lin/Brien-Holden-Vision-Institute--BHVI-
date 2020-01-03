namespace BHVI
{
    partial class Finances
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ldueamount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lpaynum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreceiptno = new System.Windows.Forms.TextBox();
            this.cmbptype = new System.Windows.Forms.ComboBox();
            this.datep = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.lpno = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ltotal = new System.Windows.Forms.Label();
            this.lsaleprice = new System.Windows.Forms.Label();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.lbpno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.lpno);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 724);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightYellow;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::BHVI.Properties.Resources.icons8_home_24;
            this.btnHome.Location = new System.Drawing.Point(1290, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 29);
            this.btnHome.TabIndex = 49;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ldueamount);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(46, 580);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1274, 53);
            this.panel3.TabIndex = 48;
            // 
            // ldueamount
            // 
            this.ldueamount.AutoSize = true;
            this.ldueamount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldueamount.Location = new System.Drawing.Point(552, 2);
            this.ldueamount.Name = "ldueamount";
            this.ldueamount.Size = new System.Drawing.Size(127, 46);
            this.ldueamount.TabIndex = 43;
            this.ldueamount.Text = "label15";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(214, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 28);
            this.label17.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(359, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 25);
            this.label18.TabIndex = 3;
            this.label18.Text = "Amount due :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lpaynum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtreceiptno);
            this.panel2.Controls.Add(this.cmbptype);
            this.panel2.Controls.Add(this.datep);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtamt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(46, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 192);
            this.panel2.TabIndex = 47;
            // 
            // lpaynum
            // 
            this.lpaynum.AutoSize = true;
            this.lpaynum.Font = new System.Drawing.Font("Baskerville Old Face", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lpaynum.Location = new System.Drawing.Point(151, 4);
            this.lpaynum.Name = "lpaynum";
            this.lpaynum.Size = new System.Drawing.Size(31, 34);
            this.lpaynum.TabIndex = 50;
            this.lpaynum.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Receipt number : ";
            // 
            // txtreceiptno
            // 
            this.txtreceiptno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtreceiptno.Location = new System.Drawing.Point(221, 61);
            this.txtreceiptno.Name = "txtreceiptno";
            this.txtreceiptno.Size = new System.Drawing.Size(286, 34);
            this.txtreceiptno.TabIndex = 48;
            this.txtreceiptno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtreceiptno_KeyPress);
            // 
            // cmbptype
            // 
            this.cmbptype.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbptype.FormattingEnabled = true;
            this.cmbptype.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Cheque"});
            this.cmbptype.Location = new System.Drawing.Point(221, 129);
            this.cmbptype.Name = "cmbptype";
            this.cmbptype.Size = new System.Drawing.Size(286, 36);
            this.cmbptype.TabIndex = 47;
            // 
            // datep
            // 
            this.datep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.datep.Location = new System.Drawing.Point(758, 127);
            this.datep.Name = "datep";
            this.datep.Size = new System.Drawing.Size(383, 34);
            this.datep.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(589, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Amount : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(589, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Payment date : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Baskerville Old Face", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.Location = new System.Drawing.Point(26, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 34);
            this.label10.TabIndex = 45;
            this.label10.Text = "Payment";
            // 
            // txtamt
            // 
            this.txtamt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtamt.Location = new System.Drawing.Point(758, 59);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(383, 34);
            this.txtamt.TabIndex = 25;
            this.txtamt.TextChanged += new System.EventHandler(this.txtamt_TextChanged);
            this.txtamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(214, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Type : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.Location = new System.Drawing.Point(38, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 43);
            this.label5.TabIndex = 44;
            this.label5.Text = "Finance";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Tomato;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnclear.FlatAppearance.BorderSize = 2;
            this.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::BHVI.Properties.Resources.icons8_clear_symbol_40;
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.Location = new System.Drawing.Point(884, 654);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(141, 56);
            this.btnclear.TabIndex = 43;
            this.btnclear.Text = "Clear";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lpno
            // 
            this.lpno.AutoSize = true;
            this.lpno.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpno.Location = new System.Drawing.Point(255, 85);
            this.lpno.Name = "lpno";
            this.lpno.Size = new System.Drawing.Size(90, 37);
            this.lpno.TabIndex = 41;
            this.lpno.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.ltotal);
            this.panel5.Controls.Add(this.lsaleprice);
            this.panel5.Controls.Add(this.txtdis);
            this.panel5.Controls.Add(this.lbpno);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Location = new System.Drawing.Point(46, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1274, 185);
            this.panel5.TabIndex = 40;
            // 
            // ltotal
            // 
            this.ltotal.AutoSize = true;
            this.ltotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotal.Location = new System.Drawing.Point(911, 54);
            this.ltotal.Name = "ltotal";
            this.ltotal.Size = new System.Drawing.Size(109, 46);
            this.ltotal.TabIndex = 43;
            this.ltotal.Text = "label1";
            // 
            // lsaleprice
            // 
            this.lsaleprice.AutoSize = true;
            this.lsaleprice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsaleprice.Location = new System.Drawing.Point(220, 24);
            this.lsaleprice.Name = "lsaleprice";
            this.lsaleprice.Size = new System.Drawing.Size(90, 37);
            this.lsaleprice.TabIndex = 42;
            this.lsaleprice.Text = "label1";
            // 
            // txtdis
            // 
            this.txtdis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtdis.Location = new System.Drawing.Point(214, 109);
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(286, 34);
            this.txtdis.TabIndex = 25;
            this.txtdis.TextChanged += new System.EventHandler(this.txtdis_TextChanged);
            this.txtdis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdis_KeyPress);
            // 
            // lbpno
            // 
            this.lbpno.AutoSize = true;
            this.lbpno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbpno.Location = new System.Drawing.Point(214, 31);
            this.lbpno.Name = "lbpno";
            this.lbpno.Size = new System.Drawing.Size(0, 28);
            this.lbpno.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total amount :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(29, 115);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(138, 25);
            this.label34.TabIndex = 3;
            this.label34.Text = "Discout (%) :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(29, 28);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(128, 25);
            this.label35.TabIndex = 2;
            this.label35.Text = "Sale price : ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(77, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(179, 25);
            this.label37.TabIndex = 39;
            this.label37.Text = "Patient Number : ";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnsave.FlatAppearance.BorderSize = 2;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::BHVI.Properties.Resources.icons8_save_40;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(1044, 654);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(276, 56);
            this.btnsave.TabIndex = 42;
            this.btnsave.Text = "  Save and Continue";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            this.Name = "Finances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finances";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lpno;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ltotal;
        private System.Windows.Forms.Label lsaleprice;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.Label lbpno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbptype;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ldueamount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreceiptno;
        private System.Windows.Forms.Label lpaynum;
        private System.Windows.Forms.Button btnHome;
    }
}