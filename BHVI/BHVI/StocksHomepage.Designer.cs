namespace BHVI
{
    partial class StocksHomepage
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnlenses = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnframes = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 726);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.HotPink;
            this.panel3.Controls.Add(this.btnlenses);
            this.panel3.Location = new System.Drawing.Point(810, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 123);
            this.panel3.TabIndex = 5;
            // 
            // btnlenses
            // 
            this.btnlenses.BackColor = System.Drawing.Color.MistyRose;
            this.btnlenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlenses.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnlenses.FlatAppearance.BorderSize = 3;
            this.btnlenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlenses.Location = new System.Drawing.Point(64, 42);
            this.btnlenses.Name = "btnlenses";
            this.btnlenses.Size = new System.Drawing.Size(262, 45);
            this.btnlenses.TabIndex = 0;
            this.btnlenses.Text = "Lenses";
            this.btnlenses.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepPink;
            this.panel2.Controls.Add(this.btnframes);
            this.panel2.Location = new System.Drawing.Point(210, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 123);
            this.panel2.TabIndex = 4;
            // 
            // btnframes
            // 
            this.btnframes.BackColor = System.Drawing.Color.MistyRose;
            this.btnframes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnframes.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnframes.FlatAppearance.BorderSize = 3;
            this.btnframes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnframes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnframes.Location = new System.Drawing.Point(64, 40);
            this.btnframes.Name = "btnframes";
            this.btnframes.Size = new System.Drawing.Size(262, 45);
            this.btnframes.TabIndex = 0;
            this.btnframes.Text = "Frames";
            this.btnframes.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::BHVI.Properties.Resources.icons8_home_48;
            this.btnHome.Location = new System.Drawing.Point(4, 662);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 55);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // StocksHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            this.Name = "StocksHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StocksHomepage";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnlenses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnframes;
        private System.Windows.Forms.Button btnHome;
    }
}