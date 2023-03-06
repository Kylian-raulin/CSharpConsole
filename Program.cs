// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

class Program
{
    static int CalculateSalary(int salary, int tax)
    {
        return (salary * (1 - tax / 100)) / 12;
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Enter salary before tax: ");
        int salary = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of tax: ");
        int tax = int.Parse(Console.ReadLine());

        int netSalary = CalculateSalary(salary, tax);
        Console.WriteLine("Si votre salaire est de " + salary + "est la tax de " + tax + "% alors votre net mensuel est " + CalculateSalary(salary, tax));
        Console.ReadLine();
    }

}
