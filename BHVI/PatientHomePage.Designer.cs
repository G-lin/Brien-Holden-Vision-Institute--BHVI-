namespace BHVI
{
    partial class PatientHomePage
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btndeletep = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdatep = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnviewp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnaddp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 722);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::BHVI.Properties.Resources.icons8_home_48;
            this.btnHome.Location = new System.Drawing.Point(3, 658);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 61);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.btndeletep);
            this.panel5.Location = new System.Drawing.Point(449, 518);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 113);
            this.panel5.TabIndex = 3;
            // 
            // btndeletep
            // 
            this.btndeletep.BackColor = System.Drawing.Color.Gold;
            this.btndeletep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletep.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btndeletep.FlatAppearance.BorderSize = 2;
            this.btndeletep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btndeletep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletep.Image = global::BHVI.Properties.Resources.delet;
            this.btndeletep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeletep.Location = new System.Drawing.Point(33, 26);
            this.btndeletep.Name = "btndeletep";
            this.btndeletep.Size = new System.Drawing.Size(272, 62);
            this.btndeletep.TabIndex = 1;
            this.btndeletep.Text = "Delete patient";
            this.btndeletep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndeletep.UseVisualStyleBackColor = false;
            this.btndeletep.Click += new System.EventHandler(this.btndeletep_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.btnupdatep);
            this.panel4.Location = new System.Drawing.Point(449, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 113);
            this.panel4.TabIndex = 2;
            // 
            // btnupdatep
            // 
            this.btnupdatep.BackColor = System.Drawing.Color.Yellow;
            this.btnupdatep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdatep.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnupdatep.FlatAppearance.BorderSize = 2;
            this.btnupdatep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnupdatep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatep.Image = global::BHVI.Properties.Resources.icons8_change_user_40;
            this.btnupdatep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatep.Location = new System.Drawing.Point(33, 25);
            this.btnupdatep.Name = "btnupdatep";
            this.btnupdatep.Size = new System.Drawing.Size(272, 62);
            this.btnupdatep.TabIndex = 1;
            this.btnupdatep.Text = "Update patient";
            this.btnupdatep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdatep.UseVisualStyleBackColor = false;
            this.btnupdatep.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.btnviewp);
            this.panel3.Location = new System.Drawing.Point(449, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 113);
            this.panel3.TabIndex = 1;
            // 
            // btnviewp
            // 
            this.btnviewp.BackColor = System.Drawing.Color.Khaki;
            this.btnviewp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnviewp.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnviewp.FlatAppearance.BorderSize = 2;
            this.btnviewp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnviewp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewp.Image = global::BHVI.Properties.Resources.icons8_find_user_male_40_1_;
            this.btnviewp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewp.Location = new System.Drawing.Point(33, 25);
            this.btnviewp.Name = "btnviewp";
            this.btnviewp.Size = new System.Drawing.Size(272, 62);
            this.btnviewp.TabIndex = 4;
            this.btnviewp.Text = "View patient";
            this.btnviewp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnviewp.UseVisualStyleBackColor = false;
            this.btnviewp.Click += new System.EventHandler(this.btnviewp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.btnaddp);
            this.panel2.Location = new System.Drawing.Point(449, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 113);
            this.panel2.TabIndex = 0;
            // 
            // btnaddp
            // 
            this.btnaddp.BackColor = System.Drawing.Color.OldLace;
            this.btnaddp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddp.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnaddp.FlatAppearance.BorderSize = 2;
            this.btnaddp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnaddp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddp.Image = global::BHVI.Properties.Resources.add;
            this.btnaddp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddp.Location = new System.Drawing.Point(33, 24);
            this.btnaddp.Name = "btnaddp";
            this.btnaddp.Size = new System.Drawing.Size(272, 62);
            this.btnaddp.TabIndex = 0;
            this.btnaddp.Text = "Add patient";
            this.btnaddp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddp.UseVisualStyleBackColor = false;
            this.btnaddp.Click += new System.EventHandler(this.btnaddp_Click);
            // 
            // PatientHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            this.Name = "PatientHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientHomePage";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndeletep;
        private System.Windows.Forms.Button btnupdatep;
        private System.Windows.Forms.Button btnviewp;
        private System.Windows.Forms.Button btnaddp;
        private System.Windows.Forms.Button btnHome;
    }
}