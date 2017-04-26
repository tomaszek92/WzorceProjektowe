using WzorceProjektowe.Obserwator.Kontrakty;

namespace WzorceProjektowe.Obserwator
{
    public class Pogoda
    {
        public int Temperatura { get; set; }
        public int Wilgotnosc { get; set; }
        public Zachmurzenie Zachmurzenie { get; set; }
        public int Opady { get; set; }
        public int Cisnienie { get; set; }
    }
}