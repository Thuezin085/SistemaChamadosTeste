using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados
{
    public class Chamado
    {
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }  // Pode ser "Aberto", "Pendente", "Fechado"
        public string Anexo { get; set; }   // Caminho do arquivo anexo (se houver)

        // Construtor para inicializar os valores do chamado
        public Chamado(string categoria, string descricao, string anexo)
        {
            Categoria = categoria;
            Descricao = descricao;
            Status = "Aberto";  // Chamado começa aberto
            Anexo = anexo;
        }
    }
}

