using ProgramaInterfazConsole.Models;

namespace ProgramaInterfazConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            CompanyModel gameDevCompany = new GameDevCompany();
            CompanyModel outSourcingCompany = new OutSourcingCompany();

            Console.WriteLine("Employees working in a Game company: ");
            gameDevCompany.CreateSoftware();

            Console.WriteLine("\nEmployees working in a Outsourcing company: ");
            outSourcingCompany.CreateSoftware();
        }
    }
}
