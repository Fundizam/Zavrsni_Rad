namespace Upis_studenata_u_bazu
{
    partial class Form2
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
            this.PregledUpisanih = new System.Windows.Forms.DataGridView();
            this.Povratak = new System.Windows.Forms.Button();
            this.PrikazStudenata = new System.Windows.Forms.Button();
            this.PrikazDrzava = new System.Windows.Forms.Button();
            this.PrikazGradoa = new System.Windows.Forms.Button();
            this.PrikazStudija = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PregledUpisanih)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PregledUpisanih);
            this.panel1.Location = new System.Drawing.Point(16, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 317);
            this.panel1.TabIndex = 0;
            // 
            // PregledUpisanih
            // 
            this.PregledUpisanih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PregledUpisanih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PregledUpisanih.Location = new System.Drawing.Point(0, 0);
            this.PregledUpisanih.Margin = new System.Windows.Forms.Padding(4);
            this.PregledUpisanih.Name = "PregledUpisanih";
            this.PregledUpisanih.Size = new System.Drawing.Size(803, 317);
            this.PregledUpisanih.TabIndex = 0;
            // 
            // Povratak
            // 
            this.Povratak.Location = new System.Drawing.Point(16, 15);
            this.Povratak.Margin = new System.Windows.Forms.Padding(4);
            this.Povratak.Name = "Povratak";
            this.Povratak.Size = new System.Drawing.Size(111, 42);
            this.Povratak.TabIndex = 1;
            this.Povratak.Text = "Povratak";
            this.Povratak.UseVisualStyleBackColor = true;
            this.Povratak.Click += new System.EventHandler(this.Povratak_Click);
            // 
            // PrikazStudenata
            // 
            this.PrikazStudenata.Location = new System.Drawing.Point(196, 15);
            this.PrikazStudenata.Margin = new System.Windows.Forms.Padding(4);
            this.PrikazStudenata.Name = "PrikazStudenata";
            this.PrikazStudenata.Size = new System.Drawing.Size(128, 42);
            this.PrikazStudenata.TabIndex = 2;
            this.PrikazStudenata.Text = "Prikaz studenata";
            this.PrikazStudenata.UseVisualStyleBackColor = true;
            this.PrikazStudenata.Click += new System.EventHandler(this.PrikazStudenata_Click);
            // 
            // PrikazDrzava
            // 
            this.PrikazDrzava.Location = new System.Drawing.Point(342, 15);
            this.PrikazDrzava.Name = "PrikazDrzava";
            this.PrikazDrzava.Size = new System.Drawing.Size(125, 42);
            this.PrikazDrzava.TabIndex = 3;
            this.PrikazDrzava.Text = "Prikaz država";
            this.PrikazDrzava.UseVisualStyleBackColor = true;
            this.PrikazDrzava.Click += new System.EventHandler(this.PrikazDrzava_Click);
            // 
            // PrikazGradoa
            // 
            this.PrikazGradoa.Location = new System.Drawing.Point(486, 15);
            this.PrikazGradoa.Name = "PrikazGradoa";
            this.PrikazGradoa.Size = new System.Drawing.Size(113, 42);
            this.PrikazGradoa.TabIndex = 5;
            this.PrikazGradoa.Text = "Prikaz gradova";
            this.PrikazGradoa.UseVisualStyleBackColor = true;
            this.PrikazGradoa.Click += new System.EventHandler(this.PrikazGradova_Click);
            // 
            // PrikazStudija
            // 
            this.PrikazStudija.Location = new System.Drawing.Point(615, 15);
            this.PrikazStudija.Name = "PrikazStudija";
            this.PrikazStudija.Size = new System.Drawing.Size(103, 42);
            this.PrikazStudija.TabIndex = 7;
            this.PrikazStudija.Text = "Prikaz studija";
            this.PrikazStudija.UseVisualStyleBackColor = true;
            this.PrikazStudija.Click += new System.EventHandler(this.PrikazStudija_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 412);
            this.Controls.Add(this.PrikazStudija);
            this.Controls.Add(this.PrikazGradoa);
            this.Controls.Add(this.PrikazDrzava);
            this.Controls.Add(this.PrikazStudenata);
            this.Controls.Add(this.Povratak);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Pregled upisanih studenata";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PregledUpisanih)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Povratak;
        private System.Windows.Forms.DataGridView PregledUpisanih;
        private System.Windows.Forms.Button PrikazStudenata;
        private System.Windows.Forms.Button PrikazDrzava;
        private System.Windows.Forms.Button PrikazGradoa;
        private System.Windows.Forms.Button PrikazStudija;
    }
}