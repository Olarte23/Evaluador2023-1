namespace Evaluator.Logic

{
    public class MyEvaluator
    {
        public static int TopPostfix = 0;
        public static double Evaluate(string infix)
        {
            var postfix = ToPostfix(infix);
            var input = Calculate(postfix);
            TopPostfix = 0;
            return input;
            
        }

        private static double Calculate(string[] postfix)
        {

            var stack = new Stack<double>(100);
            for (int i = 0; i < TopPostfix; i++)
            {
                if (postfix[i].Length > 1)
                {
                    double.TryParse((postfix[i]) , out double number);
                    stack.Push(number);

                }
                else
                {
                    if (IsOperator(char.Parse(postfix[i])))
                    {
                        var number2 = stack.Pop();
                        var number1 = stack.Pop();
                        var result = Calculate(number1, Char.Parse(postfix[i]), number2);
                        stack.Push(result);
                    }
                    else
                    {

                        var number = ToDouble(Char.Parse(postfix[i]));
                        stack.Push(number);
                    }
                }
                
            }
            return stack.Pop();
        }

        private static double ToDouble(char number)
        {
            return (double)number - 48;
        }

        private static double Calculate(double number1, char @operator, double number2)
        {
            switch (@operator)
            {
                case '^': return Math.Pow(number1, number2);
                case '*': return number1 * number2;
                case '/': return number1 / number2;
                case '+': return number1 + number2;
                case '-': return number1 - number2;
                default: throw new Exception("Not valid operator");
            }
        }

        public static string[] ToPostfix(string infix)
        {
            int countDot;
            var stack = new Stack<char>(100);           
            var postfix= new string[infix.Length];
            int j = 0;
            int i = 0;
            for (; i < infix.Length; i++)
            {
                if (IsOperator(infix[i]))
                {
                    if (stack.IsEmpty)
                    {
                        stack.Push(infix[i]);

                    }
                    else
                    {
                        if (infix[i] == ')')
                        {
                            do
                            {
                                postfix[j] += stack.Pop();
                                j++;
                                TopPostfix++;
                            } while (stack.GetItemInTop() != '(');
                            stack.Pop();
                        }
                        else
                        {
                            if (PriorityInExpression(infix[i]) > PriorityInStack(stack.GetItemInTop()))
                            {
                                stack.Push(infix[i]);
                            }
                            else
                            {
                                postfix[j] += stack.Pop();
                                stack.Push(infix[i]);
                                j++;
                                TopPostfix++;
                            }
                        }
                    }
                }
                else
                {
                    if (i < infix.Length-1)
                    {
                        if (IsOperator(infix[i + 1]))
                        {
                            postfix[j] += infix[i];
                            j++;
                            TopPostfix++;
                        }
                        else
                        {
                            postfix[j] += infix[i];
                        }
                    }
                    else
                    {
                        postfix[j] += infix[i];
                        j++;
                        TopPostfix++;
                    }                               
                    
                    //postfix[j] += infix[i];
                    //j++;
                    //TopPostfix++;
                }
            }
            while (!stack.IsEmpty)
            {
                postfix[j] += stack.Pop();
                j++;
                TopPostfix++;
            }
            return postfix;
        }

        private static bool IsOperator(char item)
        {
            if (item == '(' || item == ')' || item == '^' || item == '/' || item == '*' || item == '+' || item == '-')
            {
                return true;
            }
            return false;
        }

        private static int PriorityInExpression(char @operator)
        {
            switch (@operator)
            {
                case '^': return 4;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 5;
                default: throw new Exception("Not valid operator");
            }
        }

        private static int PriorityInStack(char @operator)
        {
            switch (@operator)
            {
                case '^': return 3;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 0;
                default: throw new Exception("Not valid operator");
            }
        }
    }
}
