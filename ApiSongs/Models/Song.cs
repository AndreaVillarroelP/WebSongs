using System.ComponentModel.DataAnnotations;

namespace ApiSongs.Models
{
    public class Song
    {  
        [Key]//para validar el modelo
        [Display(Name = "Nombre de la cancion")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} Es requerido")]
        [Display(Name = "Autor")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} Es requerido")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Debe tener entre 10 y 1000 caracteres")]
        [Display(Name = "Letra")]
        public string Lyrics { get; set; }
        [Url]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Debe tener entre 10 y 500 caracteres")]
        [Display(Name = "Enlace")]
        public string Link { get; set; }
    }
}
