using InternshipManagement;
using InternshipManagement.Repo;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

internal class Program
{
  
   
    private static void Main(string[] args)
    {
       bool exit= true;
        while (exit)
        {
            MainMenu();
        }
       
        

        void MainMenu()
        {
            
            IService service = new Services();
          

            Console.WriteLine("Please Select one of the following Options by pressing Number");
            Console.WriteLine("1. Add Internship");
            Console.WriteLine("2. Search Internship");
            Console.WriteLine("3. Update Internship");
            Console.WriteLine("4. Delete Internship");
            Console.WriteLine("5. Press 5 for Display");
            Console.WriteLine("5. Press 6 for Exit");

            int operations = int.Parse(Console.ReadLine());
           
            if (operations is int && operations! <= 6)
            {
                switch (operations)
                {
                    case 1:
                        service.AddInternShip();
                        break;

                    case 2:
                        Console.WriteLine("Search Name for Company ");
                        string Name = Console.ReadLine();
                        service.SearchInternShip(Name);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Enter Company Name to update");
                        string CompanyName = Console.ReadLine();
                        service.updateinternship(CompanyName);
                       

                        break;
                    case 4:
                        Console.WriteLine("Enter Company Name to Delete");
                        string NameofCompany = Console.ReadLine();
                        service.updateinternship(NameofCompany);
                        break;

                        case 5:
                          service.DisplayDetails();
                        break;

                    case 6:
                        exit = false;
                        break;

                }
            }
            else if (operations is int)
            {
                Console.WriteLine("Invalid Number! Don't exceed the limit");
            }
            else if (operations is string)
            {
                Console.WriteLine("Invalid input");
            }

        }





    }
}

