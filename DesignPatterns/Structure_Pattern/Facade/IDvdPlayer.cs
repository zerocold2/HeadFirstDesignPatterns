namespace DesignPatterns.Structure_Pattern.Facade
{
    public interface IDvdPlayer
    {
        void On();
        void Off();
        void Play(string movie);
        void Eject();
    }
}