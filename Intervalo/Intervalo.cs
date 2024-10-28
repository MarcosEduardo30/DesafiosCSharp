namespace Intervalo
{
    public class Intervalo
    {
        public readonly DateTime inicio;
        public readonly DateTime fim;
        public TimeSpan duracao { get => fim - inicio; }

        public Intervalo(DateTime inicio, DateTime fim)
        {
            if (inicio > fim) throw new ArgumentException("A data/hora de inicio é maior que a data/hora de fim");
            this.inicio = inicio;
            this.fim = fim;
        }

        public bool TemIntersecao(Intervalo inter)
        {
            if (this.inicio > inter.inicio  && this.inicio < inter.fim ) return true;
            else if (this.fim > inter.inicio && this.fim < inter.fim) return true;
            else if (this.inicio < inter.inicio && this.fim > inter.inicio) return true;
            else if (this.inicio < inter.fim && this.fim > inter.fim) return true;
            else return false;
        }

        public bool Equals(Intervalo inter)
        {
            if (inter.inicio == this.inicio && inter.fim == this.fim) return true;
            else return false;
        }
    }
}
