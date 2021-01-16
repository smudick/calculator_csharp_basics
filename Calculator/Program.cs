using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculator
            Console.WriteLine("Enter a list of numbers separated by commas.");
            var userNumbersEntry = Console.ReadLine();
            Console.WriteLine("Select an operation to perform on these numbers");
            Console.WriteLine("*   Multiply");
            Console.WriteLine("^   Square");
            Console.WriteLine("+   Add");
            Console.WriteLine("/   Divide");
            Console.WriteLine("%   Average");
            var selectedOperator = Console.ReadLine();
            var userNumbers = userNumbersEntry.Split(',');

            switch (selectedOperator)
            {
                case "*":
                    var multResult = 1;
                    foreach (var num in userNumbers)
                    {
                        multResult *= int.Parse(num);
                    }
                    Console.WriteLine(multResult);
                    break;
                case "^":
                    string sqResult = "";
                    foreach (var num in userNumbers)
                    {
                        var square = int.Parse(num) * int.Parse(num);
                        var sqResultNoComma = square.ToString();
                        sqResult += sqResultNoComma + ',';
                    }
                    Console.WriteLine(sqResult.TrimEnd(','));
                    break;
                case "+":
                    var addResult = 0;
                    foreach (var num in userNumbers)
                    {
                        addResult += int.Parse(num);
                    }
                    Console.WriteLine(addResult);
                    break;
                case "/":
                    double divResult = 1;
                    foreach (var num in userNumbers)
                    {
                        divResult = int.Parse(num) / divResult;
                    }
                    Console.WriteLine(divResult);
                    break;
                case "%":
                    var total = 0;
                    foreach (var num in userNumbers)
                    {
                        total += int.Parse(num);
                    }
                    var avgResult = total / userNumbers.Length;
                    Console.WriteLine(avgResult);
                    break;
                default:
                    Console.WriteLine("Invalid Entry: Please select an operator next time");
                    break;
            }
        }
    }
}
