using Npgsql;
using System;
using System.Windows.Forms;

namespace SistemaChamados
{
    public class Conexao
    {
        private static string servidor = "localhost";
        private static string porta = "5432";
        private static string usuario = "postgres";
        private static string banco = "sistemachamados";

        // Sem o campo "Password"
        private static string conexaoString = $"Host={servidor};Port={porta};Username={usuario};Database={banco}";

        public static NpgsqlConnection ObterConexao()
        {
            var conexao = new NpgsqlConnection(conexaoString);
            conexao.Open();
            return conexao;
        }

        // ⬇️ Este é o método que faltava
        public static void InicializarBanco()
        {
            try
            {
                using (var conexao = ObterConexao())
                {
                    string sqlUsuarios = @"
                        CREATE TABLE IF NOT EXISTS usuarios (
                            id SERIAL PRIMARY KEY,
                            nome TEXT NOT NULL,
                            email TEXT NOT NULL,
                            senha TEXT NOT NULL,
                            empresa TEXT,
                            telefone TEXT
                        );
                    ";

                    string sqlChamados = @"
                        CREATE TABLE IF NOT EXISTS chamados (
                            id SERIAL PRIMARY KEY,
                            usuario_id INTEGER REFERENCES usuarios(id),
                            categoria TEXT NOT NULL,
                            descricao TEXT NOT NULL,
                            status TEXT NOT NULL,
                            anexo TEXT
                        );
                    ";

                    using (var cmd = new NpgsqlCommand(sqlUsuarios, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new NpgsqlCommand(sqlChamados, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar tabelas do banco de dados: " + ex.Message);
            }
        }
    }
}

