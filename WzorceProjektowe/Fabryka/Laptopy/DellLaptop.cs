namespace WzorceProjektowe.Fabryka.Laptopy
{
    public class DellLaptop : Laptop
    {
        public override string WyswietlDane()
        {
            return $"Dell, {base.WyswietlDane()}";
        }
    }
}