using Memento.Memento;
using Memento.Originator;

namespace Memento.Caretaker
{
    public class Command
    {
        private Snapshot _backup;
        private readonly Editor _editor;

        public Command(Editor editor)
        {
            _editor = editor;
        }
        public void MakeBackup()
        {
            _backup = _editor.CreateSnapshot();
        }

        public void Undo()
        {
            _backup?.Restore();
        }
    }
}