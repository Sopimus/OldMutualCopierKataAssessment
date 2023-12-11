using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OldMutualCopierKata.Abstract;

namespace OldMutualCopierKata
{
    public class Copier
    {
        private readonly ISource _source;
        private readonly IDestination _destination;

        public Copier(ISource source, IDestination destination)
        {
            _destination = destination;
            _source = source;
        }
        public void Copy()
        {           
            var c = _source.ReadChar();
            if (c != '\n') 
            _destination.WriteChar(c);
            
        }

        public void CopyChars()
        {
            int chars = 5;
            var stringToChar = new List<Char>();
            var c = _source.ReadChars(chars);
            if (c.Contains('\n'))
            {
                foreach (var ch in c)
                {
                    if (ch != '\n')
                        break;

                    stringToChar.Add(ch);
                }
                _destination.WriteChars(stringToChar.ToArray());
            }
            else
            {
                _destination.WriteChars(c);
            }

            

        }
    }
}
