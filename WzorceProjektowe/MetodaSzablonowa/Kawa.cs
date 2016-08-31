using System;

namespace WzorceProjektowe.MetodaSzablonowa
{
    public class Kawa : Napoj
    {
        protected override void Zaparzenie()
        {
            Console.WriteLine("Wsypywanie ziarenek kawy...");
        }
    }
}