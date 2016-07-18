using System;

namespace WzorceProjektowe.Adapter
{
    public class DzikiIndyk : IIndyk
    {
        public void Gulgocz()
        {
            Console.WriteLine($"{GetType().Name}: Gulgocze...");
        }

        public void Lataj()
        {
            Console.WriteLine($"{GetType().Name}: Latam...");
        }
    }
}