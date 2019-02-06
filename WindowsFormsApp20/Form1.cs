using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private List<string> paths = new List<string>();
        private int pageCount = 0;
        private int currentPage = 1;
        private int lastPage = 100;
        private string toSpeach = string.Empty;
        SpeechSynthesizer speech = new SpeechSynthesizer();
        
        public Form1()
        {
            InitializeComponent();
            speech.SelectVoiceByHints(VoiceGender.Male,VoiceAge.Adult);
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            string[] path = (string[])e.Data.GetData(DataFormats.FileDrop);
            paths.AddRange(path);
            foreach (var item in path)
            {
                listView2.Items.Add(System.IO.Path.GetFileName(item));
            }
        }

        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
                using (PdfReader reader = new PdfReader(paths.Find(x => x.Contains(listView2.SelectedItems[0].Text))))
                {
                    pageCount = reader.NumberOfPages;
                    PageCountLbl.Text = $"{currentPage} of {pageCount}";
                    bookReaderPnl.Visible = true;
                    toSpeach = PdfTextExtractor.GetTextFromPage(reader, currentPage );
                    var cur = speech.GetCurrentlySpokenPrompt();
                    if (cur != null)
                        speech.SpeakAsyncCancel(cur);
                    if (currentPage != lastPage)
                    {
                        speech.SpeakAsync(toSpeach); 
                    }
                    lastPage = currentPage;
                }
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentPage++;
            PageCountLbl.Text = $"{currentPage} of {pageCount}";
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf(paths[0]);
            if (f.PageCount > 0)
            {
                f.ImageOptions.Dpi = 50;
                page.Image = f.ToDrawingImage(currentPage); 
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
                using (PdfReader reader = new PdfReader(paths.Find(x => x.Contains(listView2.SelectedItems[0].Text))))
                {
                    pageCount = reader.NumberOfPages;
                    PageCountLbl.Text = $"{currentPage} of {pageCount}";
                }
                    SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf(paths.Find(x => x.Contains(listView2.SelectedItems[0].Text)));
            if (f.PageCount > 0)
            {
                f.ImageOptions.Dpi = 50;
                page.Image = f.ToDrawingImage(currentPage);
            }
        }
    }
}
