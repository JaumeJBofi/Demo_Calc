using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorModel
{
    public class Calculator
    {
        private double _CurrentResult;
        private char _enterSign;
        private double _firstOperand;
        private double _secondOperand;
        private bool _floatState;
        private bool _activeState;

        public Calculator()
        {
            _CurrentResult = 0;
            _activeState = false;
            _firstOperand = 0;
            _secondOperand = 0;
        }

        public double FirstOperand
        {
            get
            {
                return _firstOperand;
            }
            set
            {
                _firstOperand = value;
            }
        }

        public double SecondOperand
        {
            get
            {
                return _secondOperand;
            }
            set
            {
                _secondOperand = value;
            }
        }
        public double CurrentResult
        {
            get
            {
                return _CurrentResult;
            }
            set
            {
                _CurrentResult = value;
            }
        }

    }
}
