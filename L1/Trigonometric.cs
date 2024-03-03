using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public enum TrigonometricFunction
    {
        Sin,
        Cos,
        Tan
    };
    class TrigEquation : IEquation
    {
        private TrigonometricFunction _function;
        private double _arg;

        public TrigEquation(TrigonometricFunction function, double arg) 
        {
            _function = function;
            _arg = arg;
        }
        public override string Solve()
        {
            double sol = 0.0;

            if (_function == TrigonometricFunction.Sin)
            {
                if (_arg > 1 || _arg < -1)
                {
                    throw new TrigException("Argument Invalid!", _arg);
                }
                sol = Math.Asin(_arg);
            }

            if (_function == TrigonometricFunction.Cos)
            {
                if (_arg > 1 || _arg < -1)
                {
                    throw new TrigException("Argument Invalid!", _arg);
                }
                sol = Math.Acos(_arg);
            }

            if (_function == TrigonometricFunction.Tan)
            {
                sol = Math.Atan(_arg);
            }

            if(_arg < 0)
            {
                sol = Math.Round(sol * 180 / Math.PI, 0) + 360.0;
            }
            else
            {
                sol = Math.Round(sol * 180 / Math.PI, 0);
            }

            return $"x = {sol} grade";
        }
    }
}
