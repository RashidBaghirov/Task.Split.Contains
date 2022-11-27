// See https://aka.ms/new-console-template for more information


using Homework;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

string sentence = "salam necesen";
foreach (var item in sentence.CustomSplit(' ')) 
{
    Console.WriteLine(item);
}

