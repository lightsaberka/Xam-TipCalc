using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalc.Core.Services
{
    class CalcService: ICalcService
    {
	    public double TipAmount(double subtotal, int generosity)
	    {
		    return subtotal * ((double) generosity / 100.0);
	    }
    }
}
