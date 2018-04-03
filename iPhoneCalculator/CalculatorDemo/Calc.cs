namespace CalculatorDemo
{
    enum NumberStates
    {
        firstN,
        secondN,
        resultN
    }

    enum OperationStates
    {
        Plus, 
        Minus,
        Multiply,
        Divide,
        Equals
    }

    class Calc
    {
        public double firstNumber;

        public NumberStates currentNum;
        public OperationStates currentOp;

        public Calc()
        {
            currentNum = NumberStates.firstN;
            firstNumber = 0;
        }
    }
}
