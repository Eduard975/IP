using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public enum EqType
    { 
      FirstDegree, 
      SecondDegree 
    };
    class PolyEquation : IEquation
    {
        private EqType _eqType;
        private double _x2;
        private double _x1;
        private double _x0;

        public PolyEquation(double x2, double x1, double x0) 
        {
            _x2 = x2;
            _x1 = x1;
            _x0 = x0;
            _eqType = EqType.SecondDegree;
        }

        public override string Solve() 
        {
            String result = "";
            if (_x2 == _x1 && _x1 == _x0 && _x1 == 0.0)
            {
                throw new PolyException("Exista o infinitate de solutii pentru:", _x2, _x1, _x0);
            }
            else if (_x2 == 0.0 && _x1 == 0.0 && _x0 != 0.0)
            {
                throw new PolyException("Nu exista solutii pentru:", _x2, _x1, _x0);
            }
            else
            {
                if (_x2 == 0.0)
                {
                    _eqType = EqType.FirstDegree;
                    double sol = (-_x0)/_x1;
                    sol = Math.Round(sol, 3);
                    result = $"x = {sol};";
                }
                double delta = Math.Pow(_x1, 2) - 4.0 * _x2 * _x0;
                if (delta < 0.0)
                {
                    double rSol = (-_x1) / (2.0 * _x2);
                    rSol = Math.Round(rSol, 3);
                    double iSol = Math.Sqrt(-delta)/ (2.0 * _x2);
                    iSol = Math.Round(iSol, 3);

                    result = $"x1 =  {rSol} + {iSol} i; x2 = {rSol} - {iSol} i;";
                }
                else if (delta == 0.0)
                {
                    double sol = (-_x1) / (2.0 * _x2);
                    sol = Math.Round(sol, 3);
                    result = $"x1 = x2 = {sol};";
                }
                else
                {
                    double x1Sol = (-_x1 + Math.Sqrt(delta)) / (2.0 * _x2);
                    x1Sol = Math.Round(x1Sol, 3);
                    double x2Sol = (-_x1 - Math.Sqrt(delta)) / (2.0 * _x2);
                    x2Sol = Math.Round(x2Sol, 3);

                    result = $"x1 = {x1Sol}; x2 = {x2Sol};";
                }
            }

            return result;
        }

    }
}
