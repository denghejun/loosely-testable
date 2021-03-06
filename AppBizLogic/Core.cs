﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDependentServices;

namespace AppBizLogic
{
    public class Core
    {
        private readonly ICalculate _calculator = null;
        private readonly INotify _notifier = null;
        public Core(ICalculate calculator, INotify notifier)
        {
            this._calculator = calculator;
            this._notifier = notifier;
        }

        public int CalculateComplex(int a, int b)
        {
            var result = this._calculator.Add(a, b) * this._calculator.Sub(a, b);
            this._notifier.Notify(string.Format("RESULT:{0}", result));
            return result;
        }
    }
}
