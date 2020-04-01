using Memento.Originator;

namespace Memento.Memento
{
    public class Snapshot
    {
        private readonly Editor _editor;
        private readonly string _text;
        private readonly int _curX, _curY, _selectionWidth;


        public Snapshot(Editor editor, string text, int curX, int curY, int selectionWidth)
        {
            _editor = editor;
            _text = text;
            _curX = curX;
            _curY = curY;
            _selectionWidth = selectionWidth;
        }

        public void Restore()
        {
            _editor.SetText(_text);
            _editor.SetCursor(_curX, _curY);
            _editor.SetSelectionWidth(_selectionWidth);
        }
    }
}