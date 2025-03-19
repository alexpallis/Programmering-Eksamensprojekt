namespace Programmering_Eksamensprojekt
{
    public class Størrelse
    {
        public int Masse { get; set; }
        public int Rumfang { get; set; }
        public int Densitet { get; set; }
        public int Tyngdeacceleration { get; set; }
        public int Tyngdekraft { get; set; }
        public int Hastighed { get; set; }
        public int Tid { get; set; }
        public int Strækning { get; set; }
        public int Arbejde { get; set; }
        public int Kraft {  get; set; }
        public int Kinetiskenergi { get; set; }
        public int Acceleration { get; set; }


    }

    public class Formler
    {
        public List<int> Mvp { get; set; } // Corresponds to "m=v*p"
        public List<int> Ftmg { get; set; } // Corresponds to "Ft=m*g"
        public List<int> vst { get; set; }
        public List<int> AFs { get; set; }
        public List<int> EkA { get; set; }
        public List<int> Ekvm { get; set; }
        public List<int> avt { get; set; }

    }

    public class Root
    {
        public Størrelse Størrelse { get; set; }
        public Formler Formler { get; set; }
    }

}
