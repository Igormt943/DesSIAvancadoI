using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pratica02.Data;
using pratica02.Models;

namespace pratica02.Pages.Carros
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Carro Carro { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Carros.Add(Carro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
