using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class TextEditorState
    {
        private string content { set; get; }

        public TextEditorState(string content)
        {
            this.content = content;
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
