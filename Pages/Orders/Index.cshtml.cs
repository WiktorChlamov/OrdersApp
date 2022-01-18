#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrdersApp.Data;
using OrdersApp.Models;

namespace OrdersApp.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly OrdersApp.Data.OrdersContext _context;

        public IndexModel(OrdersApp.Data.OrdersContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();
        }
    }
}
