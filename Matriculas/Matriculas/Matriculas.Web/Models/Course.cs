using System.ComponentModel.DataAnnotations;

namespace Matriculas.Web.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string InicialDate { get; set; }
        public string FinalDate { get; set; }
        public int CourseCost { get; set; }
        public string DateInscripcion { get; set; }
        public int Capacity { get; set; }
        public int Intensity { get; set; }
        public string ClassSchedule { get; set; }

    }
    }
