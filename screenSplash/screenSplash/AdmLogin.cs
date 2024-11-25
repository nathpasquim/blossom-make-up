using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace screenSplash
{
    public partial class AdmLogin : Form
    {
        public AdmLogin()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário Form1
            Forml forml = new Forml();

            // Exibe o formulário Form1
            forml.Show();

            // (Opcional) Esconde o formulário atual
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário Form1
            Forml forml = new Forml();

            // Exibe o formulário Form1
            forml.Show();

            // (Opcional) Esconde o formulário atual
            this.Hide();
        }
    }
}
