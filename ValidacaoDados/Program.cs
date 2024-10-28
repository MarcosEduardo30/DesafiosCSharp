namespace ValidacaoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();

            while (true)
            {
                Console.Write("Digite o seu nome: ");
                cliente.Nome = Console.ReadLine().Trim();
                if (cliente.Nome.isNomeValid()) break;
                else Console.WriteLine("Nome deve conter mais do que 5 dígitos");
            }

            while (true)
            {
                Console.Write("Digite o seu CPF: ");
                cliente.CPF = Console.ReadLine().Trim();
                if (cliente.CPF.isCPFValid()) break;
                else Console.WriteLine("CPF inválido. Favor Verificar o CPF digitado.");
            }

            while (true)
            {
                Console.Write("Digite a sua data de nascimento: ");

                cliente.DataNascimento = DateTime.Parse(Console.ReadLine().Trim());
                if (cliente.DataNascimento.isDataNascValid()) break;
                else Console.WriteLine("Você deve possuir mais de 18 anos para ser um cliente");
            }


            while (true)
            {
                Console.Write("Digite a sua renda mensal: ");
                cliente.RendaMensal = float.Parse(Console.ReadLine().Trim());
                if (cliente.RendaMensal.isRendaValid()) break;
                else Console.WriteLine("Sua renda não pode ser negativa!");
            }

            while (true)
            {
                Console.Write("Digite o seu estado civil: ");
                cliente.EstadoCivil = Char.Parse(Console.ReadLine().Trim());
                if (cliente.EstadoCivil.isEstadoCivilValid()) break;
                else Console.WriteLine("Digite um estado civil válido!");
            }

            while (true)
            {
                Console.Write("Digite quantos dependentes você tem: ");
                cliente.Dependentes = Int32.Parse(Console.ReadLine().Trim());
                if (cliente.Dependentes.isDependentesValid()) break;
                else Console.WriteLine("A quantidade de dependentes deve ser entre 0 e 10");
            }

            Console.WriteLine($"O seu nome é: {cliente.Nome}");
            Console.WriteLine($"O seu CPF é: {cliente.CPF}");
            Console.WriteLine($"Sua data de nascimento é: {cliente.DataNascimento.Day}/{cliente.DataNascimento.Month}/{cliente.DataNascimento.Day}");
            Console.WriteLine($"Sua renda mensal é {cliente.RendaMensal.ToString("0.00")}");
            Console.WriteLine($"Seu estado civil é {cliente.EstadoCivil}");
            Console.WriteLine($"Você possui {cliente.Dependentes} dependentes");
        }

    }
}
