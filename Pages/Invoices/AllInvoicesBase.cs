using System.Collections.Generic;
using System.Threading.Tasks;
using WifiBlazor.Model;

namespace WifiBlazor.Pages.Invoices
{
    public class AllInvoicesBase :GlobalComponent
    {
       protected List<Invoice> Bills { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            Bills = DB.ListOfInvoices;
        }
    }
}
