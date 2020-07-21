using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class FillImageCommand : ColorPixelImageCommand
    {
        public FillImageCommand(Image image, string command) : base(image, command)
        {
        }

        public override void Execute()
        {
            image.GetPixelColor(x - 1, y - 1);
            image.FloodFill(x - 1, y - 1, color);
        }
    }
}
