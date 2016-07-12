using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Demo_Calculator.ViewModels.Commands
{
    public class OperandPressedCommand : ICommand
    {
        public CalculatorViewModel myViewModel { get; set; }
        

        public OperandPressedCommand(CalculatorViewModel myVM)
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
            this.myViewModel.operandPressedExecute(parameter);
        }  

    }
}
