namespace WzorceProjektowe.Fabryka.Laptopy
{
    public class LenovoLaptop : Laptop
    {
        public override string WyswietlDane()
        {
            return $"Lenovo, {base.WyswietlDane()}";
        }
    }
}