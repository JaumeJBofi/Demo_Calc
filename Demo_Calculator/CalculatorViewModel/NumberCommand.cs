using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CalculatorViewModelNS;

namespace NumberCommandNS
{    
    public class NumberPressedCommand : ICommand
    {
        public CalculatorViewModel CalcViewModel { get; set; }

        public NumberPressedCommand(CalculatorViewModel calcViewModel)
        {
            this.CalcViewModel = calcViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // Can black out some buttoms when necessary
            return true;
        }

        public void Execute(object parameter)
        {
            this.CalcViewModel.numberPressedExecute();
        }

    }
}
