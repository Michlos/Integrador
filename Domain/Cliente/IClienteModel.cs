using System;

namespace Integrador.Domain.Cliente
{
    public interface IClienteModel
    {
        long IdOnBlox { get; set; }
        string bairro { get; set; }
        int cep { get; set; }
        string cgc { get; set; }
        string cidade { get; set; }
        string codigo { get; set; }
        string fantasia { get; set; }
        string fone { get; set; }
        long Id { get; set; }
        string integracao { get; set; }
        string logradouro { get; set; }
        string nome { get; set; }
        string numero { get; set; }
        string tpDoc { get; set; }
        string uf { get; set; }
        bool integrado { get; set; }
        DateTime DataCriacao { get; set; }
        DateTime DataIntegracao { get; set; }
    }
}