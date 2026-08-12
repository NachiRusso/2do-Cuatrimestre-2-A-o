// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

Assembly assembly = Assembly.GetExecutingAssembly();

Console.WriteLine($"Assembly: {assembly.GetName().Name}");

foreach (Type type in assembly.GetTypes())
{
    Console.WriteLine(type.FullName);
}