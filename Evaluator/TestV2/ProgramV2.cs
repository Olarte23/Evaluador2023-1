public class ProgramV2
{
    
    //public static void Main()
    //{
    //    Console.WriteLine("Introduce la operación matemática en infijo:");
    //    string? operacionInfijo = Console.ReadLine();
    //    string operacionPostfijo = ConvertirInfijoAPostfijo(operacionInfijo!);
    //    Console.WriteLine("La operación en postfijo es: " + operacionPostfijo);
    //    double resultado = EvaluarExpresionPostfijo(operacionPostfijo);
    //    Console.WriteLine("El resultado de la operación en postfijo es: " + resultado);
    //}

    //public static string ConvertirInfijoAPostfijo(string operacionInfijo)
    //{
    //    string operacionPostfijo = "";
    //    Stack<char> pila = new Stack<char>();
    //    Dictionary<char, int> precedencia = new Dictionary<char, int>() {
    //        { '(', 0 },
    //        { '+', 1 },
    //        { '-', 1 },
    //        { '*', 2 },
    //        { '/', 2 }
    //    };

    //    for (int i = 0; i < operacionInfijo.Length; i++)
    //    {
    //        char caracterActual = operacionInfijo[i];

    //        if (char.IsDigit(caracterActual))
    //        {
    //            operacionPostfijo += caracterActual;

    //            while (i + 1 < operacionInfijo.Length && char.IsDigit(operacionInfijo[i + 1]))
    //            {
    //                i++;
    //                operacionPostfijo += operacionInfijo[i];
    //            }

    //            operacionPostfijo += " ";
    //        }
    //        else if (caracterActual == '(')
    //        {
    //            pila.Push(caracterActual);
    //        }
    //        else if (caracterActual == ')')
    //        {
    //            while (pila.Count > 0 && pila.Peek() != '(')
    //            {
    //                operacionPostfijo += pila.Pop() + " ";
    //            }

    //            pila.Pop();
    //        }
    //        else if (precedencia.ContainsKey(caracterActual))
    //        {
    //            while (pila.Count > 0 && pila.Peek() != '(' && precedencia[caracterActual] <= precedencia[pila.Peek()])
    //            {
    //                operacionPostfijo += pila.Pop() + " ";
    //            }

    //            pila.Push(caracterActual);
    //        }
    //    }

    //    while (pila.Count > 0)
    //    {
    //        operacionPostfijo += pila.Pop() + " ";
    //    }

    //    return operacionPostfijo.Trim();
    //}

    //public static double EvaluarExpresionPostfijo(string operacionPostfijo)
    //{
    //    Stack<double> pila = new Stack<double>();

    //    foreach (string token in operacionPostfijo.Split(' '))
    //    {
    //        if (double.TryParse(token, out double numero))
    //        {
    //            pila.Push(numero);
    //        }
    //        else
    //        {
    //            double b = pila.Pop();
    //            double a = pila.Pop();

    //            switch (token)
    //            {
    //                case "+": pila.Push(a + b); break;
    //                case "-": pila.Push(a - b); break;
    //                case "*": pila.Push(a * b); break;
    //                case "/": pila.Push(a / b); break;
    //            }
    //        }
    //    }

    //    return pila.Pop();
    //}

}
