namespace Triangulo
{
    using Vertice;
    public enum Triangulos
    {
        Equilatero, Isosceles, Escaleno
    }

    public class Triangulo
    {
        private Vertice vert1;
        public Vertice Vert1 { get { return vert1; } }

        private Vertice vert2;
        public Vertice Vert2 { get { return vert2; } }

        private Vertice vert3;
        public Vertice Vert3 { get { return vert3; } }

        private double lado1 { get => vert1.Distancia(vert2);}
        private double lado2 { get => vert1.Distancia(vert3); }
        private double lado3 { get => vert2.Distancia(vert3); }

        public double perimetro { get => lado1 + lado2 + lado3; }

        public Triangulos Tipo { get => this.DefinirTipo(); }

        public double area { get => this.CalculaArea(); }

        public Triangulo(Vertice vert1, Vertice vert2, Vertice vert3) {
            this.vert1 = vert1;
            this.vert2 = vert2;
            this.vert3 = vert3;

            if (isTrianguloDesigual()) throw new ArgumentException("Os 3 vértices passados não formam um triangulo");
        }


        private bool isTrianguloDesigual()
        { 
            if (this.lado1 >= this.lado2 + this.lado3 
                || this.lado2 >= this.lado1 + this.lado3
                || this.lado3 >= this.lado1 + this.lado2) 
                return true;
            else return false;
        }

        private Triangulos DefinirTipo()
        {
            if (this.lado1 == this.lado2 && this.lado2 == this.lado3 && this.lado3 == this.lado1) return Triangulos.Equilatero;
            else if (this.lado1 != this.lado2 && this.lado2 != this.lado3 && this.lado3 != this.lado1) return Triangulos.Escaleno;
            else return Triangulos.Isosceles;

        }

        private double CalculaArea()
        {
            double S = this.perimetro / 2;

            double SA = S - this.lado1;
            double SB = S - this.lado2;
            double SC = S - this.lado3;

            double area = Math.Sqrt(S * SA * SB * SC);

            return area;
        }
    }
}
