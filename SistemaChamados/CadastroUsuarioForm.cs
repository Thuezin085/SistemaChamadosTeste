using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaChamados
{
    public partial class CadastroUsuarioForm : Form
    {
        public CadastroUsuarioForm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtNovoUsuario.Text;
            string email = txtEmail.Text;
            string senha = txtNovaSenha.Text;

            // Aqui você armazenaria os dados em um banco ou arquivo.
            MessageBox.Show("Usuário cadastrado com sucesso!");
            this.Close(); // Fecha a tela de cadastro
        }
    }
}