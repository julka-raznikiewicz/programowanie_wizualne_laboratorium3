using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_wizualne_lab3
{
    [Serializable]
    public class Osoba
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Stanowisko { get; set; }
    }


}
