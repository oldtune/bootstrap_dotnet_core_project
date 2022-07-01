using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISomeService
    {
        int Return3();
        int ReturnWhateverTheInputLessThan10(int input);
    }
}
