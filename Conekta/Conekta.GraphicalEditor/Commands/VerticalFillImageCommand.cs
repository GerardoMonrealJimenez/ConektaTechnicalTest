using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class VerticalFillImageCommand : ImageCommand
    {
        private int x;
        private int y1;
        private int y2;
        private string color;
        public VerticalFillImageCommand(Image image, string command) : base(image, command)
        {
        }

        public override void Execute()
        {
            image.VerticalFill(x - 1, y1 -1, y2 -1, color);
        }

        public override bool validateCommand()
        {
            if (!(commandSplit.Length == 5)) return false;
            if (!int.TryParse(commandSplit[1], out x)) return false;
            if (!int.TryParse(commandSplit[2], out y1)) return false;
            if (!int.TryParse(commandSplit[3], out y2)) return false;
            if (x > image.GetCountColumns()) return false;
            if (y1 > image.GetCountRows()) return false;
            if (y2 > image.GetCountRows()) return false;
            if (commandSplit[4].Any(x => !char.IsLetter(x))) return false;
            color = commandSplit[4];
            return true;
        }
    }
}
