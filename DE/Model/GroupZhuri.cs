namespace DE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupZhuri")]
    public partial class GroupZhuri
    {
        [Key]
        public int idGroupZhuri { get; set; }

        public int idNameZhuri { get; set; }

        public int idEvent { get; set; }

        public int idZhuri { get; set; }

        public virtual Event Event { get; set; }

        public virtual NameZhuri NameZhuri { get; set; }
    }
}
