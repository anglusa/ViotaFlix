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

        public Int16 MovieYear{ get; set;}

        public Int16 Duration { get; set; }

        public byte AgeRating { get; set;}

        public string Image { get; set;}
    }