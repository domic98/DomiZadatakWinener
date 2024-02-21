using System.ComponentModel.DataAnnotations;

namespace DomiZadatakWin.Models
{
    public class Partner
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Ime je obavezno")]
        [StringLength(255, ErrorMessage = "FirstName mora biti između 2 i 255 znakova")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Prezime je obavezno")]
        [StringLength(255, ErrorMessage = "LastName mora biti između 2 i 255 znakova")]

        public string LastName { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Partner Broj je obavezan")]
        [StringLength(20, MinimumLength = 20, ErrorMessage = "Partner Broj mora imati točno 20 znakova")]
        public string PartnerNumber { get; set; }

        [RegularExpression(@"\b\d{11}\b", ErrorMessage = "Hrvatski PIN mora biti 11 znamenki")]
        public string CroatianPIN { get; set; }

        [Required(ErrorMessage = "PartnerTypeId je obavezan")]
        [Range(1, 2, ErrorMessage = "PartnerTypeId mora biti 1 ili 2")]
        public int PartnerTypeId { get; set; }
        public DateTime CreatedAtUtc { get; set; }

        [Required(ErrorMessage = "CreateByUser je obavezan")]
        [StringLength(255, ErrorMessage = "CreateByUser ne smije biti duži od 255 znakova")]
        public string CreateByUser { get; set; }
        

        public bool? IsForeign { get; set; }

        [StringLength(20, MinimumLength = 10, ErrorMessage = "ExternalCode mora biti između 10 i 20 znakova")]
        public string ExternalCode { get; set; }

        [Required(ErrorMessage = "Gender je obavezan")]
        [RegularExpression("[M|F|N]", ErrorMessage = "Gender mora biti M, F ili N")]
        public char Gender { get; set; }

        // Navigation property for policies
        public List<Policy> Policies { get; set; }
    }
}
