namespace PDFJoiner
{
    partial class PdfJoiner
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfJoiner));
            this.label1 = new System.Windows.Forms.Label();
            this.aggiungi = new System.Windows.Forms.Button();
            this.rimuovi = new System.Windows.Forms.Button();
            this.conversione = new System.Windows.Forms.Button();
            this.listaPercorsi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.MinimumSize = new System.Drawing.Size(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDFJOINER";
            // 
            // aggiungi
            // 
            this.aggiungi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungi.Location = new System.Drawing.Point(12, 254);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(36, 34);
            this.aggiungi.TabIndex = 1;
            this.aggiungi.Text = "+";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // rimuovi
            // 
            this.rimuovi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuovi.Location = new System.Drawing.Point(44, 254);
            this.rimuovi.Name = "rimuovi";
            this.rimuovi.Size = new System.Drawing.Size(36, 34);
            this.rimuovi.TabIndex = 3;
            this.rimuovi.Text = "-";
            this.rimuovi.UseVisualStyleBackColor = true;
            this.rimuovi.Click += new System.EventHandler(this.rimuovi_Click);
            // 
            // conversione
            // 
            this.conversione.Location = new System.Drawing.Point(730, 254);
            this.conversione.Name = "conversione";
            this.conversione.Size = new System.Drawing.Size(90, 34);
            this.conversione.TabIndex = 4;
            this.conversione.Text = "Converti";
            this.conversione.UseVisualStyleBackColor = true;
            this.conversione.Click += new System.EventHandler(this.conversione_Click);
            // 
            // listaPercorsi
            // 
            this.listaPercorsi.FormattingEnabled = true;
            this.listaPercorsi.ItemHeight = 16;
            this.listaPercorsi.Location = new System.Drawing.Point(12, 51);
            this.listaPercorsi.Name = "listaPercorsi";
            this.listaPercorsi.Size = new System.Drawing.Size(808, 196);
            this.listaPercorsi.TabIndex = 5;
            // 
            // PdfJoiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 307);
            this.Controls.Add(this.listaPercorsi);
            this.Controls.Add(this.conversione);
            this.Controls.Add(this.rimuovi);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PdfJoiner";
            this.Text = "PDFJoiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Button rimuovi;
        private System.Windows.Forms.Button conversione;
        private System.Windows.Forms.ListBox listaPercorsi;
    }
}

