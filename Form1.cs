using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kopijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog notatnik = new OpenFileDialog();
            notatnik.Title = "Otwórz";
            notatnik.Filter = "Dokument tekstowy (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            if (notatnik.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(notatnik.FileName, RichTextBoxStreamType.PlainText);
            this.Text = notatnik.FileName;
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog notatnik = new SaveFileDialog();
            notatnik.Title = "Otwórz";
            notatnik.Filter = "Dokument tekstowy (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            if (notatnik.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(notatnik.FileName, RichTextBoxStreamType.PlainText);
            this.Text = notatnik.FileName;
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void porzedniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void następnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog kolor = new ColorDialog();
            if (kolor.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = kolor.Color;
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog czcionka = new FontDialog();
            if (czcionka.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = czcionka.Font;
        }
    }
}
