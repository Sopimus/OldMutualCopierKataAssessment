using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMutualCopierKata.Abstract
{
    public interface ISource
    {
        char ReadChar();
        char[] ReadChars(int count);
    }
}
