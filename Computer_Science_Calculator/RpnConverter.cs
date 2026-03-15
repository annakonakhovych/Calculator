namespace Computer_Science_Calculator;

public class RpnConverter
{
    public static Queue ConvertToRPN(Queue tokens)
    {
        Queue output = new Queue();
        Stack stack = new Stack();

        while (true)
        {
            string token = tokens.Dequeue();
            if (token == null)
            {
                break;
            }

            if (double.TryParse(token, out _))
            {
                output.Enqueue(token);
            }
            else if (token == "(")
            {
                stack.Push(token);
            }
            else if (token == ")")
            {
                while (stack.Peek() != "(")
                {
                    output.Enqueue(stack.Pull());
                }

                stack.Pull();
                if (stack.Peek() != null && GetPriority(stack.Peek()) == 4)
                {
                    output.Enqueue(stack.Pull());
                }
            }
            else if (token == ",")
            {
                while (stack.Peek() != "(")
                {
                    output.Enqueue(stack.Pull());
                }
            }
            else
            {
                while (stack.Peek() != null && stack.Peek() != "(" && GetPriority(stack.Peek()) >= GetPriority(token))
                {
                    output.Enqueue(stack.Pull());
                }
                stack.Push(token);
            }
        }

        while (stack.Peek() != null)
        {
            output.Enqueue(stack.Pull());
               
        }
        return output;
    }
    
    private static int GetPriority(string operation)
    {
        if (operation == "+" || operation == "-")
        {
            return 1;
        }

        if (operation == "*" || operation == "/")
        {
            return 2;
        }

        if (operation == "^")
        {
            return 3;
        }
        if (operation.Length > 1)
        {
            return 4;
        }
        return 0;
    }
}