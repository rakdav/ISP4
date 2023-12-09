namespace DE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organizer")]
    public partial class Organizer
    {
        [Required]
        [StringLength(50)]
        public string SurName { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [Required]
        [StringLength(50)]
        public string EMail { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public int idCountry { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Foto { get; set; }

        [Required]
        [StringLength(7)]
        public string Gender { get; set; }

        [Key]
        public int idOrganizer { get; set; }

        public virtual Country Country { get; set; }
    }
}
