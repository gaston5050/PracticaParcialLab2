﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Agente
    {

        public int IdAgente { get; set; }
        public string Nombre { get; set; }
        public string UrlImagen { get; set; }

        public Provincia provincia { get; set; }

    }
}
