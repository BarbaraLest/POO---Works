using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.NewFolder1
{
    class Caneca : Copo, ICusto
    {
        public double Custo(double volume)
        {
            return (volume * 0.005);
        }

    }
}
