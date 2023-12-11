using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMutualCopierKata.Abstract
{
    public interface IDestination
    {
        void WriteChar(char c);
        void WriteChars(char[] values);
    }
}
