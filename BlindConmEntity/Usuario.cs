using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindConmEntity
{
    public class Usuario
    {
        [Required]
        public int IdUsuario { get; set; }
        public int? IdUsuarioAlteracao { get; set; }
        public int IdCargo{ get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Racf { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public int NumeroEndereco { get; set; }
        public DateTime? DtAdmissao { get; set; }
        public DateTime? DtDemissao{ get; set; }
        public bool Ativo { get; set; }
        List<Usuario> ListaUsuario { get; set; }

    }
}
