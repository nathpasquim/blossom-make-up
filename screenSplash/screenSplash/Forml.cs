using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screenSplash
{
    public partial class Forml : Form
    {
        public Forml()
        {
            InitializeComponent();
            customizeDesing();

        }
        private void customizeDesing()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


// Botão Media//
        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
//Botão Playlist//
        private void button1_Click_2(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
// Subs Media//

        private void button2_Click(object sender, EventArgs e) //Cadastrar Produto
        {

            openChildForm(new cadastroProduto());
            
            
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e) //Visualizar Produto
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e) // Alterar Produto
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e) // Excluir Produto
        {
            hideSubMenu();
        }
// Subs Playlist//
        private void button9_Click_1(object sender, EventArgs e)
        {
            openChildForm(new cadastroFunc());
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
// Região Tools//
        private void bntTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastroCliente());
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

//Botão Help//
        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

//Botão Equalizer//
        private void btnEqualizer_Click(object sender, EventArgs e)
        {


            openChildForm(new Form3());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
