// See https://aka.ms/new-console-template for more information
using DSA_CSharp._00_Big0;
using DSA_CSharp._01_Section4_GoogleCoding;
using DSA_CSharp._02_Arrays_DS;
using DSA_CSharp._03_HashTables_DS;
using DSA_CSharp._04_LinkedLists_DS;
using DSA_CSharp._05_Stacks_Queues_DS;

QueuesUsingStack queuesUsingStack = new();

queuesUsingStack.Enqueue(1);
queuesUsingStack.Enqueue(2);
queuesUsingStack.Enqueue(3);
queuesUsingStack.Enqueue(5);
queuesUsingStack.printQueue();

Console.WriteLine("Peek Value" + " " + queuesUsingStack.Peek());

queuesUsingStack.Dequeue();
queuesUsingStack.printQueue();






