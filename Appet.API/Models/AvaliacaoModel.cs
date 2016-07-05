using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appet.API.Models
{
    public class AvaliacaoModel : IdentificacaoModel
    {
        public EstabelecimentoModel Estabelecimento { get; set; }
        public UsuarioModel Usuario { get; set; }
        public int Atendimento { get; set; }
        public int Localizacao { get; set; }
        public int Qualidade { get; set; }
        public string Comentario { get; set; }
        public DateTime Data { get; set; }
    }
}