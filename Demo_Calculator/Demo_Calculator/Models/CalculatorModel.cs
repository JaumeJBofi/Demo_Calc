using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo_Calculator.Models
{
    public class Calculator 
    {
        private double _CurrentResult;
        private char _enterSign;
        private double _firstOperand;
        private double _secondOperand;
        private bool _floatState;
        private bool _activeState;        
        private bool _resultState;

        public Calculator()
        {
            _CurrentResult = 0;
            _firstOperand = 0;
            _secondOperand = 0;

            _activeState = false;            
            _floatState = false;
            _resultState = false;
        }

        public void operate()
        {
            switch(_enterSign)
            {
                case '+': _CurrentResult = _firstOperand + _secondOperand;
                    break;
                case '-': _CurrentResult = _firstOperand - _secondOperand;
                    break;
                case '*': _CurrentResult = _firstOperand * _secondOperand;
                    break;
                case '/': _CurrentResult = _firstOperand / _secondOperand;
                    break;
            }
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
        public bool ActiveState
        {
            get
            {
                return _activeState;
            }
            set
            {
                _activeState = value;
            }
        }
        public char CurrentSign
        {
            get
            {
                 return _enterSign;
            }
            set
            {
                _enterSign = value;
            }
        }
        public bool ResultState
        {
            get
            {
                return _resultState;
            }
            set
            {
                _resultState = value;
            }
        }
        public bool FloatState
        {
            get
            {
                return _floatState;
            }
            set
            {
                _floatState = value;
            }
        }
    }
}
