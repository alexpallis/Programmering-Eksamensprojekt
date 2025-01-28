namespace Programmering_Eksamensprojekt
{
    public class Størrelse
    {
        public int Masse { get; set; }
        public int Rumfang { get; set; }
        public int Densitet { get; set; }
        public int Tyngdeacceleration { get; set; }
        public int Tyngdekraft { get; set; }
    }

    public class Formler
    {
        public List<int> Mvp { get; set; } // Corresponds to "m=v*p"
        public List<int> Ftmg { get; set; } // Corresponds to "Ft=m*g"
    }

    public class Root
    {
        public Størrelse Størrelse { get; set; }
        public Formler Formler { get; set; }
    }

}
