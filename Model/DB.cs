using System;
using System.Collections.Generic;

namespace WifiBlazor.Model
{
    public static class DB
    {
        public static List<Company> ListOfCompanies { get; set; } = new();
        public static List<Invoice> ListOfInvoices { get; set; } = new();

        static DB()
        {
            SeedData();
        }

        static void SeedData()
        {
            ListOfCompanies.Add(new Company()
            {
                Name = "Firma Stahlgruber"
            });

            ListOfCompanies.Add(new Company()
            {
                Name = "Firma Schneider"
            });

            ListOfInvoices.Add(new Invoice()
            {
                DateOfService = DateTime.Now,
                Service = "Garagentor repariert",
                Company = ListOfCompanies[0]
            });

        }

    }

}
