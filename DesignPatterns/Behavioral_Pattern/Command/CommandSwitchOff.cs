namespace DesignPatterns.Behavioral_Pattern.Command
{
    public class CommandSwitchOff : ICommand
    {
        private Receiver _receiver;

        public CommandSwitchOff(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.SwitchOff(); // SwitchOff Command Executes SwitchOff method
        }

        public void Undo()
        {
            _receiver.SwitchOn(); // SwitchOn is the undo for SwitchOff command
        }
    }
}