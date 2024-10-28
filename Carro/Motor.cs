using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    public class Motor
    {
        readonly public float cilindrada;
        public Carro? carroInstalado { get; set; }

        public Motor(float cilindrada) { 
            this.cilindrada = cilindrada;
        }
    }
}
