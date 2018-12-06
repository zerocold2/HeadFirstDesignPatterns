namespace DesignPatterns.Behavioral_Pattern.Command
{
    public class CommandSwitchOn : ICommand
    {
        private Receiver _receiver; //As A light object

        public CommandSwitchOn(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.SwitchOn();
        }

        public void Undo()
        {
            _receiver.SwitchOff(); // SwitchOff is the undo command for the Executed switchOn Command
        }
    }
}