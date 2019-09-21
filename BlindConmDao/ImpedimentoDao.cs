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
    public class ImpedimentoDao : ConexaoBase
    {
        public List<Impedimento> ListarImpedimentos(Impedimento impedimento)
        {
            List<Impedimento> impedimentos;
            using (SqlConnection conexaoDB = this.Conexao())
            {
                impedimentos = conexaoDB.Query<Impedimento>("").ToList();
            }
            return impedimentos;
        }

        public bool InserirImpedimento(Impedimento impedimento)
        {
            int qtdInserida;
            using (SqlConnection conexaoDB = this.Conexao())
            {
                qtdInserida = conexaoDB.Execute("");
            }
            return qtdInserida > 0 && qtdInserida > -1;
        }

        public bool AlterarImpedimento(Impedimento impedimento)
        {
            int qtdAlterada;
            using (SqlConnection conexaoDB = this.Conexao())
            {
                qtdAlterada = conexaoDB.Execute("");
            }
            return qtdAlterada > 0 && qtdAlterada > -1;
        }
    }
}
