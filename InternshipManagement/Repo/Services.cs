using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternshipManagement.Repo
{
    internal class Services: IService
    {
      

        public static List<Internship> internships = new List<Internship>();

        public void AddInternShip()
        {



            Company _Company = new Company();
            InternshipDetails _InternshipDetails = new InternshipDetails();
            Internship _internship = new Internship();
            Review _review = new Review();

            Console.WriteLine("Enter  the Company Name");
            string companyName = Console.ReadLine();

            Console.WriteLine("Enter Job Title");
            string jobtitle=Console.ReadLine(); 

            Console.WriteLine("Enter the Industry");
            string industry = Console.ReadLine();

            Console.WriteLine("Enter the Salery");
            int Salery = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Location");
            string locatioin =Console.ReadLine();

            Console.WriteLine("Enter the Date");
            var Date =Convert.ToDateTime(Console.ReadLine()).Date;

            Console.WriteLine("Add Reviews");
            double Review =Convert.ToDouble(Console.ReadLine());

            var id=internships.Count;
            var newId = id + 1;

            _internship.Id = newId;
            _Company.Name = companyName;
            _internship.JobTitle = jobtitle;
            _Company.Industry = industry;
            if(Salery!<=0)
            {
                _InternshipDetails.Salery = Salery;
            }
            _InternshipDetails.Date = Date;
            _internship.company = _Company;
            _internship.Details = _InternshipDetails;
            if (Review! > 5.0)
            {
                _review.Rating = Review;
            }
            

            internships.Add(_internship);

             //DisplayDetails();


        }

        public void DisplayDetails()
        {
            var internshipsDetails = from i in internships select i;
            


            foreach (Internship internship in internshipsDetails)
            {
                Console.WriteLine("CompanyName:" + internship.company.Name);
                Console.WriteLine("Industry:" + internship.company.Industry);
                Console.WriteLine("Salery" + internship.Details.Salery);
                Console.WriteLine("Date (YYYY/MM/Day) " + internship.Details.Date);
                
            }
            Console.ReadKey();
        }

        public void SearchInternShip(string userinput)
        {
            

            var filterLocations = from i in internships where i.company.Name == userinput select i;
          
            if (filterLocations == null)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                foreach (var internship in filterLocations)
                {
                    Console.WriteLine("companyname:" + internship.company.Name);
                    Console.WriteLine("industry:" + internship.company.Industry);
                    Console.WriteLine("salery" + internship.Details.Salery);
                    Console.WriteLine("date (yyyy/mm/day) " + internship.Details.Date);
                }
            }
            void LocationBasedInternships()
            {
                Console.WriteLine("Enter Location filter location");
                var userLocation = Console.ReadLine();
                var filteredByLocation = from i in filterLocations where i.company.Location == userLocation select i;
                foreach (var internship in filteredByLocation)
                {
                    Console.WriteLine("companyname:" + internship.company.Name);
                    Console.WriteLine("industry:" + internship.company.Industry);
                    Console.WriteLine("salery" + internship.Details.Salery);
                    Console.WriteLine("date (yyyy/mm/day) " + internship.Details.Date);
                }

                void SaleryBasedInterships()
                {
                    Console.WriteLine("Filtar Salery");
                    int filterSalery =int.Parse( Console.ReadLine());


                    var filteredSalery = from i in filterLocations where i.Details.Salery >= filterSalery select i;
                    foreach (var internship in filteredSalery)
                    {
                        Console.WriteLine("companyname:" + internship.company.Name);
                        Console.WriteLine("industry:" + internship.company.Industry);
                        Console.WriteLine("salery" + internship.Details.Salery);
                        Console.WriteLine("date (yyyy/mm/day) " + internship.Details.Date);
                    }

                }
                      SaleryBasedInterships();
            }

            LocationBasedInternships();

        }





        public void updateinternship(string Name)
        {
            var updateInternships = from i in internships where i.company.Name ==Name select i;
            if (updateInternships!=null)
            {
                Console.WriteLine("Enter new Company Name");
                string companyname = Console.ReadLine();

                Console.WriteLine("Enter new Location");
                string newlocation= Console.ReadLine();

                Console.WriteLine("Enter new Salery");
                int Salery =int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new Date");
                DateTime newDate =Convert.ToDateTime( Console.ReadLine()).Date;


                updateInternships.FirstOrDefault().company.Name = companyname;
                updateInternships.FirstOrDefault().company.Location = newlocation;
                updateInternships.FirstOrDefault().Details.Salery= Salery;
                updateInternships.FirstOrDefault().Details.Date = newDate;

                
            }

     

        }

        public void DeleteInternship(string Name)
        {
           // var updateInternships = from i in internships where i.company.Name == Name select i;
            var internshiptoDelete = from i in internships where internships.Count > 0 select i;
            var removeitem = internshiptoDelete.FirstOrDefault();

            internships.Remove(removeitem);
           
          
        }





    }
}
