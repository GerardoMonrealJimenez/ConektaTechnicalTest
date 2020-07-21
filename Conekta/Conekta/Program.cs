using Conekta.GraphicalEditor;
using Conekta.GraphicalEditor.Commands;
using Conekta.GraphicalEditor.Factory;
using Conekta.GraphicalEditor.Invoker;
using Conekta.GraphicalEditor.Reciver;
using System;
using System.Collections.Generic;

namespace Conekta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please write the commands");
            var image = new Image();
            var manager = new GraphicalEditorManager();
            var commandFactory = new CommandFactory(image);
            do
            {
                try
                {
                    var line = Console.ReadLine().ToUpper();
                    var command = commandFactory.GetCommand(line);
                    manager.Invoke(command);
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"This is not a valid command");
                }
            } while (true);
        }
    }
}
