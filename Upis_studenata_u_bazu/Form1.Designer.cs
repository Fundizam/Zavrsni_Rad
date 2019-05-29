namespace Upis_studenata_u_bazu
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
            this.UnosUBazu = new System.Windows.Forms.Button();
            this.ImeStudenta = new System.Windows.Forms.TextBox();
            this.OIBStudenta = new System.Windows.Forms.TextBox();
            this.PrezimeStudenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PregledUpisanihStudenata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Studij = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DatumRodenja = new System.Windows.Forms.TextBox();
            this.GradStudenta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StatusStudenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UnosUBazu
            // 
            this.UnosUBazu.Location = new System.Drawing.Point(84, 303);
            this.UnosUBazu.Margin = new System.Windows.Forms.Padding(4);
            this.UnosUBazu.Name = "UnosUBazu";
            this.UnosUBazu.Size = new System.Drawing.Size(243, 73);
            this.UnosUBazu.TabIndex = 8;
            this.UnosUBazu.Text = "Unesi";
            this.UnosUBazu.UseVisualStyleBackColor = true;
            this.UnosUBazu.Click += new System.EventHandler(this.UnosUBazu_Click);
            // 
            // ImeStudenta
            // 
            this.ImeStudenta.Location = new System.Drawing.Point(212, 117);
            this.ImeStudenta.Margin = new System.Windows.Forms.Padding(4);
            this.ImeStudenta.Name = "ImeStudenta";
            this.ImeStudenta.Size = new System.Drawing.Size(212, 22);
            this.ImeStudenta.TabIndex = 2;
            // 
            // OIBStudenta
            // 
            this.OIBStudenta.Location = new System.Drawing.Point(212, 49);
            this.OIBStudenta.Margin = new System.Windows.Forms.Padding(4);
            this.OIBStudenta.Name = "OIBStudenta";
            this.OIBStudenta.Size = new System.Drawing.Size(212, 22);
            this.OIBStudenta.TabIndex = 1;
            // 
            // PrezimeStudenta
            // 
            this.PrezimeStudenta.Location = new System.Drawing.Point(212, 191);
            this.PrezimeStudenta.Margin = new System.Windows.Forms.Padding(4);
            this.PrezimeStudenta.Name = "PrezimeStudenta";
            this.PrezimeStudenta.Size = new System.Drawing.Size(212, 22);
            this.PrezimeStudenta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime studenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prezime studenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "OIB studenta";
            // 
            // PregledUpisanihStudenata
            // 
            this.PregledUpisanihStudenata.Location = new System.Drawing.Point(631, 319);
            this.PregledUpisanihStudenata.Margin = new System.Windows.Forms.Padding(4);
            this.PregledUpisanihStudenata.Name = "PregledUpisanihStudenata";
            this.PregledUpisanihStudenata.Size = new System.Drawing.Size(243, 73);
            this.PregledUpisanihStudenata.TabIndex = 9;
            this.PregledUpisanihStudenata.Text = "Pregled ";
            this.PregledUpisanihStudenata.UseVisualStyleBackColor = true;
            this.PregledUpisanihStudenata.Click += new System.EventHandler(this.PregledUpisanihStudenata_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Studij";
            // 
            // Studij
            // 
            this.Studij.FormattingEnabled = true;
            this.Studij.Location = new System.Drawing.Point(591, 115);
            this.Studij.Margin = new System.Windows.Forms.Padding(4);
            this.Studij.Name = "Studij";
            this.Studij.Size = new System.Drawing.Size(283, 24);
            this.Studij.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datum rođenja";
            // 
            // DatumRodenja
            // 
            this.DatumRodenja.Location = new System.Drawing.Point(591, 48);
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.Size = new System.Drawing.Size(283, 22);
            this.DatumRodenja.TabIndex = 4;
            // 
            // GradStudenta
            // 
            this.GradStudenta.FormattingEnabled = true;
            this.GradStudenta.Location = new System.Drawing.Point(591, 192);
            this.GradStudenta.Name = "GradStudenta";
            this.GradStudenta.Size = new System.Drawing.Size(283, 24);
            this.GradStudenta.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // StatusStudenta
            // 
            this.StatusStudenta.FormattingEnabled = true;
            this.StatusStudenta.Location = new System.Drawing.Point(362, 250);
            this.StatusStudenta.Name = "StatusStudenta";
            this.StatusStudenta.Size = new System.Drawing.Size(241, 24);
            this.StatusStudenta.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 405);
            this.Controls.Add(this.StatusStudenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GradStudenta);
            this.Controls.Add(this.DatumRodenja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Studij);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PregledUpisanihStudenata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrezimeStudenta);
            this.Controls.Add(this.OIBStudenta);
            this.Controls.Add(this.ImeStudenta);
            this.Controls.Add(this.UnosUBazu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Unos podataka o studentu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnosUBazu;
        private System.Windows.Forms.TextBox ImeStudenta;
        private System.Windows.Forms.TextBox OIBStudenta;
        private System.Windows.Forms.TextBox PrezimeStudenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PregledUpisanihStudenata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Studij;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DatumRodenja;
        private System.Windows.Forms.ComboBox GradStudenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StatusStudenta;
    }
}

