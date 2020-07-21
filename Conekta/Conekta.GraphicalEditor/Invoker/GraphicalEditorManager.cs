using Conekta.GraphicalEditor.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Invoker
{
    public class GraphicalEditorManager
    {
        private List<ICommand> commands = new List<ICommand>();

        public void Invoke(ICommand command) 
        {
            if (command.CanExecute())
            {
                commands.Add(command);
                command.Execute();
            }
        }
    }
}
