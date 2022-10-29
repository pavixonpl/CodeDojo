// See https://aka.ms/new-console-template for more information

using CodeDojo.AppalachianCensus.Services;

Console.WriteLine("Hello, World!");
var service = new ValleyService();
var people = service.GetPeopleInValley();

Console.WriteLine(string.Join(",\n ", people.Select(s=>s.ToString())));