using System.Collections.Generic;
using System.Linq;
using Command.Command;

namespace Command.Invoker
{
    public class Invoker
    {
        private readonly List<ICommand> _commands;
        private ICommand _command;
 
        public Invoker()
        {
            _commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
 
        public void Invoke()
        {
            _commands.Add(_command);
            _command.ExecuteCommand();
        }

        public void UndoActions()
        {
            foreach (var command in Enumerable.Reverse(_commands))
            {
                command.UndoAction();
            }
        }
    }
}