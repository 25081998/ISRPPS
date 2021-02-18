using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Коммунальные_платежи
{
    class Electricity : Pay
    {
        private static double rate = 5.00; //тариф
        private double beforeValue; //предыдущие показания
        private double currentValue; //текущие показания

        public Electricity(string name, double beforeValue, double currentValue)
            :base(name)
        {
            this.beforeValue = beforeValue;
            this.currentValue = currentValue;
        }

        public override double Sum() { return (currentValue - beforeValue) * rate; }
        public override string Data() { return name + "\t" + Sum() + " руб\t" + (currentValue - beforeValue) + " кВт*ч\t"; }
    }
}
