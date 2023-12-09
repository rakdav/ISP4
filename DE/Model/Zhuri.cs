namespace DE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zhuri")]
    public partial class Zhuri
    {
        [Required]
        [StringLength(255)]
        public string Surname { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string Gender { get; set; }

        [Required]
        [StringLength(255)]
        public string EMail { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDay { get; set; }

        public int idCountry { get; set; }

        [Required]
        [StringLength(255)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Target { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        public string Foto { get; set; }

        [Key]
        public int idZhuri { get; set; }

        public virtual Country Country { get; set; }
    }
}
