namespace WzorceProjektowe.Dekorator.Napoje
{
    public abstract class Napoj
    {
        public virtual string Opis => "Napoj nieznany";
        public abstract decimal Cena { get; }
    }
}