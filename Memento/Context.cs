using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void Load(RichTextBox richText)
        {
            var lastText = careTake.GetLast();
            if (lastText != null && lastText.savedText != null )
                richText.Text = lastText.savedText;
        }
        public void Redu(RichTextBox richText)
        {
            var reduText = careTake.GetRedu();
            if (reduText != null && reduText.savedText != null)
                richText.Text = reduText.savedText;
        }
    }
}
