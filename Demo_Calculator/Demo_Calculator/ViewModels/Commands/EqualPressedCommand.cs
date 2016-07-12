using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo_Calculator.ViewModels.Commands
{
    public class EqualPressedCommand : ICommand
    {
        public CalculatorViewModel myViewModel { get; set; }

        public EqualPressedCommand(CalculatorViewModel myVM)
        {
            this.myViewModel = myVM;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.myViewModel.EqualPressedExecute(parameter);
        }
    }
}
