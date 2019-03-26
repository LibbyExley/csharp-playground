namespace HelloWorld.Classes {
    public class Calculator
    {
        public int Add(int numberOne, int numberTwo) 
        {
            return numberOne + numberTwo;
        }

        public int Subtract(int numberOne, int numberTwo) 
        {
            return numberOne - numberTwo;
        }

        public int Multiply(int numberOne, int numberTwo) 
        {
            return numberOne * numberTwo;
        }

        public decimal Multiply(decimal numberOne, decimal numberTwo)
        {
            return numberOne * numberTwo;
        }

        public decimal Divide(int numberOne, int numberTwo)
        {
            // This prevents a divide by zero error.
            if (numberTwo == 0) return numberOne;
            return numberOne / numberTwo;
        }
    }
}