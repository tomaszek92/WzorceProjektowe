namespace WzorceProjektowe.Singleton
{
    public sealed class Singleton<T> where T : new()
    {
        private static T _unikalnaInstancja;

        private static readonly object _lock = new object();

        private Singleton()
        {
        }

        public static T PobierzInstancję()
        {
            if (_unikalnaInstancja == null)
            {
                lock (_lock)
                {
                    if (_unikalnaInstancja == null)
                    {
                        _unikalnaInstancja = new T();
                    }
                }
            }

            return _unikalnaInstancja;
        }
    }
}