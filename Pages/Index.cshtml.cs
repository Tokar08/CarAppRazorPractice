using CarAppRazor.Data;
using CarAppRazor.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CarAppRazor.Pages;

public class IndexModel : PageModel
{
    private readonly CarDbContext _context;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(CarDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
        Cars = new List<Car>();
    }

    public List<Car> Cars { get; set; }

    public async Task OnGetAsync()
    {
        try
        {
            Cars = await _context.Cars.ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving car data!");
        }
    }
}