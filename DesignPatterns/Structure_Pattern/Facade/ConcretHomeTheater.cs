namespace DesignPatterns.Structure_Pattern.Facade
{
    public class ConcretHomeTheater : IHomeTheater
    {
        private IAmplifier _amp;
        private ITuner _tuner;
        private IDvdPlayer _dvd;
        private ICdPlayer _cd;
        private IProjector _projector;
        private ITheaterLight _lights;
        private IScreen _screen;

        public ConcretHomeTheater(IAmplifier amplifier, ITuner tuner, IDvdPlayer dvdPlayer, ICdPlayer cdPlayer, IProjector projector, ITheaterLight theaterLight, IScreen screen)
        {
            this._amp = amplifier;
            this._tuner = tuner;
            this._dvd = dvdPlayer;
            this._cd = cdPlayer;
            this._projector = projector;
            this._lights = theaterLight;
            this._screen = screen;
        }
        public void WatchMovie(string movie)
        {
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Eject();
            _dvd.Off();
            _lights.On();
        }

        public void ListenTCd(string cd)
        {
            _lights.Off();
            _amp.On();
            _amp.SetSurroundSound();
            _amp.SetVolume(30);
            _cd.On();
            _cd.Play(cd);
        }

        public void EndCd()
        {
            _lights.On();
            _amp.Off();
            _cd.Eject();
            _cd.Off();
        }

        public void ListenToRadio(string station)
        {
            _amp.On();
            _amp.SetSurroundSound();
            _amp.SetVolume(89);
            _tuner.Adjust();
            _tuner.SetStation(station);
        }

        public void EndRadio()
        {
            _amp.Off();
        }
    }
}