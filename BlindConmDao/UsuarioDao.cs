using BlindConmEntity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindConmDao
{
    public class UsuarioDao : ConexaoBase
    {

        public bool AdicionarUsuario(Usuario usuario)
        {
            using (var conexaoBD = this.Conexao())
            {
                var retorno = conexaoBD.Execute(@"",usuario);
                return retorno > 0;
            }
        }

        public List<Usuario> ListarUsuarios(Usuario usuario)
        {
            List<Usuario> retorno = new List<Usuario>();
            using (var conexaoBD = this.Conexao())
            {
                retorno = conexaoBD.Query<Usuario>(@"PRC_LISTAR_USUARIO @IdUsuario  ,	@NomeUsuario ,	@Racf ,	@CPF  ,	@CEP  ,	@NumeroEndereco  ,	@DtAdmissao  ,	@DtDemissao ,	@IdCargo ,	@IdUsuarioAlteracao ,	@Senha ,	@Ativo ", usuario).ToList();
            }
            return retorno;
        }

        public bool UpdateUsuario(Usuario usuario)
        {
            int retorno;
            using (var conexaoBD = this.Conexao())
            {
                retorno = conexaoBD.Execute(@"");

            }
            return retorno > 0;
        }
        public bool DeletarUsuario(int idUsuario = 0, string racf = "")
        {
            using (var conexaoBD = this.Conexao())
            {
                int retorno = conexaoBD.Execute(@"");
                return retorno > 0;
            }
        }
    }
}
