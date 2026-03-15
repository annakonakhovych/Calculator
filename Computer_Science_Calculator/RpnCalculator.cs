namespace Computer_Science_Calculator;

public class RpnCalculator
{
    public static string Calculate(Queue rpn)
    {
        Stack stack = new Stack();

        while (true)
        {
            string token = rpn.Dequeue();
            if (token == null)
            {
                break;
            }
            if (double.TryParse(token, out _))
            {
                stack.Push(token);
            }
            else if (token == "sin")
            {
                stack.Push(Math.Sin(double.Parse(stack.Pull())).ToString());
            }
            else if (token == "cos")
            {
                stack.Push(Math.Cos(double.Parse(stack.Pull())).ToString());
            }
            else if (token == "max")
            {
                double b = double.Parse(stack.Pull());
                double a = double.Parse(stack.Pull());
                stack.Push(Math.Max(a,b).ToString());
            }
            else
            {
                double b = double.Parse(stack.Pull());
                double a = double.Parse(stack.Pull());
                double result = 0;

                if (token == "+")
                {
                    result = a + b;
                }
                else if (token == "-")
                {
                    result = a - b;
                }
                else if (token == "*")
                {
                    result = a * b;
                }
                else if (token == "/")
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("You can not divide by zero");
                    }
                    result = a / b;
                }
                else if (token == "^")
                {
                    result = Math.Pow(a, b);
                }
                stack.Push(result.ToString());
            }
        } 
        return stack.Pull();
    }
}