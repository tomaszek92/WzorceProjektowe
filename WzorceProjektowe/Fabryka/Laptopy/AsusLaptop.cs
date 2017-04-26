namespace WzorceProjektowe.Fabryka.Laptopy
{
    public class AsusLaptop : Laptop
    {
        public override string WyswietlDane()
        {
            return $"Asus, {base.WyswietlDane()}";
        }
    }
}