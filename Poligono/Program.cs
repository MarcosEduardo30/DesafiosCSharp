namespace Poligono
{
    using Vertice;
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice vert1 = new Vertice(0, 9);
            Vertice vert2 = new Vertice(0, 5);
            Vertice vert3 = new Vertice(3, 7);

            List<Vertice> vertices = new List<Vertice>();
            vertices.Add(vert1);
            vertices.Add(vert2);
            vertices.Add(vert3);

            Poligono poli = new Poligono(vertices);
            Console.WriteLine(poli.getPerimetro());
        }
    }
}
