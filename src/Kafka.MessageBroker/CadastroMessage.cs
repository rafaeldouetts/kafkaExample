using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.MessageBroker
{
    public class CadastroMessage
    {
        private const int CpfLength = 11;
        private const int TelefoneLength = 10;
        private const int SenhaMinLength = 6;

        public CadastroMessage(string cpf, string nomeCompleto, string telefone, string email, DateTime dataNascimento, string senha = null)
        {
            Cpf = cpf;
            NomeCompleto = nomeCompleto;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            Senha = senha;
        }

        public string Cpf { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        //PDV nao informa senha
        public string? Senha { get; set; }
        public string? SenhaConfirmacao { get; set; }

        public bool IsValid()
        {
            // Validação do CPF
            if (string.IsNullOrEmpty(Cpf) || Cpf.Length != CpfLength)
            {
                return false;
            }

            // Validação do telefone
            if (string.IsNullOrEmpty(Telefone) || Telefone.Length != TelefoneLength)
            {
                return false;
            }

            // Validação do e-mail (pode ser mais complexa)
            if (string.IsNullOrEmpty(Email) || !Email.Contains("@"))
            {
                return false;
            }

            // Outras validações, se necessário...

            return true;
        }
    }
}
