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
    public partial class Form1 : Form
    {
        public static int UsuarioLogadoId;

        public Form1()
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


            // ⬇️ Cria o banco e as tabelas se ainda não existirem
            InicializadorBanco.InicializarBancoDeDados(); // Cria o banco "sistemachamados" se não existir
            Conexao.InicializarBanco();                   // Cria as tabelas "usuarios" e "chamados" se não existirem
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = "SELECT id FROM usuarios WHERE nome = @usuario AND senha = @senha";
                    using (var cmd = new NpgsqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("usuario", usuario);
                        cmd.Parameters.AddWithValue("senha", senha);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UsuarioLogadoId = reader.GetInt32(0); // Armazena o ID
                                MessageBox.Show("Login realizado com sucesso!");
                                this.Hide();
                                DashboardForm dashboard = new DashboardForm();
                                dashboard.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha inválidos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUsuarioForm cadastro = new CadastroUsuarioForm();
            cadastro.ShowDialog();
        }
    }
}
