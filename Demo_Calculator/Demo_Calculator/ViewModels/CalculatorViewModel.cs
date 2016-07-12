using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Calculator.Models;
using Demo_Calculator.ViewModels.Commands;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;

namespace Demo_Calculator.ViewModels
{

    static class MyList
    {
        static List<Button> _list;
        static MyList()
        {
            _list = new List<Button>();
        }

        public static void Record(Button value)
        {         
            _list.Add(value);
        }

        public static void Change()
        {         
            foreach (var value in _list)
            {
                value.Background = Brushes.Gainsboro;
            }
        }
        public static void Clear()
        {
            _list.Clear();
        }
    }
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public Calculator myCalc = new Calculator();
        public NumberPressedCommand numberPressed { get; set; }
        public OperandPressedCommand operandPressed { get; set; }
        public EqualPressedCommand equalPressed { get; set; }     
        public ClearPressedCommand clearPressed { get; set; }   

        public CalculatorViewModel()
        {
            this.numberPressed = new NumberPressedCommand(this);
            this.operandPressed = new OperandPressedCommand(this);
            this.equalPressed = new EqualPressedCommand(this);
            this.clearPressed = new ClearPressedCommand(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {            
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string txtCurrValue
        {
            get
            {
                if(myCalc.ResultState)
                {
                    return myCalc.CurrentResult.ToString();
                }
                if(myCalc.ActiveState)
                {
                    return myCalc.SecondOperand.ToString();
                }
                else
                {
                    return myCalc.FirstOperand.ToString();
                }
                
            }
            set
            {
                if (myCalc.ResultState)
                {
                    myCalc.CurrentResult = Convert.ToDouble(value);

                }
                else
                {
                    if (myCalc.ActiveState)
                    {
                        myCalc.SecondOperand = Convert.ToDouble(value);
                    }
                    else
                    {
                        myCalc.FirstOperand = Convert.ToDouble(value);
                    }
                }                         
                  RaisePropertyChangedEvent("txtCurrValue");                                                
            }
        } 
        
        public void numberPressedExecute(object sender)
        {
             string myString = (sender as Button).Content.ToString();   
            if (txtCurrValue.Length >= 10) return;                 
            if(myString== ".")
            {
                myCalc.FloatState = true;
                return;
            }
            else
            {
                if(myCalc.FloatState)
                {
                    txtCurrValue += ("." + myString);
                    myCalc.FloatState = false;
                }
                else
                {
                    txtCurrValue += myString;                    
                }                
            }            
        }

        public void operandPressedExecute(object sender)
        {
            MyList.Record((sender as Button));

            if(myCalc.ActiveState)
            {
                myCalc.ActiveState = false;
                txtCurrValue = "0";
                myCalc.FirstOperand = 0;
                myCalc.SecondOperand = 0;
                MyList.Change();
                MyList.Clear();
                return;
            }
            else
            {
                if(myCalc.FirstOperand == 0)
                {
                    myCalc.FirstOperand = myCalc.CurrentResult;
                    myCalc.ActiveState = false;
                }
            }
            char operand = Convert.ToChar((sender as Button).Content);            
            myCalc.CurrentSign = operand;          
            myCalc.ActiveState = true;
                                
            (sender as Button).Background = Brushes.Silver;            
        }

        public void EqualPressedExecute(object sender)
        {
            (sender as Grid).Focus();
            myCalc.operate();
            myCalc.ResultState = true;
            myCalc.ActiveState = false;
            RaisePropertyChangedEvent("txtCurrValue");
            myCalc.ResultState = false;

            myCalc.FirstOperand = 0;
            myCalc.SecondOperand = 0;

            MyList.Change();
            MyList.Clear();            
        }

        public void ClearPressedExecute(object sender)
        {

            (sender as Grid).Focus();
            MyList.Change();
            MyList.Clear();
            myCalc.ActiveState = false;
            myCalc.FirstOperand = 0;
            myCalc.SecondOperand = 0;
            txtCurrValue = "0";
        }
    }
}
