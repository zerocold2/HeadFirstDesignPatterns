using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Pattern.Command
{
    /// <summary>
    /// Assume Invoker as a remote control to control the receiver 
    /// We could send list of commands, or we could have a list off here, and another method to add command on this list and another method to remove form this list, by this way we could attach or de attach a commands to be executed on the receiver
    ///
    /// </summary>
    public class Invoker
    {
        private ICommand _commandOn;
        private ICommand _commandOff;
        public Invoker(ICommand commandOn, ICommand commandOff)
        {
            _commandOn = commandOn;
            _commandOff = commandOff;
        }

        public void ClickOn()
        {
            _commandOn.Execute();
        }

        public void ClickOff()
        {
            _commandOff.Execute();
        }
    }
}
