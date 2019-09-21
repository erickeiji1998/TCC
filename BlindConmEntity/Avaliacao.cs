using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindConmEntity
{
    public class Avaliacao
    {
        public int IdAvaliacao { get; set; }
        public int UsuarioAvaliado { get; set; }
        public int UsuarioAvaliador { get; set; }
        public int Nota { get; set; }
        public DateTime DtAvaliacao{ get; set; }

    }
}
