using Npgsql;
using System;
using System.Windows.Forms;

namespace SistemaChamados
{
    public static class InicializadorBanco
    {
        public static void InicializarBancoDeDados()
        {
            string nomeBanco = "sistemachamados";
            string connectionString = "Host=localhost;Username=postgres;Password=;Database=postgres"; // banco padrão postgres

            try
            {
                using (var conexao = new NpgsqlConnection(connectionString))
                {
                    conexao.Open();

                    // Verifica se o banco já existe
                    string verificarSQL = $"SELECT 1 FROM pg_database WHERE datname = '{nomeBanco}'";
                    using (var cmd = new NpgsqlCommand(verificarSQL, conexao))
                    {
                        var resultado = cmd.ExecuteScalar();

                        if (resultado == null)
                        {
                            // Cria o banco se não existir
                            string criarSQL = $"CREATE DATABASE {nomeBanco}";
                            using (var cmdCriar = new NpgsqlCommand(criarSQL, conexao))
                            {
                                cmdCriar.ExecuteNonQuery();
                                MessageBox.Show("Banco de dados 'sistemachamados' criado com sucesso!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar ou criar o banco de dados: " + ex.Message);
            }
        }
    }
}
