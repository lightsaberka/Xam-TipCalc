using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalc.Core.Services
{
    public interface ICalcService
    {
	    double TipAmount(double subtotal, int generosity);
    }
}
