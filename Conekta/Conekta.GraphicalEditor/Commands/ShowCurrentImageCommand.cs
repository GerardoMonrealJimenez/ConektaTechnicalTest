using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class ShowCurrentImageCommand : ImageCommand
    {
        public ShowCurrentImageCommand(Image image, string command) : base(image, command)
        {

        }
        public override void Execute()
        {
            image.ShowContentImage();
        }

        public override bool validateCommand()
        {
            if (commandSplit.Length == 0) return false;
            return commandSplit[0] == "S";
        }
    }
}
