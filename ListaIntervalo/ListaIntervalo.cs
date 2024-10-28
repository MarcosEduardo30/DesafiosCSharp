namespace ListaIntervalo
{
    using Intervalo;
    using System.Collections.ObjectModel;

    internal class ListaIntervalo
    {
        private List<Intervalo> lstIntervalos;
        public ReadOnlyCollection<Intervalo> intervalos { get => lstIntervalos.AsReadOnly();}

        public ListaIntervalo() { 
            lstIntervalos = new List<Intervalo>();
        }

        public void Add(Intervalo inter)
        {
            foreach (Intervalo intervalo in this.lstIntervalos)
            {
                if (inter.TemIntersecao(intervalo)) return; ;
            }

           this.lstIntervalos.Add(inter);
        }
    }
}
