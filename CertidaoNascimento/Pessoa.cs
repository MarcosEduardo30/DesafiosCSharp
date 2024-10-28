using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertidaoNascimento
{
    public class Pessoa
    {
        public string nome;
        public readonly CertidaoNascimento? certidao;

        public Pessoa(string nome, CertidaoNascimento certidao = null)
        {
            this.nome = nome;
            this.certidao = certidao;
        }
    }
}
