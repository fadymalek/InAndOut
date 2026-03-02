using Microsoft.AspNetCore.Mvc.Rendering;

namespace InAndOut.Models.ViewModels
{
    public class ExpenseVM
    {
        public Expense Expense { get; set; } = new Expense();
        public IEnumerable<SelectListItem> TypeDropDown { get; set; } = new List<SelectListItem>();
    }
}
