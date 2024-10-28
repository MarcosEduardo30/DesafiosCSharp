namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int n = 1; n < 1000; n++)
            {
                if (n.isArmstrong()) Console.WriteLine(n);
            }
        }
    }
}
