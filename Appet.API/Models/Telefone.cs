using System;

namespace Appet.API.Models
{
    [Serializable]
    public class Telefone : Identificacao
    {
        public int DDD { get; set; }

        public int Numero { get; set; }
    }
}