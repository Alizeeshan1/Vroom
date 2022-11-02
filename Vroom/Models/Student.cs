using System.ComponentModel.DataAnnotations;
using Vroom.Utilities;

namespace Vroom.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [FirstCapitalLetter(ErrorMessage = "Capital Letter must be first and Special Character not allowed")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Last name should be between 3 and 15 characters")]
        public string FirstName { get; set; }

        [Required]
        [FirstCapitalLetter(ErrorMessage ="Capital Letter must be first and Special Character not allowed")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Last name should be between 3 and 15 characters")]
        public string LastName { get; set; }

        [StringLength(15, MinimumLength= 15)]
        [DataType(DataType.PhoneNumber)]
        [PhoneNumber(ErrorMessage ="Phone Number Must be start from +966")]
        public string PhoneNumber  { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "DOB")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}" , ApplyFormatInEditMode =true)]
        public DateTime DOB { get; set; }
    }
}
