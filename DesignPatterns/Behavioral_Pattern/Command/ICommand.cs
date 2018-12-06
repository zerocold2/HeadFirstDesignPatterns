namespace DesignPatterns.Behavioral_Pattern.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}