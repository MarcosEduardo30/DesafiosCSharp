using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    public class Carro
    {
        readonly public string placa;
        readonly public string modelo;

        private Motor motor;
        public Motor Motor { get=> this.motor; set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.carroInstalado != null) throw new Exception("O motor já está instalado");

                if (this.motor != null) this.motor.carroInstalado = null;
                value.carroInstalado = this;
                this.motor = value;
            }}

        public string velocidadeMaxima { get => calcVelMaxima(); }

        public Carro(string placa, string modelo, Motor motor) { 
            this.placa = placa;
            this.modelo = modelo;
            this.Motor = motor;
        }

        private string calcVelMaxima() {
            if (this.Motor.cilindrada <= 1f) return "140 km/h";
            else if (this.Motor.cilindrada <= 1.6f) return "160 km/h";
            else if (this.motor.cilindrada <= 2f) return "180 km/h";
            else return "220 km/h";

        }
        
    }
}
