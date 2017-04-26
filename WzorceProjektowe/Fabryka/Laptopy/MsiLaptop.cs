namespace WzorceProjektowe.Fabryka.Laptopy
{
    public class MsiLaptop : Laptop
    {
        public override string WyswietlDane()
        {
            return $"MSI, {base.WyswietlDane()}";
        }
    }
}