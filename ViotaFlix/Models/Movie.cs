using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViotaFlix.Models;

    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public uint Id { get; set; }

        [Display(Name = "Titulo Original")]
        [Required(ErrorMessage = "Por Favor informe o titulo original")]
        [StringLength(100,ErrorMessage ="O Titulo Original deve possuir 100 caracteres")]
        public string OrginalTitle { get; set;}
        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "Por Favor,informe o titulo original")]
        [StringLength(100,ErrorMessage ="O Titulo deve possuir 100 caracteres")]

        public string Title { get; set;}
        [Display(Name = "Resumo")]
        [StringLength(8000,ErrorMessage ="O Resumo deve possuir 8000 caracteres")]
        public string Synopsis { get; set;}
        
        [Column(TypeName = "Year")]
        [Display(Name = "Ano de Estreia")]
        public Int16 MovieYear{ get; set;}

        [Display(Name = "Duração (em minutos)")]
        [Required(ErrorMessage = "Por Favor,informe a duração")]
        public Int16 Duration { get; set; }

        [Display(Name = "Classificação Etária")]
        [Required(ErrorMessage = "Por favor, informe a classificação etária")]
        public byte AgeRating { get; set;}

         [Display(Name = "Foto")]
         [StringLength(200)]
        public string Image { get; set;}

        [NotMapped]
        [Display(Name = "Duração")]
        public string HourDuration { get {
            return TimeSpan.FromMinutes(Duration).ToString(@"h'h' m'min' ");
        } }

        public ICollection<MovieGenre> Genres { get; set; }
    }