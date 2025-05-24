using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SistemaChamados
{
    public partial class DashboardForm : Form
    {
        // Lista de chamados em memória
        private List<Chamado> chamados = new List<Chamado>();

        // Caminho do anexo selecionado
        private string anexoSelecionado = "";

        public DashboardForm()
        {
            InitializeComponent();

            this.Size = new Size(800, 480);
            this.MaximumSize = new Size(800, 480);
            this.MinimumSize = new Size(800, 480);

            // Travar redimensionamento
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Centralizar na tela
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public void btnCriarChamado_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (cmbCategoria == null || txtDescricao == null || txtAnexo == null)
                {
                    MessageBox.Show("Campos não foram inicializados corretamente.");
                    return;
                }

               
                string categoria = cmbCategoria.SelectedItem?.ToString();
                string descricao = txtDescricao.Text.Trim();
                string anexo = txtAnexo.Text.Trim();

                if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(categoria))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }

              
                try
                {
                    using (var conexao = Conexao.ObterConexao())
                    {
                        string sql = "INSERT INTO chamados (categoria, descricao, status, anexo) VALUES (@categoria, @descricao, @status, @anexo)";
                        using (var cmd = new NpgsqlCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("categoria", categoria);
                            cmd.Parameters.AddWithValue("descricao", descricao);
                            cmd.Parameters.AddWithValue("status", "Aberto");
                            cmd.Parameters.AddWithValue("anexo", anexo);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception exBanco)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + exBanco.Message);
                    return;
                }

                // Atualizar a interface
                AtualizarDataGridView();
                AtualizarGrafico();

                MessageBox.Show("Chamado criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o chamado: " + ex.Message);
            }
        }





        public void AtualizarDataGridView()
        {
            try
            {
                // Limpa as linhas da DataGridView antes de adicionar novas
                dgvChamados.Rows.Clear();

                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT id, categoria, descricao, status, anexo FROM chamados";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            // Preenche a DataGridView com os dados do banco
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string categoria = reader.GetString(1);
                                string descricao = reader.GetString(2);
                                string status = reader.GetString(3);
                                string anexo = reader.GetString(4);

                                dgvChamados.Rows.Add(id, categoria, descricao, status, anexo);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro caso algo dê errado
                MessageBox.Show("Erro ao carregar dados no DataGridView: " + ex.Message);
            }
        }


        private void AtualizarGrafico()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    // Atualizando o gráfico para mostrar apenas chamados abertos ou pendentes
                    string sql = "SELECT categoria, COUNT(*) FROM chamados WHERE status != 'Fechado' GROUP BY categoria";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            chartChamados.Series["Chamados"].Points.Clear(); // Limpa os pontos anteriores

                            while (reader.Read())
                            {
                                string categoria = reader.GetString(0);
                                int count = reader.GetInt32(1);

                                chartChamados.Series["Chamados"].Points.AddXY(categoria, count); // Adiciona os novos pontos
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar gráfico: " + ex.Message);
            }
        }




        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chartChamados_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void btnPendenteChamado_Click(object sender, EventArgs e)
        {
            AtualizarStatusChamado("Pendente");
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Assistente Virtual")
            {
                lblMensagemBot.Text = "Olá! Sou o assistente virtual do Help Desk.\nComo posso ajudar você hoje?";
            }
            else if (tabControl1.SelectedTab.Text == "Preferências")
            {
                CarregarPreferencias();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Preencher a ComboBox de categoria
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Hardware");
            cmbCategoria.Items.Add("Software");
            cmbCategoria.SelectedIndex = 0;

            // 👉 Carrega os chamados do banco
            CarregarChamados();
        }



        private void btnAnexo_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurações do OpenFileDialog
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif|Arquivos PDF|*.pdf|Todos os arquivos|*.*"; 
            openFileDialog.Title = "Selecione um arquivo de anexo";

            // Verifica se o usuário selecionou um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Salva o caminho do arquivo no campo de texto txtAnexo
                txtAnexo.Text = openFileDialog.FileName;
            }

        }
        private void CarregarChamados()
        {
            chamados.Clear();

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT categoria, descricao, status, anexo FROM chamados";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoria = reader.GetString(0);
                            string descricao = reader.GetString(1);
                            string status = reader.GetString(2);
                            string anexo = reader.GetString(3);

                            chamados.Add(new Chamado(categoria, descricao, status, anexo));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados do banco: " + ex.Message);
            }

            AtualizarDataGridView();
            AtualizarGrafico();
        }

        public class Chamado
        {
            public string Categoria { get; set; }
            public string Descricao { get; set; }
            public string Status { get; set; }
            public string Anexo { get; set; }

            // Construtor com 4 parâmetros
            public Chamado(string categoria, string descricao, string status, string anexo)
            {
                Categoria = categoria;
                Descricao = descricao;
                Status = status;
                Anexo = anexo;
            }
        }
        private void AtualizarStatusChamado(string status)
        {
            if (dgvChamados.SelectedRows.Count > 0)
            {
                int index = dgvChamados.SelectedRows[0].Index;
                string descricao = chamados[index].Descricao;

                try
                {
                    using (var conexao = Conexao.ObterConexao())
                    {
                        string sql = "UPDATE chamados SET status = @status WHERE descricao = @descricao";
                        using (var cmd = new NpgsqlCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("status", status);
                            cmd.Parameters.AddWithValue("descricao", descricao);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Atualiza a lista e o DataGridView
                    chamados[index].Status = status;
                    AtualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar status: " + ex.Message);
                }
            }
        }

        public void btnFecharChamado_Click(object sender, EventArgs e)
        {
            if (dgvChamados.SelectedRows.Count > 0)
            {
                // Pega o ID da linha selecionada (primeira coluna, que está oculta)
                int idChamado = Convert.ToInt32(dgvChamados.SelectedRows[0].Cells["Id"].Value);

                // Atualiza o status do chamado para "Fechado" no banco de dados
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "UPDATE chamados SET status = @status WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("status", "Fechado");
                        cmd.Parameters.AddWithValue("id", idChamado);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Atualiza a DataGridView e o gráfico
                AtualizarDataGridView();
                AtualizarGrafico();
            }
            else
            {
                MessageBox.Show("Selecione um chamado para marcar como fechado.");
            }
        }

     
        private void CarregarPreferencias()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT nome, email, senha FROM usuarios WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("id", Form1.UsuarioLogadoId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomePref.Text = reader.GetString(0);
                                txtEmailPref.Text = reader.GetString(1);
                                txtSenhaPref.Text = reader.GetString(2);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar preferências: " + ex.Message);
            }
        }

        private void btnPref_Click(object sender, EventArgs e)
        {
            string nome = txtNomePref.Text;
            string email = txtEmailPref.Text;
            string senha = txtSenhaPref.Text;

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "UPDATE usuarios SET nome = @nome, email = @email, senha = @senha WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("senha", senha);
                        cmd.Parameters.AddWithValue("id", Form1.UsuarioLogadoId);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                            MessageBox.Show("Preferências atualizadas com sucesso!");
                        else
                            MessageBox.Show("Nenhuma alteração foi realizada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar preferências: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Confirmação para o usuário
            var result = MessageBox.Show("Você tem certeza que deseja sair?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Fecha a tela atual (DashboardForm)
                this.Close();

                // Cria uma nova instância do Form1 (LoginForm) e exibe
                Form1 loginForm = new Form1();
                loginForm.Show(); // Exibe o Formulário de Login

                // Fecha o Form1 caso o usuário tente fechar o login e voltar para o Dashboard.
                loginForm.FormClosed += (s, args) => this.Close();
            }
        }

    }
}




