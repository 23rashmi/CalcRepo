// See https://aka.ms/new-console-template for more information
using CalcExample;

//public delegate void CalcDel(double num1, double num2);
//Calc calc = new Calc();
//CalcDel del = CalcDel(calc.Add);

//Console.WriteLine("Welcome to the number System world! ... ");



Calc calc = new Calc();
Console.WriteLine("Add Call");
calc.Add(12, 45);

Console.WriteLine("Multiply Call");
calc.Mul(13.2, 15.8);

Console.WriteLine("Division Call");
calc.Div(15, 3);

Console.WriteLine("Subtraction call");
calc.Sub(10, 2);