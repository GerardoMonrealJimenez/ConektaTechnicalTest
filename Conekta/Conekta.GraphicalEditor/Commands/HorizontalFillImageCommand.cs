using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class HorizontalFillImageCommand : ImageCommand
    {
        private int x1;
        private int x2;
        private int y;
        private string color;
        public HorizontalFillImageCommand(Image image, string command) : base(image, command)
        {
        }

        public override void Execute()
        {
            image.HorizontalFill(x1 - 1, x2 - 1, y - 1, color);
        }

        public override bool validateCommand()
        {
            if (!(commandSplit.Length == 5)) return false;
            if (!int.TryParse(commandSplit[1], out x1)) return false;
            if (!int.TryParse(commandSplit[2], out x2)) return false;
            if (!int.TryParse(commandSplit[3], out y)) return false;
            if (x1 > image.GetCountColumns()) return false;
            if (x2 > image.GetCountColumns()) return false;
            if (y > image.GetCountRows()) return false;
            if (commandSplit[4].Any(x => !char.IsLetter(x))) return false;
            color = commandSplit[4];
            return true;
        }
    }
}
