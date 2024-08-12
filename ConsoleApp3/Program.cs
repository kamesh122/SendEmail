// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

Console.WriteLine("Hello, World!");

SendGridEmail sendGrid = new SendGridEmail();
await sendGrid.SendGridEmailAsync();
