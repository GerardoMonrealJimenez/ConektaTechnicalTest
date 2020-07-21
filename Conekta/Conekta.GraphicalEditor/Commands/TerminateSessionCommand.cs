using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class TerminateSessionCommand : ICommand
    {
        public bool CanExecute()
        {
            return true;
        }

        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
