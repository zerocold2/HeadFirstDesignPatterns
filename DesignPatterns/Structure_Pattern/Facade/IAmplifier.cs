namespace DesignPatterns.Structure_Pattern.Facade
{
    public interface IAmplifier
    {
        void On();
        void SetDvd(IDvdPlayer dvdPlayer);
        void SetSurroundSound();
        void SetVolume(int volume);
        void Off();
    }
}