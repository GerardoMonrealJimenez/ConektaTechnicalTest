using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public abstract class ImageCommand: ICommand
    {
        protected readonly Image image;
        protected readonly string command;
        protected readonly string[] commandSplit;
        public ImageCommand(Image image, string command)
        {
            this.image = image;
            this.command = command;
            this.commandSplit = command.Split(' ');
        }
        protected bool IsImageGenerated() 
        {
            return image.GetCountRows() > 0 && image.GetCountColumns() > 0;
        }
        public virtual bool CanExecute() 
        {
            var imageGenerated = IsImageGenerated();
            if (!imageGenerated) Console.WriteLine($"The Command {command} need a image generated, please generate a Image");
            var verifyCommand = validateCommand();
            if (!verifyCommand) Console.WriteLine($"The Command {command} is incorrect, verify the syntax or the parameters are out of the bounds");
            return verifyCommand && imageGenerated;
        }
        public abstract void Execute();
        public abstract bool validateCommand();
    }
}
