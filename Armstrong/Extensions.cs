using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    public static class Extensions
    {
        public static bool isArmstrong(this int num)
        {
            int potencia = 1;
            if (num >= 10) potencia++;
            if (num >= 100) potencia++;


            int centena = (num - (num % 100)) / 100;
            int unidade = num % 10;
            int dezena = (num - (num - (num % 100)) - unidade) / 10;


            double arstrong = Math.Pow(centena, potencia) + Math.Pow(dezena, potencia) + Math.Pow(unidade, potencia);

            if (arstrong == num) return true;
            else return false;
        }
    }
}
