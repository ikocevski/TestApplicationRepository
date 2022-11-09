using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestAppWeb.Models
{
    public class Hierarchy
    {
        [Key]
        public int Id { get; set; }

        public string HierarchyName { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }



    }
}
