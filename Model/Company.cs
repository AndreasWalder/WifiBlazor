using System.Linq;

namespace WifiBlazor.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Company()
        {
            if (DB.ListOfCompanies.Count < 1)
                Id = 1;
            else
                Id = DB.ListOfCompanies.LastOrDefault().Id + 1;
        }
        
    }
}