using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Commands
{
    public class CreateImageCommand : ImageCommand
    {
        private  int n;
        private  int m;

        public CreateImageCommand(Image image, string command):base(image,command)
        {
            
        }

        public override bool CanExecute()
        {
            var verifyCommand = validateCommand();
            if (!verifyCommand) Console.WriteLine($"The Command {command} is incorrect, verify the syntax");
            var verifyDimensions = validateDimensions();
            if(!verifyDimensions) Console.WriteLine($"The Command {command} need appropriate image dimensions");
            return verifyCommand && verifyDimensions;
        }

        public override void Execute()
        {
            this.image.CreateImage(n, m);
        }

        public override bool validateCommand()
        {
            if (!(commandSplit.Length == 3)) return false;
            if (!int.TryParse(commandSplit[1], out m)) return false;
            if (!int.TryParse(commandSplit[2], out n)) return false;
            return true;
        }

        private bool validateDimensions()
        {
            return 1 <= m && 1 <= n && n <= 250;
        }
    }
}
