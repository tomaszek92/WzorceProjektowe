namespace WzorceProjektowe.Adapter
{
    public class IndykAdapter : IKaczka
    {
        private readonly IIndyk _indyk;

        public IndykAdapter(IIndyk indyk)
        {
            _indyk = indyk;
        }

        public void Kwacz()
        {
            _indyk.Gulgocz();
        }

        public void Lataj()
        {
            _indyk.Lataj();
        }
    }
}