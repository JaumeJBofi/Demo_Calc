using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorModel;
using CalculatorViewModelNS;
using NumberCommandNS;

namespace CalculatorViewModelNS
{
    public class CalculatorViewModel
    {
        public Calculator myCalc = new Calculator();
        public NumberPressedCommand numberPressed { get; set; }
        

        protected CalculatorViewModel()
        {
            this.numberPressed = new NumberPressedCommand(this);

        }
   
        public string txtCurrValue
        {
            get
            {
                return myCalc.CurrentResult.ToString();                
            }
            set
            {
                myCalc.CurrentResult = Convert.ToDouble(value);
            }
        }

        public string txtFirstOperand
        {
            get
            {
                return myCalc.FirstOperand.ToString();
            }
            set
            {
                myCalc.FirstOperand = Convert.ToDouble(value);
            }
        }
        public string txtSecondOperand
        {
            get
            {
                return myCalc.SecondOperand.ToString();
            }
            set
            {
                myCalc.SecondOperand = Convert.ToDouble(value);
            }
        }
       
        public void numberPressedExecute()
        {

        }

    }
}
