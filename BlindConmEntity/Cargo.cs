﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindConmEntity
{
    public class Cargo
    {
        public int IdCargo { get; set; }
        public string NomeCargo{ get; set; }
        List<Cargo> cargos { get; set; }

    }
}
