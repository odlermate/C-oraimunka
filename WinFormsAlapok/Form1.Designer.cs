namespace WinFormsAlapok
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
            this.button_beallit = new System.Windows.Forms.Button();
            this.button_szamol = new System.Windows.Forms.Button();
            this.textBox_szam1 = new System.Windows.Forms.TextBox();
            this.textBox_szam2 = new System.Windows.Forms.TextBox();
            this.eredmeny = new System.Windows.Forms.TextBox();
            this.textBox_beker = new System.Windows.Forms.NumericUpDown();
            this.textBox_beker2 = new System.Windows.Forms.NumericUpDown();
            this.textBox_beker3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_beker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_beker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_beker3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_beallit
            // 
            this.button_beallit.Location = new System.Drawing.Point(138, 41);
            this.button_beallit.Name = "button_beallit";
            this.button_beallit.Size = new System.Drawing.Size(75, 23);
            this.button_beallit.TabIndex = 0;
            this.button_beallit.Text = "Beállít";
            this.button_beallit.UseVisualStyleBackColor = true;
            this.button_beallit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_szamol
            // 
            this.button_szamol.Location = new System.Drawing.Point(442, 35);
            this.button_szamol.Name = "button_szamol";
            this.button_szamol.Size = new System.Drawing.Size(75, 23);
            this.button_szamol.TabIndex = 4;
            this.button_szamol.Text = "Számol";
            this.button_szamol.UseVisualStyleBackColor = true;
            this.button_szamol.Click += new System.EventHandler(this.Button_szamol_Click);
            // 
            // textBox_szam1
            // 
            this.textBox_szam1.Location = new System.Drawing.Point(336, 20);
            this.textBox_szam1.Name = "textBox_szam1";
            this.textBox_szam1.Size = new System.Drawing.Size(100, 20);
            this.textBox_szam1.TabIndex = 5;
            // 
            // textBox_szam2
            // 
            this.textBox_szam2.Location = new System.Drawing.Point(336, 46);
            this.textBox_szam2.Name = "textBox_szam2";
            this.textBox_szam2.Size = new System.Drawing.Size(100, 20);
            this.textBox_szam2.TabIndex = 6;
            // 
            // eredmeny
            // 
            this.eredmeny.Enabled = false;
            this.eredmeny.Location = new System.Drawing.Point(582, 35);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(100, 20);
            this.eredmeny.TabIndex = 7;
            // 
            // textBox_beker
            // 
            this.textBox_beker.Location = new System.Drawing.Point(12, 12);
            this.textBox_beker.Name = "textBox_beker";
            this.textBox_beker.Size = new System.Drawing.Size(120, 20);
            this.textBox_beker.TabIndex = 8;
            // 
            // textBox_beker2
            // 
            this.textBox_beker2.Location = new System.Drawing.Point(12, 41);
            this.textBox_beker2.Name = "textBox_beker2";
            this.textBox_beker2.Size = new System.Drawing.Size(120, 20);
            this.textBox_beker2.TabIndex = 9;
            // 
            // textBox_beker3
            // 
            this.textBox_beker3.Location = new System.Drawing.Point(12, 67);
            this.textBox_beker3.Name = "textBox_beker3";
            this.textBox_beker3.Size = new System.Drawing.Size(120, 20);
            this.textBox_beker3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_beker3);
            this.Controls.Add(this.textBox_beker2);
            this.Controls.Add(this.textBox_beker);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.textBox_szam2);
            this.Controls.Add(this.textBox_szam1);
            this.Controls.Add(this.button_szamol);
            this.Controls.Add(this.button_beallit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox_beker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_beker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_beker3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_beallit;
        private System.Windows.Forms.Button button_szamol;
        private System.Windows.Forms.TextBox textBox_szam1;
        private System.Windows.Forms.TextBox textBox_szam2;
        private System.Windows.Forms.TextBox eredmeny;
        private System.Windows.Forms.NumericUpDown textBox_beker;
        private System.Windows.Forms.NumericUpDown textBox_beker2;
        private System.Windows.Forms.NumericUpDown textBox_beker3;
    }
}

