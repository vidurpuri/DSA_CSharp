// See https://aka.ms/new-console-template for more information
using DSA_CSharp._00_Big0;
using DSA_CSharp._01_Section4_GoogleCoding;
using DSA_CSharp._02_Arrays_DS;

MergeSortedArray mergeSortedArray = new ();
Object[] arr1 = new Object[] { 0, 2, 3, 4, 29, 31, 78, 90 };
Object[] arr2 = new Object[] { 4, 6,8,9,10,13,30 };
var result = mergeSortedArray.MergeSortedArrayExercise(arr1,arr2);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}



