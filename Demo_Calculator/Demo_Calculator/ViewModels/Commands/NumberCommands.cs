using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Demo_Calculator.ViewModels.Commands
{
    public class NumberPressedCommand : ICommand
    {
        public CalculatorViewModel CalcViewModel { get; set; }

        public NumberPressedCommand(CalculatorViewModel calcViewModel)
        {
            this.CalcViewModel = calcViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object sender)
        {          
            //string myString = (sender as Button).Content.ToString();
            //int n;
            //bool isNumeric = int.TryParse("myString", out n);
            return true;
        }

        public void Execute(object sender)
        {
            this.CalcViewModel.numberPressedExecute(sender);
        }

    }
}
