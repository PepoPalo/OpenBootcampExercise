using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace OpenBootcampBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescricionCorta { get; set; } = string.Empty;
        public string DescriptionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public enum Level { Básico, Itermedio, Avanado } 
    }
}
