using System;
using Memento.Caretaker;
using Memento.Originator;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor("Yeehaw", 1, 2, 5);
            var command = new Command(editor);
            Console.WriteLine(editor);
            command.MakeBackup();
            editor.SetText("waawaaweaea");
            editor.SetCursor(5000, 20);
            Console.WriteLine(editor);
            command.Undo();
            Console.WriteLine(editor);
            Console.ReadLine();
        }
    }
}
