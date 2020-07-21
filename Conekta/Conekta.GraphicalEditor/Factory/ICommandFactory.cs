using Conekta.GraphicalEditor.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Factory
{
    public interface ICommandFactory
    {
        ICommand GetCommand(string command);
    }
}
