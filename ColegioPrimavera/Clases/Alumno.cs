namespace ColegioPrimavera.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumnos")]
    public partial class Alumno
    {
        [Key]
        public int idAlumno { get; set; }

        [Required]
        [StringLength(45)]
        public string nombre { get; set; }

        public DateTime nacimiento { get; set; }

        public int idCurso { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
