using System;

namespace NumberPressed{
    public class NumberPressedCommand : ICommand
    {
        public NumberPressedCommand() 
        {
           
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // Can black out some buttoms when necessary
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

    }
}
