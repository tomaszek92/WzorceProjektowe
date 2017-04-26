namespace WzorceProjektowe.Fabryka.Laptopy
{
    public class AppleLaptop : Laptop
    {
        public override string WyswietlDane()
        {
            return $"Apple, {base.WyswietlDane()}";
        }
    }
}