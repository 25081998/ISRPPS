using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Коммунальные_платежи
{
    class Gas : Pay
    {
        private static double rate = 100.00; //тариф
        private uint people; //кол-во проживающих

        public Gas(string name, uint people)
            :base(name)
        { this.people = people; }

        public override double Sum() { return people * rate; }
        public override string Data() { return name + "\t" + Sum() + " руб\t" + people + " чел\t"; }
    }
}
