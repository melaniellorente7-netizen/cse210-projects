using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Samuel Bennet","Multiplication");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}