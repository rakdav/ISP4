namespace DE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        [Key]
        public int idActivity { get; set; }

        public int idEvent { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int day { get; set; }

        [Required]
        [StringLength(50)]
        public string time { get; set; }

        public virtual Event Event { get; set; }
    }
}
