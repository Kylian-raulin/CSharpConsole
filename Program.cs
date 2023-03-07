// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ConsoleApp.Models;

class Program
{


    static double calculateSalary(int salary, double taxes)
    {
        return salary * (1 - taxes / 100);
    }

    static void Main(string[] args)
    {
        string[] month = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
        string closedMonth = "Aout";
        double tauxPrime = 0;
        User u1 = new User();
        u1.Id = 1;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("quel est votre prenom ");
        u1.FirstName = Console.ReadLine();
        Console.WriteLine("quel est votre nom ");
        u1.LastName = Console.ReadLine();
        Console.WriteLine("quel est votre age ? ");
        u1.Old = Console.ReadLine();
        Console.WriteLine("Quel est votre Salaire annuel Brut : ");
        bool salaryInInt = int.TryParse(u1.Salary = Console.ReadLine().Replace("€", ""), out int salary);
        Console.WriteLine("\nQuel est votre Taux d'imposition : ");
        double taxes = double.Parse(u1.Tax = Console.ReadLine().Replace("%", ""));
        Console.WriteLine("\nVous avez un salaire de : " + salary + "€ Brut" + "\nImposable a " + taxes + "%");
        double salaryNet = Math.Round(calculateSalary(salary, taxes), 2);
        Console.WriteLine("\nVous gagnez donc : " + salaryNet + "€ Net");
        switch (salary)
        
        {
            case >= 50000:
                Console.WriteLine("Je vous conseille de faire des dons à des associations tels que l'Oeuvre des Pupilles pour réduire votre Imposition");
                break;

            case <= 1500 * 12:
                Console.WriteLine("Ce salaire est normal pour un alternant");
                break;

            case <= 40000 when salary >= 30000:
                Console.WriteLine("Venez travailler chez CESI vous gagnerez 10000€ brut");
                break;

            default:
                Console.WriteLine("Vous avez un salaire correct");
                break;
        }
        
        try
        {
            Console.WriteLine("\n prime de noel: ");
            bool prime = double.TryParse(Console.ReadLine(), out double tauxprime);
        }catch(FormatException)
        {
            Console.WriteLine("c'est pas ça");
        }

        foreach (string eachMonth in month)
        {
            if (eachMonth != closedMonth)
            {
                if (eachMonth == "Décembre")
                {
                    Console.WriteLine("\n" + eachMonth + " : " + ((salaryNet / 12) * (1 + tauxPrime)));
                }
                else
                {
                    Console.WriteLine("\n" + eachMonth + " : " + salaryNet / 12);
                }
            }
        }
        Console.WriteLine(" id: " + u1.Id + " Nom: " + u1.FirstName + " Prenom: " + u1.LastName + "age: " + u1.Old + "salaire : " + u1.Salary + "taxe: " + u1.Tax);
        Console.ReadLine();
    }
}
