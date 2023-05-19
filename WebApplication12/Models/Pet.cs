using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Pet
    {
        [Key]
        public string PetId { get; set; }

        [Required(ErrorMessage = "Не указано имя ")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string PetName { get; set; }

        [Required]
        public string PetType { get; set; }

        [Required]
        [Range(1, 30, ErrorMessage = "Возраст должен быть в диапазоне {1}-{2}")]
        public int Age { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        //[RegularExpression(@"^\+[1-9]\d{2}-\d{7}$", ErrorMessage = "Введите номер в формате +375XXYYYYYYY")]
        [Phone]
       
        public string Phone { get; set; }

       
        public User User { get; set; } 
        
        //public DateTime DO { get; set; }

        //public int calculateage(DateTime DO)
        //{
        //    var today = DateTime.Now;
        //    var Age = today.Year - DOB.Year;
        //    if (DOB.Date > today.AddYears(-Age)) Age--;
        //    return Age + 1;
        //}
    }
}
