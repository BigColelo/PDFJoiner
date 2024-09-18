using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PDFJoiner
{
    public partial class PdfJoiner : Form
    {
        public PdfJoiner()
        {
            InitializeComponent();
        }

        //Seleziona i file in pdf e li mostra nella listbox
        private void aggiungi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Seleziona i file da unire"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                //creare un array di percorsi dei file PDF selezionati
                string[] pdfFiles = openFileDialog.FileNames;

                foreach (var pdfFile in pdfFiles) 
                {
                    listaPercorsi.Items.Add(pdfFile);
                }
                
            }
        }
        //Bisogna selezionare un valore dalla lista e poi cliccare "-"
        //Elimina il valore selezionato e aggiorna la listbox
        private void rimuovi_Click(object sender, EventArgs e)
        {
            var elimina = listaPercorsi.SelectedItems[0];
            if (elimina != null) 
            {
                listaPercorsi.Items.Remove(elimina);
            }
            foreach (var file in listaPercorsi.Items) 
            {
                file.ToString();
            }
        }

        //Converte i pdf selezionati
        //Nomini il file da unire e scegli il percorso
        private void conversione_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Salva il file PDF unito"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputFile = saveFileDialog.FileName;

                try
                {
                    // Creare un documento vuoto per il PDF di output
                    PdfDocument outputDocument = new PdfDocument();

                    //Unire i PDF
                    foreach (string item in listaPercorsi.Items)
                    {

                        if (File.Exists(item))
                        {
                            //Aprire ogni file PDF
                            PdfDocument inputDocument = PdfReader.Open(item, PdfDocumentOpenMode.Import);

                            // Aggiungere ogni pagina del file PDF all'output
                            for (int i = 0; i < inputDocument.PageCount; i++)
                            {
                                PdfPage page = inputDocument.Pages[i];
                                outputDocument.AddPage(page);
                            }
                        }
                        else 
                        {
                            // Gestisci il caso in cui il file non esiste
                            MessageBox.Show($"Il file non esiste: {item}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Salvare il PDF unito
                    outputDocument.Save(outputFile);
                    MessageBox.Show($"PDF unito correttamente in {outputFile}");
                    listaPercorsi.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Nessun file selezionato");
            }
        }
    }
}
