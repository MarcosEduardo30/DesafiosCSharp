namespace Vertice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice vert1 = new Vertice(3, 3.5);
            Vertice vert2 = new Vertice(3, 4);

            Console.WriteLine(vert1.Distancia(vert2));

            vert1.Move(3, 5);
            Console.WriteLine(vert1.isEqual(vert2));

            vert2.Move(3, 5);
            Console.WriteLine(vert2.isEqual(vert1));

        }
    }
}
