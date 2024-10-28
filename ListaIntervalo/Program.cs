namespace ListaIntervalo
{
    using Intervalo;
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Intervalo inter = new Intervalo(new DateTime(2024, 10, 27, 20, 15, 00), new DateTime(2024, 10, 27, 20, 30, 00));
            Intervalo inter2 = new Intervalo(new DateTime(2024, 10, 27, 20, 10, 00), new DateTime(2024, 10, 27, 20, 14, 00));
            Intervalo inter3 = new Intervalo(new DateTime(2024, 10, 27, 20, 00, 00), new DateTime(2024, 10, 27, 21, 00, 00));
            ListaIntervalo lst = new ListaIntervalo();
            lst.Add(inter);
            lst.Add(inter2);
            lst.Add(inter3);
            foreach (Intervalo intervalo in lst.intervalos) {
                Console.WriteLine($"Inicio: {intervalo.inicio} - Fim: {intervalo.fim} - Duração: {intervalo.duracao}");
            }
        }
    }
}
