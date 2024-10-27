namespace Poligono
{
    using Vertice;
    public class Poligono
    {
        public List<Vertice> vertices;
        public int QtdDeVertices { get =>  vertices.Count; }

        public Poligono(List<Vertice> vertices) {
            if (vertices.Count < 3) throw new ArgumentException("Para se criar um poligono é necessário mais que 3 vertices");
            this.vertices = vertices;
        }

        public bool AddVertice(Vertice vertice)
        {
            if (this.vertices.Contains(vertice)) return false;

            this.vertices.Add(vertice);
            return true;
        }

        public void RemoveVertice(Vertice vertice) { 
            this.vertices.Remove(vertice);
            if (this.vertices.Count < 3) throw new ArgumentException("Ao remover o elemento o poligono ficará com menos de 3 vertices");
        }

        public double getPerimetro()
        {
            double perimetro = 0;
            for (int i = 0; i < this.vertices.Count - 1; i++)
            {
                perimetro += this.vertices[i].Distancia(this.vertices[i + 1]);
            }
            perimetro += this.vertices[this.vertices.Count - 1].Distancia(this.vertices[0]);

            return perimetro;
        }
    }
}
