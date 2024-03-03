using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class PolyException : Exception
    {
        private double _x2;
        private double _x1;
        private double _x0;
        private String _message;

        public override String Message { get; }

        public PolyException(String message, double x2, double x1, double x0) : base()
        {
            _message = message;
            _x2 = x2;
            _x1 = x1;
            _x0 = x0;
            Message = $"{message}\n{x2}*x^2 + {x1}*x + {x0} = 0";
        }
    }
}
