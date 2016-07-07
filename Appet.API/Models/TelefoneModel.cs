using System;

namespace Appet.API.Models
{
    [Serializable]
    public class TelefoneModel : IdentificacaoModel
    {
        public int DDD { get; set; }

        public int Telefone { get; set; }
    }
}