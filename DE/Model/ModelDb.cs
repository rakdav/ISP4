using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DE
{
    public partial class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=ModelDb")
        {
        }

        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<GroupModerator> GroupModerator { get; set; }
        public virtual DbSet<GroupZhuri> GroupZhuri { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Moderator> Moderator { get; set; }
        public virtual DbSet<NameZhuri> NameZhuri { get; set; }
        public virtual DbSet<Organizer> Organizer { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zhuri> Zhuri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.Foto)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Member)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Moderator)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Organizer)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Zhuri)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Activity)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasOptional(e => e.GroupModerator)
                .WithRequired(e => e.Event);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.GroupZhuri)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NameZhuri>()
                .HasMany(e => e.GroupZhuri)
                .WithRequired(e => e.NameZhuri)
                .WillCascadeOnDelete(false);
        }
    }
}
