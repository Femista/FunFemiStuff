using System;
using System.Collections.Generic;
using System.Text;
using Memento.Memento;

namespace Memento.Originator
{
    public class Editor
    {
        private string _text;
        private int _curX, _curY, _selectionWidth;

        public Editor(string text, int curX, int curY, int selectionWidth)
        {
            _text = text;
            _curX = curX;
            _curY = curY;
            _selectionWidth = selectionWidth;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public void SetCursor(int curX, int curY)
        {
            _curX = curX;
            _curY = curY;
        }

        public void SetSelectionWidth(int selectionWidth)
        {
            _selectionWidth = selectionWidth;
        }

        public Snapshot CreateSnapshot()
        {
            return new Snapshot(this, _text, _curX, _curY, _selectionWidth);
        }

        public override string ToString()
        {
            return $"I am an editor with text: {_text}, x at {_curX}, y at {_curY}, and selectionWidth at {_selectionWidth}";
        }
    }
}
