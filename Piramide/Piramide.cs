namespace Piramide
{
    public class Piramide
    {
        public int N { get; set; }

        public Piramide( int N)
        {
            if (N < 1) throw new ArgumentException("Valor de N deve ser maior do que 1");

            this.N = N;

        }

        public void Desenha()
        {
            for (int x = 1; x <= this.N; x++)
            {
                for (int y = 1; y <= x; y++) {
                    Console.Write(y);
                }

                if (x != 1) {
                    for (int y = x - 1; y >= 1; y--) {
                        Console.Write(y); 
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
