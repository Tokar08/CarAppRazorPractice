using CarAppRazor.Data;
using CarAppRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAppRazor.Pages.Cars;

public class Create : PageModel
{
    private readonly CarDbContext _context;
    private readonly ILogger<Create> _logger;


    public Create(CarDbContext context, ILogger<Create> logger)
    {
        _context = context;
        _logger = logger;
    }

    [BindProperty] public Car Car { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        try
        {
            _context.Cars.Add(Car);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error saving car data!");
            return Page();
        }
    }
}