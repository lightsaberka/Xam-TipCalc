using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class TipViewModel: MvxViewModel
    {
		// subtotal
	    private double _subTotal;
	    public double SubTotal
	    {
		    get => _subTotal;
		    set {
			    _subTotal = value;
			    RaisePropertyChanged(() => SubTotal);

				Recalculate();
		    }
	    }

		// generosity
	    private int _generosity;
	    public int Generosity
	    {
		    get => _generosity;
		    set {
			    _generosity = value;
			    RaisePropertyChanged(() => Generosity);

			    Recalculate();
		    }
	    }

		// tip
	    private double _tip;
	    public double Tip
	    {
		    get => _tip;
		    set {
			    _tip = value;
			    RaisePropertyChanged(() => Tip);
		    }
	    }

		// calc service
	    private readonly ICalcService _calcService;

		// constructor
		public TipViewModel(ICalcService calcService)
		{
			_calcService = calcService;
		}

		// init with default values
	    public override async Task Initialize()
	    {
		    await base.Initialize();

		    _subTotal = 100;
		    _generosity = 10;

		    Recalculate();
	    }

		// call the service from interface
	    private void Recalculate()
	    {
		    Tip = _calcService.TipAmount(SubTotal, Generosity);
	    }
	}
}
