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
    public partial class CadastroUsuarioForm : Form
    {
        public CadastroUsuarioForm()
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtNovoUsuario.Text;
            string email = txtEmail.Text;
            string senha = txtNovaSenha.Text;
            string empresa = txtEmpresa.Text;
            string telefone = txtTelefone.Text;

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "INSERT INTO usuarios (nome, email, senha, empresa, telefone) VALUES (@nome, @email, @senha, @empresa, @telefone)";
                    using (var cmd = new NpgsqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("nome", usuario);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("senha", senha);
                        cmd.Parameters.AddWithValue("empresa", empresa);
                        cmd.Parameters.AddWithValue("telefone", telefone);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
    }
}