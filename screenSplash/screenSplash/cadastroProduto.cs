using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace screenSplash
{
    public partial class cadastroProduto : Form

    {
        // String de conexão (modifique conforme necessário)
        string connectionString = "server=127.0.0.1;database=blossommakeup;uid=root;pwd=;";

        public cadastroProduto()
        {
            InitializeComponent();
            CarregarComboBoxes();
        }

        private void CarregarComboBoxes()
        {
            // Preenche os comboboxes com dados do banco
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Preenche o comboTipo
                    MySqlCommand cmdTipo = new MySqlCommand("SELECT codigo, nome FROM tipo", conn);
                    using (MySqlDataReader drTipo = cmdTipo.ExecuteReader())
                    {
                        while (drTipo.Read())
                        {
                            comboTipo.Items.Add(new ComboBoxItem
                            {
                                Text = drTipo["nome"].ToString(),
                                Value = drTipo["codigo"].ToString()
                            });
                        }
                    }

                    // Preenche o comboMarca
                    MySqlCommand cmdMarca = new MySqlCommand("SELECT codigo, nome FROM marca", conn);
                    using (MySqlDataReader drMarca = cmdMarca.ExecuteReader())
                    {
                        while (drMarca.Read())
                        {
                            comboMarca.Items.Add(new ComboBoxItem
                            {
                                Text = drMarca["nome"].ToString(),
                                Value = drMarca["codigo"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar combos: " + ex.Message);
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            // Validação básica
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                comboTipo.SelectedItem == null ||
                comboMarca.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Comando SQL para inserir o produto
                    string query = "INSERT INTO produto (codigo, preco, quantidade, FK_tipo_codigo, FK_marca_codigo) " +
                                   "VALUES (NULL, @preco, 1, @tipo, @marca)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@preco", Convert.ToInt32(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@tipo", ((ComboBoxItem)comboTipo.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@marca", ((ComboBoxItem)comboMarca.SelectedItem).Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                }
            }
        }
    }

    // Classe para associar texto e valor nos comboboxes
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
    

