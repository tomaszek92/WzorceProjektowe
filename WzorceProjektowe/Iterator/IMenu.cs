using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace WzorceProjektowe.Iterator
{
    public interface IMenu : IEnumerable
    {
        IMenuIterator UtworzMenuIterator();
    }
}