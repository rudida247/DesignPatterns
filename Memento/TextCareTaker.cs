using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        List<TextMemento> mementos = new List<TextMemento>();
        private int counter = 0; 
        

        public void AddMemento(TextMemento memento)
        {
            if (this.mementos.Count() != counter)
                try
                {
                    this.mementos.RemoveRange(counter+1, this.mementos.Count()-1);
                }
                catch { }
            counter += 1;
            this.mementos.Add(memento);
        }

        public TextMemento GetLast()
        {
            try
            {
                return this.mementos.ElementAt<TextMemento>(--counter);
            }
            catch
            {
                counter += 1;
                return null;
            }
        }

        public TextMemento GetRedu()
        {
            try
            {
                return this.mementos.ElementAt<TextMemento>(++counter);
            }
            catch
            {
                counter -= 1;
                return null;
            }
        }
    }
}
