using System;

Console.WriteLine("=== C-Sharp Calculator ===");
Console.WriteLine("Type 'exit' for stop");

while (true)
{
  Console.WriteLine("Write 2 numbers (double) in the folowing format: {number1} <space> {number2}");

  string? input = Console.ReadLine();

  if (string.IsNullOrWhiteSpace(input)) continue;
  if (string.Equals(input.ToLower(), "exit")) break;
  
  string[] parts = input.Split(' ');

  if (parts.Length != 2)
  {
    Console.WriteLine("Error: Wrong format. Write 2 numbers in the folowing format: {number1} <space> {number2}");
    continue;
  }

  double a = double.Parse(parts[0]);
  double b = double.Parse(parts[1]);

  double result = 0;
  
  Console.WriteLine("Choose operation: +, -, *, /");

  string? operation = Console.ReadLine();

  if (string.IsNullOrWhiteSpace(operation)) continue;
  if (string.Equals(operation.ToLower(), "exit")) break;

  bool success = true;

  switch (operation)
  {
    case "+": result = a + b; break;
    case "-": result = a - b; break;
    case "*": result = a * b; break;
    case "/": 
      if (b != 0) result = a / b;
      else
      {
        Console.WriteLine("Error: division by zero");
        success = false;
      }
      break;
    default:
      Console.WriteLine("Error: Wrong operation format. Only +, -, *, / are supported");
      success = false;
      break;
  }

  if (success)
  {
    Console.WriteLine($"Operation result: {result}");
  }
}