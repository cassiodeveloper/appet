using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appet.API.Models
{
    public class CidadeModel : IdentificacaoModel
    {
        public string Nome { get; set; }
        public EstadoModel Estado { get; set; }
    }
}