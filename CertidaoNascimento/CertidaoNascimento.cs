using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertidaoNascimento
{
    public class CertidaoNascimento
    {
        readonly Pessoa pessoa;
        DateTime dataEmissao;

        public CertidaoNascimento(Pessoa pessoa, DateTime dataEmissao)
        {
            this.pessoa = pessoa;
            this.dataEmissao = dataEmissao;
        }
    }
}
