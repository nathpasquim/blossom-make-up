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
    public partial class menuFunc : Form
    {
        public menuFunc()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelMediaSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            panel2.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
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

        //Botao Media (Produto)
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        //Subs Media (produto)
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastroProduto());


            hideSubMenu();
        }
        //Botao Tools (cliente)
        private void bntTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);

        }
        //Subs Tools (cliente)
        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastroClien());
            hideSubMenu();
        }
        //Botao Venda
        private void btnVenda_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

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
    }
}
