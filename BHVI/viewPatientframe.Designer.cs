﻿namespace BHVI
{
    partial class viewPatientframe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnpfiances = new System.Windows.Forms.Button();
            this.btnpframe = new System.Windows.Forms.Button();
            this.btnplense = new System.Windows.Forms.Button();
            this.btnspv = new System.Windows.Forms.Button();
            this.btnpdetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpdetails = new System.Windows.Forms.DataGridView();
            this.lpatientID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 722);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnpfiances);
            this.panel2.Controls.Add(this.btnpframe);
            this.panel2.Controls.Add(this.btnplense);
            this.panel2.Controls.Add(this.btnspv);
            this.panel2.Controls.Add(this.btnpdetails);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 726);
            this.panel2.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Khaki;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::BHVI.Properties.Resources.icons8_home_24;
            this.btnHome.Location = new System.Drawing.Point(13, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(202, 45);
            this.btnHome.TabIndex = 31;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnpfiances
            // 
            this.btnpfiances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpfiances.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpfiances.FlatAppearance.BorderSize = 2;
            this.btnpfiances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnpfiances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpfiances.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpfiances.Location = new System.Drawing.Point(13, 614);
            this.btnpfiances.Name = "btnpfiances";
            this.btnpfiances.Size = new System.Drawing.Size(202, 72);
            this.btnpfiances.TabIndex = 4;
            this.btnpfiances.Text = "Patient finances";
            this.btnpfiances.UseVisualStyleBackColor = true;
            this.btnpfiances.Click += new System.EventHandler(this.btnpfiances_Click);
            // 
            // btnpframe
            // 
            this.btnpframe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpframe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpframe.FlatAppearance.BorderSize = 2;
            this.btnpframe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnpframe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpframe.Location = new System.Drawing.Point(13, 494);
            this.btnpframe.Name = "btnpframe";
            this.btnpframe.Size = new System.Drawing.Size(202, 55);
            this.btnpframe.TabIndex = 3;
            this.btnpframe.Text = "Patient frame";
            this.btnpframe.UseVisualStyleBackColor = true;
            this.btnpframe.Click += new System.EventHandler(this.btnpframe_Click);
            // 
            // btnplense
            // 
            this.btnplense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnplense.FlatAppearance.BorderSize = 2;
            this.btnplense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnplense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplense.Location = new System.Drawing.Point(13, 375);
            this.btnplense.Name = "btnplense";
            this.btnplense.Size = new System.Drawing.Size(202, 55);
            this.btnplense.TabIndex = 2;
            this.btnplense.Text = "Patient lense";
            this.btnplense.UseVisualStyleBackColor = true;
            this.btnplense.Click += new System.EventHandler(this.btnplense_Click);
            // 
            // btnspv
            // 
            this.btnspv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnspv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnspv.FlatAppearance.BorderSize = 2;
            this.btnspv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnspv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnspv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspv.Location = new System.Drawing.Point(13, 208);
            this.btnspv.Name = "btnspv";
            this.btnspv.Size = new System.Drawing.Size(202, 105);
            this.btnspv.TabIndex = 1;
            this.btnspv.Text = "Patient service, presc. and vision";
            this.btnspv.UseVisualStyleBackColor = true;
            this.btnspv.Click += new System.EventHandler(this.btnspv_Click);
            // 
            // btnpdetails
            // 
            this.btnpdetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpdetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpdetails.FlatAppearance.BorderSize = 2;
            this.btnpdetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnpdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdetails.Location = new System.Drawing.Point(13, 102);
            this.btnpdetails.Name = "btnpdetails";
            this.btnpdetails.Size = new System.Drawing.Size(202, 55);
            this.btnpdetails.TabIndex = 0;
            this.btnpdetails.Text = "Patient details";
            this.btnpdetails.UseVisualStyleBackColor = true;
            this.btnpdetails.Click += new System.EventHandler(this.btnpdetails_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lpatientID);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgvpdetails);
            this.panel3.Location = new System.Drawing.Point(237, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 702);
            this.panel3.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(954, 637);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 51);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnupdate.FlatAppearance.BorderSize = 2;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(803, 637);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(131, 51);
            this.btnupdate.TabIndex = 55;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnsearch.FlatAppearance.BorderSize = 2;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(899, 8);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(131, 51);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(350, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 38);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID : ";
            // 
            // dgvpdetails
            // 
            this.dgvpdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpdetails.Location = new System.Drawing.Point(12, 81);
            this.dgvpdetails.Name = "dgvpdetails";
            this.dgvpdetails.RowHeadersWidth = 51;
            this.dgvpdetails.RowTemplate.Height = 24;
            this.dgvpdetails.Size = new System.Drawing.Size(1073, 550);
            this.dgvpdetails.TabIndex = 0;
            this.dgvpdetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvpdetails_MouseClick);
            // 
            // lpatientID
            // 
            this.lpatientID.AutoSize = true;
            this.lpatientID.Location = new System.Drawing.Point(448, 662);
            this.lpatientID.Name = "lpatientID";
            this.lpatientID.Size = new System.Drawing.Size(46, 17);
            this.lpatientID.TabIndex = 57;
            this.lpatientID.Text = "label2";
            this.lpatientID.Visible = false;
            this.lpatientID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // viewPatientframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            this.Name = "viewPatientframe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewPatientframe";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvpdetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnpfiances;
        private System.Windows.Forms.Button btnpframe;
        private System.Windows.Forms.Button btnplense;
        private System.Windows.Forms.Button btnspv;
        private System.Windows.Forms.Button btnpdetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lpatientID;
    }
}