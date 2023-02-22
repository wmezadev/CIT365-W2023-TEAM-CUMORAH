using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskASP.Models;

public class Quote
{
    public int Id { get; set; }

    [Display(Name = "Customer Name")]
    public string CustomerName { get; set; }

    public int Width { get; set; }

    [Display(Name = "Depth")]
    public int Height { get; set; }

    [Display(Name = "Surface Material")]
    public string SurfaceMaterial { get; set; }

    [Display(Name = "Number of Drawers")]
    public int Drawer { get; set; }

    [Display(Name = "Rush Days")]
    public int ProductionTime { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DateCreated { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }
}
