using Conekta.GraphicalEditor.Commands;
using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Factory
{
    public class CommandFactory : ICommandFactory
    {
        private readonly Image image;

        public CommandFactory(Image image)
        {
            this.image = image;
        }

        public ICommand GetCommand(string command)
        {
            var commands = command?.Split(' ');
            if (commands.Length == 0) throw new ArgumentException(nameof(command));
            CommandType type;
           if(!Enum.TryParse(commands[0], out type)) throw new ArgumentException(nameof(command));
            switch (type)
            {
                case CommandType.I:
                    return new CreateImageCommand(image, command);
                case CommandType.C:
                    return new ClearImageCommand(image, command);
                case CommandType.L:
                    return new ColorPixelImageCommand(image, command);
                case CommandType.V:
                    return new VerticalFillImageCommand(image, command);
                case CommandType.H:
                    return new HorizontalFillImageCommand(image, command);
                case CommandType.F:
                    return new FillImageCommand(image, command);
                case CommandType.S:
                    return new ShowCurrentImageCommand(image, command);
                case CommandType.X:
                    return new TerminateSessionCommand();
                default:
                    throw new ArgumentException(nameof(type));
            }
        }
    }
}
