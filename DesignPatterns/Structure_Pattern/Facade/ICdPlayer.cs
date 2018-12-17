namespace DesignPatterns.Structure_Pattern.Facade
{
    public interface ICdPlayer
    {
        void On();
        void Off();
        void Play(string cd);
        void Eject();
    }
}