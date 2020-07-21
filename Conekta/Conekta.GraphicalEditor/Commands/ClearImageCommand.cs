using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class ClearImageCommand : ImageCommand
    {
        public ClearImageCommand(Image image, string command) : base(image, command)
        {
        }

        public override void Execute()
        {
            image.ClearImage();
        }

        public override bool validateCommand()
        {
            if (commandSplit.Length > 1) return false;
            return true;
        }
    }
}
