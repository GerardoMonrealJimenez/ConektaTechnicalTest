using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class ColorPixelImageCommand : ImageCommand
    {

        protected int x;
        protected int y;
        protected string color;
        public ColorPixelImageCommand(Image image, string command) : base(image, command)
        {
        }

        public override void Execute()
        {
            image.ColorPixel(x - 1, y - 1, color);
        }

        public override bool validateCommand()
        {
            if (!(commandSplit.Length == 4)) return false;
            if (!int.TryParse(commandSplit[1], out x)) return false;
            if (!int.TryParse(commandSplit[2], out y)) return false;
            if (x > image.GetCountColumns()) return false;
            if (y > image.GetCountRows()) return false;
            if (commandSplit[3].Any(x => !char.IsLetter(x))) return false;
            color = commandSplit[3];
            return true;
        }
    }
}
