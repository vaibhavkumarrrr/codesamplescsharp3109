using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWotld
{
    public class CheckUpdateBalance
    {
        public int CheckBalanceAmount(int inMoney, int outMoney)
        {
            return inMoney - outMoney;
        }

        public int UpdateBalanceAmount(ref int inMoney, ref int outMoney)
        {
            inMoney += 10;
            return inMoney - outMoney;
        }
        /*        public int UpdateBalanceAmount(int inMoney, int outMoney)
                {
                    inMoney += 10;
                    return inMoney - outMoney;
                }*/
    }
}
