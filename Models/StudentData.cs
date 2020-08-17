
using System.ComponentModel.DataAnnotations;

namespace StudentSystemWeb.Models
{
    public class StudentData
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string SurName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [MaxLength(20)]
        public string Class { get; set; }
    }
}
