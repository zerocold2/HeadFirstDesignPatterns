namespace DesignPatterns.Structure_Pattern.Facade
{
    public interface ITheaterLight
    {
        void On();
        void Off();
        void Dim(int value);
    }
}