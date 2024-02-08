using System.ComponentModel.DataAnnotations;
using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello to Max / Min! ");

        Console.WriteLine();

        Sorter quickSorter=new Sorter(new QuickSort());

        Sorter mergeSorter =new Sorter(new MergeSort());

        List<int> numbers = new List<int> { 7, 2, 11 , 3, 9, 1, 8, 4, 6 , 16 };

        List <int> numbers_copy=new List<int> (numbers);

        Console.Write("Initially :  ");

        display(numbers);

        quickSorter.Sort(numbers);

        Console.Write("Sorted with QuickSort: " );
        
        display(numbers);

        Console.WriteLine("Max : " + quickSorter.computeMax(numbers) + " and Min: " + quickSorter.computeMin(numbers));
        
        Console.WriteLine();

        Console.Write("Initially :  ");

        display(numbers_copy);

        mergeSorter.Sort(numbers_copy);

        Console.Write("Sorted with Merge Sort: ");

        display(numbers_copy);

        Console.WriteLine("Max : " + mergeSorter.computeMax(numbers) + " and Min : " + mergeSorter.computeMin(numbers));

    }

    static void display(List <int> l)
    {
        foreach(int elem in l)
        {
            Console.Write(elem + " ");
        }

        Console.WriteLine();
    }
}