using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class SomeService : ISomeService
    {
        public int Return3()
        {
            return 3;
        }

        public int ReturnWhateverTheInputLessThan10(int input)
        {
            if (input < 10)
                return input;

            return 9999999;
        }
    }
}
