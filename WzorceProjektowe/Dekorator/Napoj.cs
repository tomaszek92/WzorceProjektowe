namespace WzorceProjektowe.Dekorator
{
    public abstract class Napoj
    {
        public virtual string Opis => "Napoj nieznany";
        public abstract double Cena { get; }
    }
}