using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Matriculas.Web.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [MaxLength(10, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public int TeacherIdentification { get; set; }
        public string TeacherFullName { get; set; }
        public string Dateofbirth { get; set; }
        public string TeacherAddress { get; set; }
        public string TeacherCellPhone { get; set; }
        public string ArtisticArea { get; set; }
        [JsonIgnore] //lo ignora en la respuesta json
        [NotMapped] //no se crea en la base de datos
        public int IdCourse { get; set; }

    }
}
