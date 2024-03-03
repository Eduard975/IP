using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class TrigException : Exception
    {
        private double _argument;
        private String _message;

        public override String Message { get; }

        public TrigException(String message, double argument) : base()
        {
            _message = message;
            _argument = argument;
            Message = $"{message}\nArgument: {argument}\nArgumentul trebuie sa respecte conditita 0 <= |{argument}| <= 1";
        }
    }
}
