namespace Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new Motor(1.7f);
            Motor motor2 = new Motor(1.8f);
            Motor motor3 = new Motor(2.5f);
            Carro carro = new Carro("40028922", "Fiat Uno", motor1);
            // Carro carro2 = new Carro("11118922", "Gol Quadrado", motor1);
            Carro carro2 = new Carro("11118922", "Gol Quadrado", motor2);
            //carro.Motor = null;
            carro.Motor = motor3;
            carro2.Motor = motor1;

            Console.WriteLine($"Placa: {carro.placa} | Modelo: {carro.modelo} | Motor: {carro.Motor.cilindrada} | Vel Max: {carro.velocidadeMaxima}");
            Console.WriteLine($"Placa: {carro2.placa} | Modelo: {carro2.modelo} | Motor: {carro2.Motor.cilindrada} | Vel Max: {carro2.velocidadeMaxima}");
        }
    }
}
