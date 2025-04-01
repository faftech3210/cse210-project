using System;

class Program
{
    static void Main(string[] args)
    {
        assignment a1 = new assignment("Franklin", "Fractions");
        Console.WriteLine(a1.GetSummary());

        mathassignment ma = new mathassignment("Franklin", "Fraction", "1.0", "5-10");
        Console.WriteLine(ma.GetHomeWorkList());

        writingassignment wa = new writingassignment("Franklin Akor", "African history", "Nigerian Civil War");
        Console.WriteLine(wa.GetWritinginfo());
    }
}