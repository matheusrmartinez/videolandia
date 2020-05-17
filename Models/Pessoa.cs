using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public int CodigoPessoa { get; set; }
        public char Funcionario { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string SituacaoPagamentos { get; set; }
    }
}
