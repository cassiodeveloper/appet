using System;

namespace Appet.API.Models.Interfaces
{
    public interface IAuditoria
    {
        DateTime DataCadastro { get; set; }
        DateTime UltimaAtualizacao { get; set; }
    }
}