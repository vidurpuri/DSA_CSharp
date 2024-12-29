// See https://aka.ms/new-console-template for more information
using DSA_CSharp._00_Big0;
using DSA_CSharp._01_Section4_GoogleCoding;
using DSA_CSharp._02_Arrays_DS;
using DSA_CSharp._03_HashTables_DS;
using DSA_CSharp._04_LinkedLists_DS;
using DSA_CSharp._05_Stacks_Queues_DS;

StacksUsingArray stacksUsingArray = new StacksUsingArray(5);
stacksUsingArray.Push(1);
stacksUsingArray.Push(2);
stacksUsingArray.Push(3);
stacksUsingArray.Push(5);
stacksUsingArray.Print();

Console.WriteLine("Peek Value" + " " + stacksUsingArray.Peek());

stacksUsingArray.Pop();
stacksUsingArray.Print();






