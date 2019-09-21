using BlindConmDao;
using BlindConmEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindComnBusiness
{
    public class AvaliacaoBusiness
    {
        private readonly AvaliacaoDao Dao = new AvaliacaoDao();
         public List<Avaliacao> ListarAvaliacoes(Avaliacao avaliacao)
        {
            try
            {
                List<Avaliacao> avaliacoes = Dao.ListarAvaliacoes(avaliacao);
                return avaliacoes.Count > 0 ? avaliacoes : new List<Avaliacao>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool InserirAvaliacao(Avaliacao avaliacao)
        {
            try
            {
                bool inserido = Dao.InserirAvaliacao(avaliacao);
                return inserido;
            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }

        public bool AtualizarAvaliacao(int IdAvaliacao)
        {
            try
            {
                bool alterado = Dao.AlterarAvaliacao(IdAvaliacao);
                return alterado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
