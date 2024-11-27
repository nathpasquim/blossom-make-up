using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlossimMakeup
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
            panel2.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
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



        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        //Botao Media
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        //Sub Media
        private void button2_Click(object sender, EventArgs e)
        {

            openChildForm(new cadastroProduto());


            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //Botao Playlist
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
        // Sub Playlist
        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastroFunc());
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        //Botão Equalizer
        private void btnEqualizer_Click(object sender, EventArgs e)
        {

        }
        //Botao Tool (cliente)
        private void bntTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        //Sub Tool
        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastroClien());
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        //Botao Help
        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
        //Botao Venda
        private void btnVenda_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }
        //Sub Vend
        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastroVenda());
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

        private void panelPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
