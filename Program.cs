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
        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);
        switch (salary)
        {
            case >= 50000:
            
                Console.WriteLine("faite des dons pour réduire les impots");
                break;
            case <= 1500:
            
                Console.WriteLine("c'est normal pour un alternant");
                break;
            case > 30000:
                if (salary < 40000) 
                {
                    Console.WriteLine("venez au Cesi faire un bac +5");
                }
                break;
        }
        if (salaryIsInt)
        {
            Console.WriteLine("Enter the value of tax: ");
            bool taxIsInt = int.TryParse(Console.ReadLine(), out int tax);
            if (taxIsInt)
                {
                    double netSalary = CalculateSalary(salary, tax);

                    Console.WriteLine("Si votre salaire est de " + salary + "est la tax de " + tax + "% alors votre net mensuel est " + netSalary + "€");
                }
                else
                {
                Console.WriteLine("Sorry but yout tax it's not an integer");
                }
        }
        else
        {
            Console.WriteLine("Sorry but your salary it's not an integer");
        }
        Console.ReadLine();
        
        //int salary = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the value of tax: ");
        //int tax = int.Parse(Console.ReadLine());
       // int netSalary = CalculateSalary(salary, tax);
        
       // Console.ReadLine();
    }

}
