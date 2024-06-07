using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipManagement.Repo
{
    internal interface IService
    {
       void AddInternShip();
       void SearchInternShip(string UserInput);
      
        void updateinternship(string Name);

        void DisplayDetails();
        //void DeleteInternship(string CompanyName);

    }
}
