namespace Computer_Science_Calculator;

class Program
{
    static void Main(string[] args)
    {
        // Stack myStack = new Stack();
        // myStack.Push("1");
        // myStack.Push("2");
        // myStack.Push("3");
        //
        // Console.WriteLine(myStack.Pull());
        // Console.WriteLine(myStack.Pull());
        // Console.WriteLine(myStack.Pull());
        string input;
        if (args.Length > 0)
        {
            input = args[0];
        }
        else
        {
            Console.WriteLine("Enter what to calculate: ");
            input = Console.ReadLine();
        }
        Queue tokens = Tokenizer.Tokenize(input);
        Queue rpn = RpnConverter.ConvertToRPN(tokens);
        string result = RpnCalculator.Calculate(rpn);
        Console.WriteLine($"Result:{result}");

    }
}