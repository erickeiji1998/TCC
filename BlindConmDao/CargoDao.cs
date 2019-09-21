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
    public class CargoDao : ConexaoBase

    {

        public List<Cargo> ListarCargos(Cargo cargo)
        {
            List<Cargo> listacargo = new List<Cargo>();
            
            using(var conexaoBD = this.Conexao())
            {
                listacargo = conexaoBD.Query<Cargo>(@"PRC_LISTAR_CARGO @IdCargo, @NomeCargo", cargo).ToList();
            }
            return listacargo;
        }

    }
}
