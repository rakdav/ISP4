namespace DE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupModerator")]
    public partial class GroupModerator
    {
        [Key]
        public int idGroupModerator { get; set; }

        public int idEvent { get; set; }

        public int idModerator { get; set; }

        public virtual Event Event { get; set; }
    }
}
