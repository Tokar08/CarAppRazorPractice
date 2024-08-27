using System.ComponentModel.DataAnnotations;

namespace CarAppRazor.Model;

public class Car
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Brand is required!")]
    public string Brand { get; set; }

    [Required(ErrorMessage = "Model is required!")]
    public string Model { get; set; }

    [Required(ErrorMessage = "Year is required!")]
    [Range(1960, 2024, ErrorMessage = "Year: 1960-2024!")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Price is required!")]
    [Range(0.0, double.MaxValue, ErrorMessage = "Must be positive!")]
    public double Price { get; set; }
}