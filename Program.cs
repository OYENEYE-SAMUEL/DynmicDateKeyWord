using System.Globalization;
using DynamicDayKeyword;


Console.WriteLine("Input the date");
DateTime input = DateTime.Parse(Console.ReadLine());

var inputData = input.ToString();

var data = new DateSolver();
data.Resolve(inputData);