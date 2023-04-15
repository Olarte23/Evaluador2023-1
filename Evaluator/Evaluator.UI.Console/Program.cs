using Evaluator.Logic;

Console.WriteLine("Expresions Evaluator ");
var expresion1 = "20,5+(5*2)";
//var expresion2 = "4*(5+6-(8/2^3)-7)-1";
Console.WriteLine($"{expresion1} = {MyEvaluator.Evaluate(expresion1)}");
//Console.WriteLine($"{expresion2} = {MyEvaluator.Evaluate(expresion2)}");


//var expresion1 = "4*5/(4+6)";