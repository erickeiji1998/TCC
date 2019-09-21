using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlindConmEntity;
using Dapper;

namespace BlindConmDao
{
    public class AvaliacaoDao:ConexaoBase
    {
        public List<Avaliacao> ListarAvaliacoes(Avaliacao avaliacao)
        {
            List<Avaliacao> avaliacoes;
            using (SqlConnection conexaoDB = this.Conexao())
            {
                avaliacoes = conexaoDB.Query<Avaliacao>(@"").ToList();
            }
            return avaliacoes;
        }

        public bool InserirAvaliacao(Avaliacao avaliacao)
        {
            int qtdInserida;
            using (SqlConnection conexaoDB = this.Conexao())
            {
                qtdInserida = conexaoDB.Execute(@"");
                
            }
            return qtdInserida > -1 ||  qtdInserida > 0;
        }

        public bool AlterarAvaliacao(int idAvaliacao)
        {
            int qtdAlterada;
            using (SqlConnection conexaoDB = this.Conexao())
            {
                qtdAlterada = conexaoDB.Execute(@"");
            }
            return qtdAlterada > 0 || qtdAlterada > -1;
        }
    }
}
