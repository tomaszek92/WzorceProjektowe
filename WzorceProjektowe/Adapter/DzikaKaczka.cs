using System;

namespace WzorceProjektowe.Adapter
{
    public class DzikaKaczka : IKaczka
    {
        public void Kwacz()
        {
            Console.WriteLine($"{GetType().Name}: Kwacze...");
        }

        public void Lataj()
        {
            Console.WriteLine($"{GetType().Name}: Latam...");
        }
    }
}