using System.ComponentModel.DataAnnotations;
namespace DotNet.Models
{
    public class Concert
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de l'artiste est obligatoire")]
        [Display(Name = "Artiste")]
        public string Artiste { get; set; }

        [Required(ErrorMessage = "La date est obligatoire")]
        [Display(Name = "Date du concert")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "L'heure est obligatoire")]
        [Display(Name = "Heure de début")]
        [DataType(DataType.Time)]
        public TimeSpan HeureDebut { get; set; }

        [Required(ErrorMessage = "Le lieu est obligatoire")]
        [Display(Name = "Lieu")]
        public string Lieu { get; set; }

        [Required(ErrorMessage = "Le prix est obligatoire")]
        [Display(Name = "Prix du billet")]
        [Range(0, 1000, ErrorMessage = "Le prix doit être entre 0 et 1000 DT")]
        public decimal PrixBillet { get; set; }

        [Required(ErrorMessage = "Le nombre de places est obligatoire")]
        [Display(Name = "Places disponibles")]
        [Range(0, 10000, ErrorMessage = "Le nombre de places doit être entre 0 et 10000")]
        public int PlacesDisponibles { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
