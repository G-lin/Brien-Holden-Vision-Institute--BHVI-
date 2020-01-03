namespace BHVI
{
    partial class patientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.adultorchild = new System.Windows.Forms.GroupBox();
            this.rbtnadult = new System.Windows.Forms.RadioButton();
            this.rbtnchild = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.GroupBox();
            this.rbtnmale = new System.Windows.Forms.RadioButton();
            this.rbtnfemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtmob = new System.Windows.Forms.TextBox();
            this.txtdisability = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.adultorchild.SuspendLayout();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 1096);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightYellow;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::BHVI.Properties.Resources.icons8_home_24;
            this.btnHome.Location = new System.Drawing.Point(1266, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 29);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Details";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.adultorchild);
            this.panel5.Controls.Add(this.gender);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnclear);
            this.panel5.Controls.Add(this.btnsave);
            this.panel5.Controls.Add(this.date);
            this.panel5.Controls.Add(this.txtmob);
            this.panel5.Controls.Add(this.txtdisability);
            this.panel5.Controls.Add(this.txtphone);
            this.panel5.Controls.Add(this.txtage);
            this.panel5.Controls.Add(this.txtaddress);
            this.panel5.Controls.Add(this.txtname);
            this.panel5.Controls.Add(this.txtpno);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Controls.Add(this.label36);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Location = new System.Drawing.Point(42, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1274, 654);
            this.panel5.TabIndex = 3;
            // 
            // adultorchild
            // 
            this.adultorchild.Controls.Add(this.rbtnadult);
            this.adultorchild.Controls.Add(this.rbtnchild);
            this.adultorchild.Location = new System.Drawing.Point(214, 361);
            this.adultorchild.Name = "adultorchild";
            this.adultorchild.Size = new System.Drawing.Size(437, 52);
            this.adultorchild.TabIndex = 25;
            this.adultorchild.TabStop = false;
            // 
            // rbtnadult
            // 
            this.rbtnadult.AutoSize = true;
            this.rbtnadult.Checked = true;
            this.rbtnadult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnadult.Location = new System.Drawing.Point(6, 17);
            this.rbtnadult.Name = "rbtnadult";
            this.rbtnadult.Size = new System.Drawing.Size(83, 29);
            this.rbtnadult.TabIndex = 22;
            this.rbtnadult.TabStop = true;
            this.rbtnadult.Text = "Adult";
            this.rbtnadult.UseVisualStyleBackColor = true;
            this.rbtnadult.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnchild
            // 
            this.rbtnchild.AutoSize = true;
            this.rbtnchild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnchild.Location = new System.Drawing.Point(183, 17);
            this.rbtnchild.Name = "rbtnchild";
            this.rbtnchild.Size = new System.Drawing.Size(83, 29);
            this.rbtnchild.TabIndex = 23;
            this.rbtnchild.Text = "Child";
            this.rbtnchild.UseVisualStyleBackColor = true;
            this.rbtnchild.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // gender
            // 
            this.gender.Controls.Add(this.rbtnmale);
            this.gender.Controls.Add(this.rbtnfemale);
            this.gender.Location = new System.Drawing.Point(214, 244);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(437, 52);
            this.gender.TabIndex = 24;
            this.gender.TabStop = false;
            this.gender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnmale
            // 
            this.rbtnmale.AutoSize = true;
            this.rbtnmale.Checked = true;
            this.rbtnmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnmale.Location = new System.Drawing.Point(6, 17);
            this.rbtnmale.Name = "rbtnmale";
            this.rbtnmale.Size = new System.Drawing.Size(80, 29);
            this.rbtnmale.TabIndex = 9;
            this.rbtnmale.TabStop = true;
            this.rbtnmale.Text = "Male";
            this.rbtnmale.UseVisualStyleBackColor = true;
            // 
            // rbtnfemale
            // 
            this.rbtnfemale.AutoSize = true;
            this.rbtnfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnfemale.Location = new System.Drawing.Point(183, 17);
            this.rbtnfemale.Name = "rbtnfemale";
            this.rbtnfemale.Size = new System.Drawing.Size(104, 29);
            this.rbtnfemale.TabIndex = 10;
            this.rbtnfemale.Text = "Female";
            this.rbtnfemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Adult/Child : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.btnclear.Location = new System.Drawing.Point(860, 589);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(119, 56);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
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
            this.btnsave.Location = new System.Drawing.Point(1008, 589);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(246, 56);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "  Save and Continue";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.date.Location = new System.Drawing.Point(219, 593);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(381, 34);
            this.date.TabIndex = 18;
            // 
            // txtmob
            // 
            this.txtmob.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtmob.Location = new System.Drawing.Point(660, 441);
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(285, 34);
            this.txtmob.TabIndex = 17;
            this.txtmob.TextChanged += new System.EventHandler(this.txtmob_TextChanged);
            this.txtmob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmob_KeyPress);
            // 
            // txtdisability
            // 
            this.txtdisability.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtdisability.Location = new System.Drawing.Point(214, 517);
            this.txtdisability.Name = "txtdisability";
            this.txtdisability.Size = new System.Drawing.Size(1014, 34);
            this.txtdisability.TabIndex = 16;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtphone.Location = new System.Drawing.Point(214, 441);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(286, 34);
            this.txtphone.TabIndex = 15;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtage.Location = new System.Drawing.Point(214, 313);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(286, 34);
            this.txtage.TabIndex = 14;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            this.txtage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtage_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtaddress.Location = new System.Drawing.Point(214, 167);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(1014, 61);
            this.txtaddress.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(214, 101);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(397, 34);
            this.txtname.TabIndex = 12;
            // 
            // txtpno
            // 
            this.txtpno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtpno.Location = new System.Drawing.Point(214, 28);
            this.txtpno.Name = "txtpno";
            this.txtpno.Size = new System.Drawing.Size(397, 34);
            this.txtpno.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Disability : ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(29, 253);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(102, 25);
            this.label30.TabIndex = 7;
            this.label30.Text = "Gender : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(29, 316);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 25);
            this.label31.TabIndex = 6;
            this.label31.Text = "Age : ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(565, 444);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 25);
            this.label32.TabIndex = 5;
            this.label32.Text = "Mobile :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(34, 444);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 25);
            this.label33.TabIndex = 4;
            this.label33.Text = "Phone :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(29, 173);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(105, 25);
            this.label34.TabIndex = 3;
            this.label34.Text = "Address :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(29, 101);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 25);
            this.label35.TabIndex = 2;
            this.label35.Text = "Name :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(34, 598);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(76, 25);
            this.label36.TabIndex = 1;
            this.label36.Text = "Date : ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(29, 34);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(179, 25);
            this.label37.TabIndex = 0;
            this.label37.Text = "Patient Number : ";
            // 
            // patientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 738);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "patientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientForm";
            this.Load += new System.EventHandler(this.patientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.adultorchild.ResumeLayout(false);
            this.adultorchild.PerformLayout();
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtmob;
        private System.Windows.Forms.TextBox txtdisability;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpno;
        private System.Windows.Forms.RadioButton rbtnfemale;
        private System.Windows.Forms.RadioButton rbtnmale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.RadioButton rbtnchild;
        private System.Windows.Forms.RadioButton rbtnadult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.GroupBox adultorchild;
    }
}