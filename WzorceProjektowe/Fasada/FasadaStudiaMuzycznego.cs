using WzorceProjektowe.Fasada.Kontrakty;

namespace WzorceProjektowe.Fasada
{
    public class FasadaStudiaMuzycznego
    {
        private readonly IOdtwarzaczCd _odtwarzaczCd;
        private readonly IOswietlenie _oswietlenie;
        private readonly IWzmaczniacz _wzmaczniacz;

        public FasadaStudiaMuzycznego(IOdtwarzaczCd odtwarzaczCd, IOswietlenie oswietlenie, IWzmaczniacz wzmaczniacz)
        {
            _odtwarzaczCd = odtwarzaczCd;
            _oswietlenie = oswietlenie;
            _wzmaczniacz = wzmaczniacz;
        }

        public void OdtwarzajCd()
        {
            _oswietlenie.Sciemnij();
            _wzmaczniacz.Wlacz();
            _odtwarzaczCd.Wlacz();
            _odtwarzaczCd.WysunDysk();
            _wzmaczniacz.UstawGlosnosc();
            _odtwarzaczCd.Odtwarzaj();
        }
    }
}