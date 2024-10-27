namespace Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intervalo inter = new Intervalo(new DateTime(2024, 10, 27, 20, 15, 00), new DateTime(2024, 10, 27, 20, 30, 00));
            Intervalo inter2 = new Intervalo(new DateTime(2024, 10, 27, 20, 10, 00), new DateTime(2024, 10, 27, 20, 29, 00));
            Console.WriteLine($"Inicio: {inter.inicio}");
            Console.WriteLine($"Inicio: {inter.fim}");
            Console.WriteLine($"Periodo: {inter.duracao}");
            Console.WriteLine($"Intervalo 2 faz intersecção com Intervalo 1? {inter2.TemIntersecao(inter)}");
        }
    }
}
