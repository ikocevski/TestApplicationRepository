using System.ComponentModel.DataAnnotations;

namespace TestAppWeb.Models
{
    public class ProgressBar
    {
        [Key]
        public int Id { get; set; }
        public string color { get; set; }
        public int startingPoint { get; set; }
        public int endPoint { get; set; }

    }
}
