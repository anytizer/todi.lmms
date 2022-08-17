using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace todi.lmms
{
    // http://www.tanarang.com/hindi/yaman_hindi.htm
    // http://www.tanarang.com/bookSamplePages.htm
    // https://raag-hindustani.com/Notes.html
    // https://ccrma.stanford.edu/~arvindh/cmt/the_12_notes.html
    // https://rec.music.indian.classical.narkive.com/eJWDNTNP/western-equivalent-of-notes-of-hindustani-music
    // https://www.sharda.org/raga-taal/
    // https://musicwithaditi.com/aaroh-avroh/
    // https://www.ipassio.com/blog/list-of-ragas-in-indian-classical-music
    // https://www.dnaindia.com/entertainment/report-five-raags-you-must-listen-to-on-world-music-day-1851027
    /**
     * if:
     * sa is set to 1 = C,
     * ga becomes 1 + 3 = 4 = D#,
     * ma becomes 4 + 2 = 6 = F,
     * dha becomes 6 + 3 = 9 = G#,
     * ni becomes 9 + 2 = 11 = A#.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateAndCopySARGAMs();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAndCopySARGAMs();
        }


        private int lines()
        {
            return (int)numericUpDown1.Value;
            //return 12;
        }

        private int numerator()
        {
            return (int)numericUpDown2.Value; 
            //return 3;
        }

        private int denumerator()
        {
            return (int)numericUpDown3.Value;
            //return 4;
        }


        private void CreateAndCopySARGAMs()
        {
            int lines = this.lines();
            int numerator = this.numerator();
            int denumerator = this.denumerator();

            SARGAMizer sargamizer = new SARGAMizer();
            List<string> notations = sargamizer.lyrics(lines, numerator, denumerator);

            string lyrics = string.Join(" ", notations);
            this.textBox1.Text = lyrics;

            // auto copy sargam notes into memory
            CopySARGAMs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CopySARGAMs();
        }

        private void CopySARGAMs()
        {
            System.Windows.Forms.Clipboard.SetText(this.textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Lyrics Lines
            //numericUpDown1.Value = 16;
            numericUpDown1.Maximum = 64;
            numericUpDown1.Minimum = 4;
            numericUpDown1.ReadOnly = true;

            // numerator
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 32;
            numericUpDown2.ReadOnly = true;

            // denumerator
            numericUpDown3.Minimum = 1; 
            numericUpDown3.Maximum = 32;
            numericUpDown3.ReadOnly = true;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CreateAndCopySARGAMs();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CreateAndCopySARGAMs();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            CreateAndCopySARGAMs();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateAndCopySARGAMs();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateAndCopySARGAMs();
        }
    }    
}