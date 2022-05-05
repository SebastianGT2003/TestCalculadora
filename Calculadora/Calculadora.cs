using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Calculadora: OperacionesBasicas
    {
        public Calculadora()
        {

        }

        public override int Restar(int i, int n)
        {
            int r = i - n;
            return r;
        }

        public override int Sumar(int i, int n)
        {
            int s = i + n;
            return s;
        }
    }
}
