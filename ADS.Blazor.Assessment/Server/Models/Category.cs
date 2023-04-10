using System.ComponentModel.DataAnnotations;

namespace ADS.Blazor.Assessment.Server.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } = 0; // added base value so category should never be null
        public string Name { get; set; } = "";
    }
}
