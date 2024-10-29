namespace ValidacaoDados
{
    public static class ValidationExtensions
    {
        public static bool isNomeValid(this string nome)
        {
            if (nome.Length < 5) return false;
            else return true;
        }

        public static bool isCPFValid(this string CPF)
        {
            if (CPF.Length != 11) return false;
            else if (isAllNumbersTheSame(CPF)) return false;
            else if (!isDigitoVerificadorValid(10, CPF)) return false;
            else if (!isDigitoVerificadorValid(11, CPF)) return false;
            else return true;

        }

        public static bool isAllNumbersTheSame(string CPF)
        {
            for (int i = 0; i < CPF.Length - 2; i++)
            {
                if (CPF[i] != CPF[i + 1]) return false;
            }
            return true;
        }

        public static bool isDigitoVerificadorValid(int posicaoDigito, string CPF)
        {
            int somaDigitos = 0;
            int valMultiplicacao = posicaoDigito;
            for (int i = 0; i < posicaoDigito - 1; i++) {
                somaDigitos += int.Parse(CPF[i].ToString()) * valMultiplicacao;
                valMultiplicacao--;
            }
            int resto = somaDigitos % 11;
            string digito = resto == 0 || resto == 1 ? "0" : (11 - resto).ToString();

            if (CPF[posicaoDigito - 1].ToString() == digito) return true; 
            else return false;

        }

        public static bool isDataNascValid(this DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Now;
            int idade = 0;
            if (dataNasc.Month > dataAtual.Month) idade = dataAtual.Year - dataNasc.Year;
            else idade = dataAtual.Year - dataNasc.Year - 1;

            if (idade >= 18) return true;
            else return false;
        }

        public static bool isRendaValid(this float renda)
        {
            if (renda >= 0) return true;
            else return false;
        }

        public static bool isEstadoCivilValid(this char estadoCivil)
        {
            if (estadoCivil == 'C' || estadoCivil == 'S' || estadoCivil == 'V' || estadoCivil == 'D') return true;
            else return false;
        }

        public static bool isDependentesValid(this int dependentes)
        {
            if (dependentes >= 0  && dependentes <= 10) return true;
            else return false;
        }
    }
}
