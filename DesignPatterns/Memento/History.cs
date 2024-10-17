using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class History
    {
        private Stack<TextEditorState> prevStates;
        private Stack<TextEditorState> nextStates;

        public History()
        {
            this.prevStates = new Stack<TextEditorState>();
            this.nextStates = new Stack<TextEditorState>();
        }

        public void SaveHistoryState(TextEditorState textEditorState)
        {
            prevStates.Push(textEditorState);
        }

        public TextEditorState Undo()
        {
            if (prevStates.Count == 0)
            {
                return null;
            }
            var state = prevStates.Pop();
            nextStates.Push(state);
            return state;
        }
        
        public TextEditorState Redo()
        {
            if(nextStates.Count == 0)
            {
                return null;
            }
            var state = nextStates.Pop();
            prevStates.Push(state);
            return state;
        }
    }
}
