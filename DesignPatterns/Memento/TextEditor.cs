using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class TextEditor
    {
        private string content { set; get; }
       
        public TextEditor()
        {
            this.content = "";
        }

        public TextEditorState Save()
        {
            return new TextEditorState(content);
        }

        public void Restore(TextEditorState state)
        {
            this.content = state.GetContent();
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }
}
