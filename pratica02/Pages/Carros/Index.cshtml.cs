using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pratica02.Data;
using pratica02.Models;

namespace pratica02.Pages.Carros
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Carro> Carros { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Carros = await _context.Carros.ToListAsync();
        }
    }
}
