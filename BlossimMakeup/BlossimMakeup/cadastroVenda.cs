using MySqlConnector;
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
    public partial class cadastroVenda : Form
    {
       
        private string connectionString = "Server=127.0.0.1;Database=blossommakeup;Uid=root;Pwd=;";
        public cadastroVenda()
        {
            InitializeComponent();
            CarregarFuncionarios();
            CarregarProdutos();
        }

        // Carrega nomes dos funcionários no comboFunc
        private void CarregarFuncionarios()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT codigo, nome FROM funcionario";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboFunc.DataSource = dt;
                comboFunc.DisplayMember = "nome";
                comboFunc.ValueMember = "codigo";
            }
        }

        // Carrega nomes dos produtos no comboProd
        private void CarregarProdutos()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT codigo, nome FROM produto";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboProd.DataSource = dt;
                comboProd.DisplayMember = "nome";
                comboProd.ValueMember = "codigo";
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (comboFunc.SelectedValue != null && !string.IsNullOrEmpty(txtClien.Text) && produtosSelecionados.Count > 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Inicia uma transação
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insere a venda na tabela 'venda'
                        string insertVenda = "INSERT INTO venda (funcionario, cliente, valor) VALUES (@funcionario, @cliente, @valor )";
                        MySqlCommand cmdVenda = new MySqlCommand(insertVenda, conn, transaction);
                        cmdVenda.Parameters.AddWithValue("@funcionario", comboFunc.Text);
                        cmdVenda.Parameters.AddWithValue("@cliente", txtClien.Text);
                        cmdVenda.Parameters.AddWithValue("@valor", valorTotal);
                        //  cmd.Parameters.AddWithValue("@nome", t);

                        cmdVenda.ExecuteNonQuery();

                        int vendaId = (int)cmdVenda.LastInsertedId;

                        // Insere os produtos relacionados na tabela 'vendaproduto'
                        foreach (int produtoId in produtosSelecionados)
                        {
                            string insertVendaProduto = "INSERT INTO vendaproduto (FK_produto_codigo, FK_venda_codigo) VALUES (@produto, @venda)";
                            MySqlCommand cmdVendaProduto = new MySqlCommand(insertVendaProduto, conn, transaction);
                            cmdVendaProduto.Parameters.AddWithValue("@produto", produtoId);
                            cmdVendaProduto.Parameters.AddWithValue("@venda", vendaId);
                            cmdVendaProduto.ExecuteNonQuery();
                        }

                        // Confirma a transação
                        transaction.Commit();
                        MessageBox.Show("Venda cadastrada com sucesso!");

                        // Limpa os campos
                        txtClien.Clear();
                        txtValor.Clear();
                        produtosSelecionados.Clear();
                        listBoxProdutos.Items.Clear();
                        valorTotal = 0;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao cadastrar venda: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos e adicione ao menos um produto.");
            }
        }

        private void txtFiltroProduto_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT codigo, nome FROM produto WHERE nome LIKE @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", "%" + txtFiltroProduto.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboProd.DataSource = dt;
                comboProd.DisplayMember = "nome";
                comboProd.ValueMember = "codigo";
            }
        }
        private List<int> produtosSelecionados = new List<int>();
        private decimal valorTotal = 0;

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (comboProd.SelectedValue != null)
            {
                int codigoProduto = Convert.ToInt32(comboProd.SelectedValue);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT preco FROM produto WHERE codigo = @codigo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigoProduto);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        decimal preco = Convert.ToDecimal(result);
                        produtosSelecionados.Add(codigoProduto);
                        valorTotal += preco;
                        txtValor.Text = valorTotal.ToString("F2");

                        // Adiciona o produto à lista (visualização)
                        listBoxProdutos.Items.Add(comboProd.Text + " - R$" + preco.ToString("F2"));
                    }
                }
            }
        }
    }
}
