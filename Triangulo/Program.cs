
namespace Triangulo
{
    using Vertice;
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice vert1 = new Vertice(0,9);
            Vertice vert2 = new Vertice(0,5);
            Vertice vert3 = new Vertice(3, 7);

            Triangulo triangulo = new Triangulo(vert1 , vert2 , vert3 );


            Console.WriteLine($"O perimetro do triangulo é {triangulo.perimetro}");
            Console.WriteLine($"O tipo do triangulo é {triangulo.Tipo}");
            Console.WriteLine($"A área do triangulo é {triangulo.area}");
        }
    }
}
