// See https://aka.ms/new-console-template for more information
using DSA_CSharp._00_Big0;
using DSA_CSharp._01_Section4_GoogleCoding;
using DSA_CSharp._02_Arrays_DS;
using DSA_CSharp._03_HashTables_DS;

HashTableImplementation hashTable = new(2);
hashTable.SetData("grapes",10000);
hashTable.SetData("apples", 70000);
hashTable.SetData("oranges", 100);
var result = hashTable.GetData("apples");
Console.WriteLine(result);
var keys = hashTable.Keys();
for(int i = 0;i < keys.Count;i++)
{
    Console.WriteLine(keys[i]);
}




