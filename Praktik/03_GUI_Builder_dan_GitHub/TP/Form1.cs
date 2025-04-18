using System;
using System.Windows.Forms;

namespace tp_modul3_2211104012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.Trim();

            if (!string.IsNullOrEmpty(inputText))
            {
                label_output.Text = "Halo " + inputText;
            }
            else
            {
                label_output.Text = "Silakan masukkan nama!";
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // Tidak perlu isi apa-apa untuk sekarang
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tidak perlu isi apa-apa untuk sekarang
        }
    }
}
